USE master
GO
CREATE DATABASE [M1]
GO
USE [M1]
GO
CREATE TABLE [Items](
    [Id] INT PRIMARY KEY IDENTITY(1,1),
    [ItemsName] NVARCHAR(50),
    [Quantity] DECIMAL(16,3),
    [Unit] VARCHAR(5),
)
GO
INSERT INTO [Items](
    [ItemsName],[Quantity],[Unit]
)
VALUES
('Banana',12,'PCS')
,('Apple',12,'PCS')
,('Potato',12,'PCS')
,('Salad',2,'KG')
,('Lopster',5,'KG')
GO