
---Initial Script--
--IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
--BEGIN
--    CREATE TABLE [__EFMigrationsHistory] (
--        [MigrationId] nvarchar(150) NOT NULL,
--        [ProductVersion] nvarchar(32) NOT NULL,
--        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
--    );
--END;
--GO

--BEGIN TRANSACTION;
--GO

--CREATE TABLE [Users] (
--    [Id] int NOT NULL IDENTITY,
--    [UserName] nvarchar(max) NULL,
--    CONSTRAINT [PK_Users] PRIMARY KEY ([Id])
--);
--GO

--INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
--VALUES (N'20210710113434_InitialScript', N'5.0.7');
--GO

--COMMIT;
--GO

