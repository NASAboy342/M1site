USE [M1]
GO
CREATE PROCEDURE [dbo].[GetItems]
AS
BEGIN
SET NOCOUNT ON
SELECT [Id],[ItemsName],[Quantity],[Unit]
FROM [M1].[dbo].[Items]
END
GO