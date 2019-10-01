<Query Kind="Expression">
  <Connection>
    <ID>5df9fa6a-9911-4413-9135-80e2d4a86360</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WestWind</Database>
  </Connection>
</Query>

// Practice questions - do each one in a separate LinqPad query.
/*

A) List all the customer company names for those with more than 5 orders

B) Get a list of all the region names

C) Get a list of all the territory names

D) List all the regions and the number of territories in each region
E) List all the region and territory names in a "flat" list
F) List all the region and territory names as an "object graph"
   - use a nested query
G) List all the product names that contain the word "chef" in the name.
H) List all the discontinued products, specifying the product name and unit price.
I) List the company names of all Suppliers in North America (Canada, USA, Mexico)

*/

//a)
/*
from customer in Customers
where customer.Orders.Count > 5
select customer.CompanyName
*/

//b)
/*
from region in Regions
select region.RegionDescription
*/

//C) Get a list of all the territory names
/*
from territory in Territories
select territory.TerritoryDescription
*/

//D) List all the regions and the number of territories in each region
/*
from region in Regions
select new
{
	Region = region.RegionDescription,
	Territories = region.Territories.Count
}
*/

//E) List all the region and territory names in a "flat" list
/*
from data in Territories
select new
{
	data.TerritoryDescription,
	data.Region.RegionDescription
}
*/

//F) List all the region and territory names as an "object graph"
//   - use a nested query
/*
from data in Regions
select new
{
	Region = data.RegionDescription,
	Territory = from territory in Territories
				select territory.TerritoryDescription
}
*/

//G) List all the product names that contain the word "chef" in the name.
/*
from product in Products
where product.ProductName.Contains("chef")
select product.ProductName
*/

//H) List all the discontinued products, specifying the product name and unit price.

/*
from product in Products
where product.Discontinued == true
select new
{
	Name = product.ProductName,
	Price = product.UnitPrice
}
*/

//I) List the company names of all Suppliers in North America (Canada, USA, Mexico)
from supplier in Suppliers
where supplier.Address.Region != "Carrabean"
select supplier.CompanyName






































