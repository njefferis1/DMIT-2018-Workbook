<Query Kind="Expression">
  <Connection>
    <ID>4a556e81-9d4c-4a3e-8452-a454259f82f1</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WestWind</Database>
  </Connection>
</Query>

// Get the products displaying the product name, the category, and the unit price. Sort the results alphabetically by category and then in descending order by unit price.
from item in Products
orderby item.Category.CategoryName ascending, item.UnitPrice descending
select new
{
    Product = item.ProductName,
	Category = item.Category.CategoryName,
	Price = item.UnitPrice
}