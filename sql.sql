SELECT Products.name, Categorys.name 
  FROM Products 
  LEFT JOIN Category 
  ON Products.CategoryId=Category.Id
