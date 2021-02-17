

SELECT Products.Name, Categories.Name
FROM Products 
LEFT JOIN ProductCategories 
	ON Products.Id=ProductCategories.IdProduct
LEFT JOIN Categories 
	ON Categories.Id=ProductCategories.IdCategory