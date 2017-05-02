CREATE TABLE dbo.tAuthorizationRole
   (Id int PRIMARY KEY NOT NULL,
    Code nvarchar(40) NOT NULL)
GO

insert into tAuthorizationRole (Id, Code) values (1, N'Administrator')
insert into tAuthorizationRole (Id, Code) values (2, N'Operator')

CREATE TABLE dbo.tUser
   (Id int PRIMARY KEY NOT NULL IDENTITY(1, 1),
    Version int NOT NULL,
    Guid UNIQUEIDENTIFIER NOT NULL,
    UserName nvarchar(100) NOT NULL,
	PasswordHash nvarchar(500),
	HasEmptyPassword bit NOT NULL,
	FirstName nvarchar(100),
	LastName nvarchar(100),
	Email nvarchar(100),
	Title nvarchar(100),
	ContactPhone nvarchar(100),
	OfficeNumber nvarchar(100),
	CreatedAt DateTime NOT NULL default getdate(),
	IsValid bit NOT NULL default 0,
	AuthorizationRoleId int NOT NULL default 2)
GO

ALTER TABLE tUser
ADD CONSTRAINT FK_User_AutorizationRole FOREIGN KEY (AuthorizationRoleId)
REFERENCES tAuthorizationRole (Id)

CREATE TABLE dbo.tDocument
   (Id int PRIMARY KEY NOT NULL IDENTITY(1, 1),
    Version int NOT NULL,
    Guid UNIQUEIDENTIFIER NOT NULL,
    Title nvarchar(200) NOT NULL,
    Extension nvarchar(10) NOT NULL,
    IsValid bit NOT NULL default 0,
    IsArchived bit NOT NULL default 0,
    IsLocked bit NOT NULL default 0,
    CreatedAt DateTime NOT NULL default getdate(),
    LastModifiedAt DateTime)
GO

CREATE TABLE dbo.tDocumentAccessRight
   (Id int PRIMARY KEY NOT NULL,
    Code nvarchar(40) NOT NULL)
GO

insert into tDocumentAccessRight (Id, Code) values (1, N'ReadOnly')
insert into tDocumentAccessRight (Id, Code) values (2, N'Modify')
insert into tDocumentAccessRight (Id, Code) values (3, N'Owner')

GO
DROP TABLE dbo.tUserDocument

CREATE TABLE dbo.tUserDocument
   (Id int PRIMARY KEY NOT NULL IDENTITY(1, 1), 
   	UserId int NOT NULL FOREIGN KEY REFERENCES tUser(Id),
    DocumentId int NOT NULL FOREIGN KEY REFERENCES tDocument(Id),
	IsReading bit  NOT NULL,
	IsWriting bit NOT NULL,
	DocumentAccessRightId int NOT NULL FOREIGN KEY REFERENCES tDocumentAccessRight(Id)
	)

GO

CREATE TABLE dbo.tDocumentVersion
   (Id int PRIMARY KEY NOT NULL IDENTITY(1, 1),
    Version int NOT NULL,
    Guid UNIQUEIDENTIFIER NOT NULL,
    HierarchyId int NOT NULL,
	CreatedAt DateTime  NOT NULL,
	FilePath nvarchar(500) NOT NULL,
	DocumentId int NOT NULL
	)

ALTER TABLE tDocumentVersion
ADD CONSTRAINT FK_Version_Document_Id FOREIGN KEY (DocumentId)
REFERENCES tDocument (Id)

GO

CREATE TABLE dbo.tComment
   (Id int PRIMARY KEY NOT NULL IDENTITY(1, 1),
	CreatedAt DateTime  NOT NULL,
	Text nvarchar(500) NOT NULL,
	DocumentVersionId int NOT NULL,
	UserId int not null
	)


ALTER TABLE tComment
ADD CONSTRAINT FK_Comment_DocumentVersion_Id FOREIGN KEY (DocumentVersionId)
REFERENCES tDocumentVersion (Id)

ALTER TABLE tComment
ADD CONSTRAINT FK_Comment_User_Id FOREIGN KEY (UserId)
REFERENCES tUser (Id)

GO

CREATE TABLE dbo.tKeyword
   (Id int PRIMARY KEY NOT NULL IDENTITY(1, 1),
    Name nvarchar(150) NOT NULL
	)

CREATE TABLE dbo.tDocumentKeyword
	(DocumentId int NOT NULL,
	KeywordId int NOT NULL
	)

ALTER TABLE tDocumentKeyword
ADD CONSTRAINT FK_Keyword_Document_Id FOREIGN KEY (DocumentId)
REFERENCES tDocument (Id)

ALTER TABLE tDocumentKeyword
ADD CONSTRAINT FK_DK_Keyword_Id FOREIGN KEY (KeywordId)
REFERENCES tKeyword (Id)

ALTER TABLE tDocumentKeyword
ADD CONSTRAINT PK_DocumentKeyword PRIMARY KEY (DocumentId, KeywordId)

GO