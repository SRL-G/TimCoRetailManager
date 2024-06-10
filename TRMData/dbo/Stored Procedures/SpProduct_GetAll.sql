CREATE PROCEDURE [dbo].[SpProduct_GetAll]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT Id, ProductName, [Description], RetailPrice, QuantityInStock
	FROM dbo.Product
	ORDER BY ProductName;
END
