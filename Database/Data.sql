/*
Post-Deployment Script Template              
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.    
 Use SQLCMD syntax to include a file in the post-deployment script.      
 Example:      :r .\myfile.sql                
 Use SQLCMD syntax to reference a variable in the post-deployment script.    
 Example:      :setvar TableName MyTable              
               SELECT * FROM [$(TableName)]          
--------------------------------------------------------------------------------------
*/
INSERT INTO [dbo].[Information] ([FullName], [Gender], [Birthday], [Email], [Phone], [Address])
VALUES  ('Daomtthuan', 1, CAST('1999-09-18' AS DATE), 'daomtthuan@gmail.com', '+84939908568', 'Cantho, Vietnam'),
        ('Dao Minh Trung Thuan', 1, CAST('1999-09-18' AS DATE), 'thuanb1704855@student.ctu.edu.vn', '+84939908568', 'Cantho, Vietnam'),
        ('Nguyen Truong Giang', 1, CAST('1999-10-02' AS DATE), 'giangb1704806@student.ctu.edu.vn', '+84376305370', 'Cantho, Vietnam')
GO

INSERT INTO [dbo].[Admin] ([Username], [Password], [InformationId])
VALUES  ('admin', '$2a$11$tCwUyuzUCN6msnwmKes9QuKHd5UDKfMgEa5FacStMBrbqTZrpPXSG', 1)
GO

INSERT INTO [dbo].[User] ([Username], [Password], [InformationId])
VALUES  ('thuan', '$2a$11$tCwUyuzUCN6msnwmKes9QuKHd5UDKfMgEa5FacStMBrbqTZrpPXSG', 2),
        ('giang', '$2a$11$tCwUyuzUCN6msnwmKes9QuKHd5UDKfMgEa5FacStMBrbqTZrpPXSG', 3)
GO
