using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DMS.Utils
{
	/// <summary>
	/// By Colin Meek
	/// </summary>
	public class ParameterRebinder : ExpressionVisitor
	{
		private readonly Dictionary<ParameterExpression, ParameterExpression> map;

		public ParameterRebinder(Dictionary<ParameterExpression, ParameterExpression> map)
		{
			this.map = map ?? new Dictionary<ParameterExpression, ParameterExpression>();
		}

		public static Expression ReplaceParameters(Dictionary<ParameterExpression, ParameterExpression> map, Expression exp)
		{
			return new ParameterRebinder(map).Visit(exp);
		}

		protected override Expression VisitParameter(ParameterExpression p)
		{
			ParameterExpression replacement;
			if (map.TryGetValue(p, out replacement))
			{
				p = replacement;
			}
			return base.VisitParameter(p);
		}
	}

	public static class ExpressionUtils
	{
		public static Expression<T> Compose<T>(this Expression<T> first, Expression<T> second, Func<Expression, Expression, Expression> merge)
		{
			// build parameter map (from parameters of second to parameters of first)
			var map = first.Parameters.Select((f, i) => new { f, s = second.Parameters[i] }).ToDictionary(p => p.s, p => p.f);

			// replace parameters in the second lambda expression with parameters from the first
			var secondBody = ParameterRebinder.ReplaceParameters(map, second.Body);

			// apply composition of lambda expression bodies to parameters from the first expression 
			return Expression.Lambda<T>(merge(first.Body, secondBody), first.Parameters);
		}
	
		/// <summary>
		/// Creates new expression by connecting left and right expression with AND operator.
		/// </summary>
		/// <param name="left">The left expression.</param>
		/// <param name="right">The right expression.</param>
		public static Expression<T> AndOperation<T>(Expression<T> left, Expression<T> right)
		{
			var parameter = Expression.Parameter(typeof(T));

			if (left == null && right == null)
				return null;
			else if (left != null && right != null)
				return left.Compose(right, Expression.And);
			else if (left != null)
				return left;
			else
				return right;
		}

		/// <summary>
		/// Creates new expression by connecting left and right expression with OR operator.
		/// </summary>
		/// <param name="left">The left expression.</param>
		/// <param name="right">The right expression.</param>
		public static Expression<T> OrOperation<T>(Expression<T> left, Expression<T> right)
		{
			if (left == null && right == null)
				return null;
			else if (left != null && right != null)
				return left.Compose(right, Expression.Or);
			else if (left != null)
				return left;
			else
				return right;
		}

	}
}
