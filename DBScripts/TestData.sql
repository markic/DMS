-- USERS

GO
delete from tComment
delete from tDocumentVersion
delete from tUserDocument
delete from tDocumentKeyword
delete from tUser
DBCC CHECKIDENT (tUser, RESEED, 10)

INSERT INTO tUser(Version, Guid, UserName, PasswordHash, HasEmptyPassword, FirstName, LastName, Email, Title, ContactPhone, OfficeNumber, IsValid, AuthorizationRoleId, CreatedAt) values(1, newid(),N'admin1',N'63BD7AD4E9B4CC2C7DE864151F0A903C',0,N'First',N'Admin',N'mm@mm.rs',N'Engineer',N'213',N'B43',1,1, getdate())
INSERT INTO tUser(Version, Guid, UserName, PasswordHash, HasEmptyPassword, FirstName, LastName, Email, Title, ContactPhone, OfficeNumber, IsValid, AuthorizationRoleId, CreatedAt) values(1, newid(),N'user1',N'63BD7AD4E9B4CC2C7DE864151F0A903C',0,N'First',N'User',N'',N'',N'',N'',1,2, getdate())
INSERT INTO tUser(Version, Guid, UserName, PasswordHash, HasEmptyPassword, FirstName, LastName, Email, Title, ContactPhone, OfficeNumber, IsValid, AuthorizationRoleId, CreatedAt) values(1, newid(),N'mm',N'68E426A2CE576E090C39A20D8C1E3936',0,N'Marin',N'Markic',N'mm@etf.rs',N'Mr.',N'123',N'32',1,1, getdate())
INSERT INTO tUser(Version, Guid, UserName, PasswordHash, HasEmptyPassword, FirstName, LastName, Email, Title, ContactPhone, OfficeNumber, IsValid, AuthorizationRoleId, CreatedAt) values(1, newid(),N'MIlos',N'68E426A2CE576E090C39A20D8C1E3936',0,N'Stan',N'Marsh',N'',N'',N'',N'',1,2, getdate())
INSERT INTO tUser(Version, Guid, UserName, PasswordHash, HasEmptyPassword, FirstName, LastName, Email, Title, ContactPhone, OfficeNumber, IsValid, AuthorizationRoleId, CreatedAt) values(1, newid(),N'Ivan',N'68E426A2CE576E090C39A20D8C1E3936',0,N'Octavian',N'Augustus',N'',N'',N'',N'',1,2, getdate())
INSERT INTO tUser(Version, Guid, UserName, PasswordHash, HasEmptyPassword, FirstName, LastName, Email, Title, ContactPhone, OfficeNumber, IsValid, AuthorizationRoleId, CreatedAt) values(1, newid(),N'Vsauce',N'68E426A2CE576E090C39A20D8C1E3936',0,N'Youtuber',N'VSauce',N'',N'',N'',N'',1,2, getdate())
INSERT INTO tUser(Version, Guid, UserName, PasswordHash, HasEmptyPassword, FirstName, LastName, Email, Title, ContactPhone, OfficeNumber, IsValid, AuthorizationRoleId, CreatedAt) values(1, newid(),N'JM',N'68E426A2CE576E090C39A20D8C1E3936',0,N'Jenna',N'Marbles',N'',N'',N'',N'',1,2, getdate())
INSERT INTO tUser(Version, Guid, UserName, PasswordHash, HasEmptyPassword, FirstName, LastName, Email, Title, ContactPhone, OfficeNumber, IsValid, AuthorizationRoleId, CreatedAt) values(1, newid(),N'Matt',N'C912061FA268B2447CED8D9FA077E82E',0,N'Matthew',N'Santoro',N'',N'Youtuber',N'',N'',1,2, getdate())
INSERT INTO tUser(Version, Guid, UserName, PasswordHash, HasEmptyPassword, FirstName, LastName, Email, Title, ContactPhone, OfficeNumber, IsValid, AuthorizationRoleId, CreatedAt) values(1, newid(),N'VXA',N'',1,N'Marcus',N'Brutus',N'',N'',N'',N'',1,2, getdate())
INSERT INTO tUser(Version, Guid, UserName, PasswordHash, HasEmptyPassword, FirstName, LastName, Email, Title, ContactPhone, OfficeNumber, IsValid, AuthorizationRoleId, CreatedAt) values(1, newid(),N'Oliver',N'',1,N'Oliver',N'Queen',N'',N'',N'',N'',1,2, getdate())
INSERT INTO tUser(Version, Guid, UserName, PasswordHash, HasEmptyPassword, FirstName, LastName, Email, Title, ContactPhone, OfficeNumber, IsValid, AuthorizationRoleId, CreatedAt) values(1, newid(),N'Santa',N'',1,N'Santa',N'Claus',N'',N'',N'',N'',1,2, getdate())
INSERT INTO tUser(Version, Guid, UserName, PasswordHash, HasEmptyPassword, FirstName, LastName, Email, Title, ContactPhone, OfficeNumber, IsValid, AuthorizationRoleId, CreatedAt) values(1, newid(),N'JS',N'',1,N'Jason',N'Statham',N'',N'mrJ',N'',N'',1,2, getdate())

GO

delete from tDocument
DBCC CHECKIDENT (tDocument, RESEED, 10)

INSERT INTO tDocument(Version, Guid, Title, Extension, IsValid, IsArchived, IsLocked, CreatedAt, LastModifiedAt) values(1, newid(),N'Prvi dokument admin1',N'txt',1,0,0,getdate(), NULL)
INSERT INTO tDocument(Version, Guid, Title, Extension, IsValid, IsArchived, IsLocked, CreatedAt, LastModifiedAt) values(1, newid(),N'mm Dokument1',N'pdf',1,0,0,getdate(), NULL)
INSERT INTO tDocument(Version, Guid, Title, Extension, IsValid, IsArchived, IsLocked, CreatedAt, LastModifiedAt) values(1, newid(),N'Alexander G. Bell',N'pdf',1,0,0,getdate(), NULL)
INSERT INTO tDocument(Version, Guid, Title, Extension, IsValid, IsArchived, IsLocked, CreatedAt, LastModifiedAt) values(1, newid(),N'Thomas Edison',N'pdf',1,0,0,getdate(), NULL)
INSERT INTO tDocument(Version, Guid, Title, Extension, IsValid, IsArchived, IsLocked, CreatedAt, LastModifiedAt) values(1, newid(),N'Michael Faraday',N'txt',1,0,0,getdate(), NULL)
INSERT INTO tDocument(Version, Guid, Title, Extension, IsValid, IsArchived, IsLocked, CreatedAt, LastModifiedAt) values(1, newid(),N'Henirich Hertz',N'txt',1,0,0,getdate(), NULL)
INSERT INTO tDocument(Version, Guid, Title, Extension, IsValid, IsArchived, IsLocked, CreatedAt, LastModifiedAt) values(1, newid(),N'Alexander Siemens',N'docx',1,0,0,getdate(), NULL)
INSERT INTO tDocument(Version, Guid, Title, Extension, IsValid, IsArchived, IsLocked, CreatedAt, LastModifiedAt) values(1, newid(),N'Nikola Tesla',N'odg',1,0,0,getdate(), NULL)
INSERT INTO tDocument(Version, Guid, Title, Extension, IsValid, IsArchived, IsLocked, CreatedAt, LastModifiedAt) values(1, newid(),N'Robert Watson-Watt',N'pptx',1,0,0,getdate(), NULL)
INSERT INTO tDocument(Version, Guid, Title, Extension, IsValid, IsArchived, IsLocked, CreatedAt, LastModifiedAt) values(1, newid(),N'George Westinghouse',N'txt',1,0,0,getdate(), NULL)
INSERT INTO tDocument(Version, Guid, Title, Extension, IsValid, IsArchived, IsLocked, CreatedAt, LastModifiedAt) values(1, newid(),N'Steve Wozniak',N'css',1,0,0,getdate(), NULL)
INSERT INTO tDocument(Version, Guid, Title, Extension, IsValid, IsArchived, IsLocked, CreatedAt, LastModifiedAt) values(1, newid(),N'Andre Marie Ampere',N'jpg',1,0,0,getdate(), NULL)
INSERT INTO tDocument(Version, Guid, Title, Extension, IsValid, IsArchived, IsLocked, CreatedAt, LastModifiedAt) values(1, newid(),N'Alessandro Volta',N'jpg',1,0,0,getdate(), NULL)
INSERT INTO tDocument(Version, Guid, Title, Extension, IsValid, IsArchived, IsLocked, CreatedAt, LastModifiedAt) values(1, newid(),N'George Simon Ohm',N'jpg',1,0,0,getdate(), NULL)

GO
delete from tKeyword
DBCC CHECKIDENT (tKeyword, RESEED, 10)

INSERT INTO tKeyword(Name) values(N'rec1')
INSERT INTO tKeyword(Name) values(N'nova-rec2')
INSERT INTO tKeyword(Name) values(N'kljucna')
INSERT INTO tKeyword(Name) values(N'rec1')
INSERT INTO tKeyword(Name) values(N'rec2')
INSERT INTO tKeyword(Name) values(N'transformer')
INSERT INTO tKeyword(Name) values(N'watt')
INSERT INTO tKeyword(Name) values(N'west')
INSERT INTO tKeyword(Name) values(N'ohm')

GO
INSERT INTO tDocumentKeyWord(DocumentId, KeywordId) values(11,11)
INSERT INTO tDocumentKeyWord(DocumentId, KeywordId) values(11,12)
INSERT INTO tDocumentKeyWord(DocumentId, KeywordId) values(11,13)
INSERT INTO tDocumentKeyWord(DocumentId, KeywordId) values(12,14)
INSERT INTO tDocumentKeyWord(DocumentId, KeywordId) values(12,15)
INSERT INTO tDocumentKeyWord(DocumentId, KeywordId) values(18,16)
INSERT INTO tDocumentKeyWord(DocumentId, KeywordId) values(19,17)
INSERT INTO tDocumentKeyWord(DocumentId, KeywordId) values(20,18)
INSERT INTO tDocumentKeyWord(DocumentId, KeywordId) values(24,19)

GO

DBCC CHECKIDENT (tUserDocument, RESEED, 10)

INSERT INTO tUserDocument(UserId, DocumentId, IsReading, IsWriting, DocumentAccessRightId) values(18,11,0,0,1)
INSERT INTO tUserDocument(UserId, DocumentId, IsReading, IsWriting, DocumentAccessRightId) values(15,11,0,0,2)
INSERT INTO tUserDocument(UserId, DocumentId, IsReading, IsWriting, DocumentAccessRightId) values(11,11,0,0,3)
INSERT INTO tUserDocument(UserId, DocumentId, IsReading, IsWriting, DocumentAccessRightId) values(13,11,0,0,2)
INSERT INTO tUserDocument(UserId, DocumentId, IsReading, IsWriting, DocumentAccessRightId) values(17,12,0,0,1)
INSERT INTO tUserDocument(UserId, DocumentId, IsReading, IsWriting, DocumentAccessRightId) values(13,12,0,0,3)
INSERT INTO tUserDocument(UserId, DocumentId, IsReading, IsWriting, DocumentAccessRightId) values(11,12,0,0,2)
INSERT INTO tUserDocument(UserId, DocumentId, IsReading, IsWriting, DocumentAccessRightId) values(13,13,0,0,3)
INSERT INTO tUserDocument(UserId, DocumentId, IsReading, IsWriting, DocumentAccessRightId) values(11,13,0,0,2)
INSERT INTO tUserDocument(UserId, DocumentId, IsReading, IsWriting, DocumentAccessRightId) values(22,14,0,0,1)
INSERT INTO tUserDocument(UserId, DocumentId, IsReading, IsWriting, DocumentAccessRightId) values(12,14,0,0,1)
INSERT INTO tUserDocument(UserId, DocumentId, IsReading, IsWriting, DocumentAccessRightId) values(13,14,0,0,3)
INSERT INTO tUserDocument(UserId, DocumentId, IsReading, IsWriting, DocumentAccessRightId) values(11,14,0,0,2)
INSERT INTO tUserDocument(UserId, DocumentId, IsReading, IsWriting, DocumentAccessRightId) values(12,15,0,0,2)
INSERT INTO tUserDocument(UserId, DocumentId, IsReading, IsWriting, DocumentAccessRightId) values(11,15,0,0,3)
INSERT INTO tUserDocument(UserId, DocumentId, IsReading, IsWriting, DocumentAccessRightId) values(13,15,0,0,2)
INSERT INTO tUserDocument(UserId, DocumentId, IsReading, IsWriting, DocumentAccessRightId) values(12,16,0,0,3)
INSERT INTO tUserDocument(UserId, DocumentId, IsReading, IsWriting, DocumentAccessRightId) values(11,16,0,0,2)
INSERT INTO tUserDocument(UserId, DocumentId, IsReading, IsWriting, DocumentAccessRightId) values(13,16,0,0,2)
INSERT INTO tUserDocument(UserId, DocumentId, IsReading, IsWriting, DocumentAccessRightId) values(13,17,0,0,3)
INSERT INTO tUserDocument(UserId, DocumentId, IsReading, IsWriting, DocumentAccessRightId) values(11,17,0,0,2)
INSERT INTO tUserDocument(UserId, DocumentId, IsReading, IsWriting, DocumentAccessRightId) values(12,18,0,0,2)
INSERT INTO tUserDocument(UserId, DocumentId, IsReading, IsWriting, DocumentAccessRightId) values(13,18,0,0,3)
INSERT INTO tUserDocument(UserId, DocumentId, IsReading, IsWriting, DocumentAccessRightId) values(11,18,0,0,2)
INSERT INTO tUserDocument(UserId, DocumentId, IsReading, IsWriting, DocumentAccessRightId) values(16,19,0,0,1)
INSERT INTO tUserDocument(UserId, DocumentId, IsReading, IsWriting, DocumentAccessRightId) values(14,19,0,0,2)
INSERT INTO tUserDocument(UserId, DocumentId, IsReading, IsWriting, DocumentAccessRightId) values(13,19,0,0,3)
INSERT INTO tUserDocument(UserId, DocumentId, IsReading, IsWriting, DocumentAccessRightId) values(11,19,0,0,2)
INSERT INTO tUserDocument(UserId, DocumentId, IsReading, IsWriting, DocumentAccessRightId) values(11,20,0,0,3)
INSERT INTO tUserDocument(UserId, DocumentId, IsReading, IsWriting, DocumentAccessRightId) values(13,20,0,0,2)
INSERT INTO tUserDocument(UserId, DocumentId, IsReading, IsWriting, DocumentAccessRightId) values(11,21,0,0,3)
INSERT INTO tUserDocument(UserId, DocumentId, IsReading, IsWriting, DocumentAccessRightId) values(13,21,0,0,2)
INSERT INTO tUserDocument(UserId, DocumentId, IsReading, IsWriting, DocumentAccessRightId) values(22,22,0,0,3)
INSERT INTO tUserDocument(UserId, DocumentId, IsReading, IsWriting, DocumentAccessRightId) values(11,22,0,0,2)
INSERT INTO tUserDocument(UserId, DocumentId, IsReading, IsWriting, DocumentAccessRightId) values(13,22,0,0,2)
INSERT INTO tUserDocument(UserId, DocumentId, IsReading, IsWriting, DocumentAccessRightId) values(12,23,0,0,1)
INSERT INTO tUserDocument(UserId, DocumentId, IsReading, IsWriting, DocumentAccessRightId) values(22,23,0,0,3)
INSERT INTO tUserDocument(UserId, DocumentId, IsReading, IsWriting, DocumentAccessRightId) values(11,23,0,0,2)
INSERT INTO tUserDocument(UserId, DocumentId, IsReading, IsWriting, DocumentAccessRightId) values(13,23,0,0,2)
INSERT INTO tUserDocument(UserId, DocumentId, IsReading, IsWriting, DocumentAccessRightId) values(11,24,0,0,3)
INSERT INTO tUserDocument(UserId, DocumentId, IsReading, IsWriting, DocumentAccessRightId) values(13,24,0,0,2)

GO

DBCC CHECKIDENT (tDocumentVersion, RESEED, 10)


INSERT INTO tDocumentVersion(Version, Guid, HierarchyId, CreatedAt, FilePath, DocumentId) values(1,N'57DAC9E7-C6D9-4628-A407-E7E5912CF90E',1,getdate(),N'57dac9e7-c6d9-4628-a407-e7e5912cf90e.txt',11)
INSERT INTO tDocumentVersion(Version, Guid, HierarchyId, CreatedAt, FilePath, DocumentId) values(1,N'29E21EDC-4D35-4CE8-A0E3-98A416A5FC90',1,getdate(),N'29e21edc-4d35-4ce8-a0e3-98a416a5fc90.pdf',12)
INSERT INTO tDocumentVersion(Version, Guid, HierarchyId, CreatedAt, FilePath, DocumentId) values(1,N'552C79A0-1741-479A-9391-A3AC25FCA66F',1,getdate(),N'552c79a0-1741-479a-9391-a3ac25fca66f.pdf',13)
INSERT INTO tDocumentVersion(Version, Guid, HierarchyId, CreatedAt, FilePath, DocumentId) values(1,N'2D828BF1-3C53-43E3-9D21-951C8F93B701',1,getdate(),N'2d828bf1-3c53-43e3-9d21-951c8f93b701.pdf',14)
INSERT INTO tDocumentVersion(Version, Guid, HierarchyId, CreatedAt, FilePath, DocumentId) values(1,N'F5E1D289-330A-4EEC-8E08-91B0FA219E32',1,getdate(),N'f5e1d289-330a-4eec-8e08-91b0fa219e32.txt',15)
INSERT INTO tDocumentVersion(Version, Guid, HierarchyId, CreatedAt, FilePath, DocumentId) values(1,N'E325C7D0-25FC-4C65-BBC1-8D2F7017D39A',1,getdate(),N'e325c7d0-25fc-4c65-bbc1-8d2f7017d39a.txt',16)
INSERT INTO tDocumentVersion(Version, Guid, HierarchyId, CreatedAt, FilePath, DocumentId) values(1,N'3921C9C4-01BE-4975-8671-C49A789AB3F5',1,getdate(),N'3921c9c4-01be-4975-8671-c49a789ab3f5.docx',17)
INSERT INTO tDocumentVersion(Version, Guid, HierarchyId, CreatedAt, FilePath, DocumentId) values(1,N'BF8476DA-A172-4054-9100-43FB01544FE5',1,getdate(),N'bf8476da-a172-4054-9100-43fb01544fe5.odg',18)
INSERT INTO tDocumentVersion(Version, Guid, HierarchyId, CreatedAt, FilePath, DocumentId) values(1,N'2AE2FB87-6649-40B1-A945-03946EB298B4',1,getdate(),N'2ae2fb87-6649-40b1-a945-03946eb298b4.pptx',19)
INSERT INTO tDocumentVersion(Version, Guid, HierarchyId, CreatedAt, FilePath, DocumentId) values(1,N'1E91FA80-0FDA-446E-A274-0511DD94C5A3',1,getdate(),N'1e91fa80-0fda-446e-a274-0511dd94c5a3.txt',20)
INSERT INTO tDocumentVersion(Version, Guid, HierarchyId, CreatedAt, FilePath, DocumentId) values(1,N'F6D4FF52-904E-4B5E-8E85-374DE96825BF',1,getdate(),N'f6d4ff52-904e-4b5e-8e85-374de96825bf.css',21)
INSERT INTO tDocumentVersion(Version, Guid, HierarchyId, CreatedAt, FilePath, DocumentId) values(1,N'5E5003BF-08A1-4CFF-8D49-515A3B8B1072',1,getdate(),N'5e5003bf-08a1-4cff-8d49-515a3b8b1072.jpg',22)
INSERT INTO tDocumentVersion(Version, Guid, HierarchyId, CreatedAt, FilePath, DocumentId) values(1,N'3FAFDA89-BC5D-46AE-9940-BEB54369F1DB',1,getdate(),N'3fafda89-bc5d-46ae-9940-beb54369f1db.jpg',23)
INSERT INTO tDocumentVersion(Version, Guid, HierarchyId, CreatedAt, FilePath, DocumentId) values(1,N'AA0D2E4F-9CA8-470F-BFAE-4F041986D629',1,getdate(),N'aa0d2e4f-9ca8-470f-bfae-4f041986d629.jpg',24)
INSERT INTO tDocumentVersion(Version, Guid, HierarchyId, CreatedAt, FilePath, DocumentId) values(1,N'3A52F841-1E46-4DC3-B8CF-0A9FE38009CD',2,getdate(),N'3a52f841-1e46-4dc3-b8cf-0a9fe38009cd.txt',11)
INSERT INTO tDocumentVersion(Version, Guid, HierarchyId, CreatedAt, FilePath, DocumentId) values(1,N'C52D6409-4D20-4F57-9E99-4962BA9FEFB4',2,getdate(),N'c52d6409-4d20-4f57-9e99-4962ba9fefb4.pdf',12)
INSERT INTO tDocumentVersion(Version, Guid, HierarchyId, CreatedAt, FilePath, DocumentId) values(1,N'758F27B5-2170-4285-9D50-F343404896F6',3,getdate(),N'758f27b5-2170-4285-9d50-f343404896f6.txt',11)
INSERT INTO tDocumentVersion(Version, Guid, HierarchyId, CreatedAt, FilePath, DocumentId) values(1,N'26989574-1B84-4FFB-ACD1-1480ACCE3BDA',4,getdate(),N'26989574-1b84-4ffb-acd1-1480acce3bda.txt',11)
INSERT INTO tDocumentVersion(Version, Guid, HierarchyId, CreatedAt, FilePath, DocumentId) values(1,N'C3D6A50B-D62A-435D-86CF-B8970A8558CF',2,getdate(),N'c3d6a50b-d62a-435d-86cf-b8970a8558cf.odg',18)
INSERT INTO tDocumentVersion(Version, Guid, HierarchyId, CreatedAt, FilePath, DocumentId) values(1,N'5AAF6C0E-4D6A-4CC0-B61A-22687F135C07',3,getdate(),N'5aaf6c0e-4d6a-4cc0-b61a-22687f135c07.odg',18)

GO

DBCC CHECKIDENT (tComment, RESEED, 10)

INSERT INTO tComment(CreatedAt, Text, DocumentVersionId, UserId) values(getdate(),N'Prvi komentar',12,17)
INSERT INTO tComment(CreatedAt, Text, DocumentVersionId, UserId) values(getdate(),N'Komentar na verziju 3 ',27,13)
INSERT INTO tComment(CreatedAt, Text, DocumentVersionId, UserId) values(getdate(),N'Komentar administratora',27,11)
INSERT INTO tComment(CreatedAt, Text, DocumentVersionId, UserId) values(getdate(),N'Komentar 123 ',18,11)
INSERT INTO tComment(CreatedAt, Text, DocumentVersionId, UserId) values(getdate(),N'Who is the flash?',29,11)
INSERT INTO tComment(CreatedAt, Text, DocumentVersionId, UserId) values(getdate(),N'Its Barry Alan',29,12)
INSERT INTO tComment(CreatedAt, Text, DocumentVersionId, UserId) values(getdate(),N'Are you sure?',29,17)
INSERT INTO tComment(CreatedAt, Text, DocumentVersionId, UserId) values(getdate(),N'Test komentar 32',18,17)
INSERT INTO tComment(CreatedAt, Text, DocumentVersionId, UserId) values(getdate(),N'AdBlocker',27,15)
INSERT INTO tComment(CreatedAt, Text, DocumentVersionId, UserId) values(getdate(),N'Jos jedna komentar',27,22)
INSERT INTO tComment(CreatedAt, Text, DocumentVersionId, UserId) values(getdate(),N'Komentar verzije',27,13)