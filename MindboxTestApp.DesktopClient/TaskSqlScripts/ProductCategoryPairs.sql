--Mindbox database has tables Products (Id, ProductName), Categories (Id, CategoryName)
--and ProductCategories table that implements many-to-many relation (Id, ProductId, CategoryId)
--For this case the following script will display all the product - category pairs as well as products with no categories assigned



SELECT p.ProductName, c.CategoryName 
FROM Products p
LEFT JOIN ProductCategories pc ON pc.ProductId = p.Id
LEFT JOIN Categories c ON pc.CategoryId = c.Id