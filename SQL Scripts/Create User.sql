--https://docs.microsoft.com/en-us/azure/sql-database/sql-database-manage-logins

--on Master
CREATE LOGIN Doc_dbuser WITH PASSWORD = 'P@ssw0rd'
CREATE USER Doc_dbuser FOR LOGIN Doc_dbuser;
--optionally if the user needs to be able to create databases:
--ALTER ROLE dbmanager ADD MEMBER [Doc_dbuser];
--optionally if the user needs to add logins
--ALTER ROLE loginmanager  ADD MEMBER [Doc_dbuser]
GO
-- Now add user to on specific database - NOTE that Azuire does not suport the Use [db] statement
--->>DOES NOT WORK ON Azure -- USE [DockerSample];
--CREATE USER Doc_dbuser FOR LOGIN Doc_dbuser;
--EXEC sp_addrolemember N'db_owner', N'Doc_dbuser'
--EXEC sp_addrolemember N'db_datawriter', N'Doc_dbuser'
--EXEC sp_addrolemember N'db_datareader', N'Doc_dbuser'
--GO