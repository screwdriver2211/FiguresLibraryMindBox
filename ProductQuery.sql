SELECT Products.Name, Categories.Name
FROM Products LEFT JOIN Categories ON Products.CategoryId = Categories.Id
ORDER BY Products.Name