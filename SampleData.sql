USE [CIB.PhoneBook]
GO

INSERT INTO [dbo].[Contacts]([FirstName],[LastName],[Mobile],[WorkTelephone],[DateCreated],[DateModified])
     VALUES
           ('Bob'	, 'Skinstad'	, '0741234567'	, '0115551234', getdate(), GETDATE()),
		   ('Sarie'	, 'Marais'	, '0821234567'	, '0115551234', getdate(), GETDATE()),
		   ('Jacob'	, 'Mmezie'	, '0831234567'	, '0115551234', getdate(), GETDATE())
GO


