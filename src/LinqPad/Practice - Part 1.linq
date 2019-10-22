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

from customer in Customers
where customer.Orders.Count() > 5
select customer.CompanyName


//b)

from region in Regions
select region.RegionDescription


//C) Get a list of all the territory names

from territory in Territories
select territory.TerritoryDescription


//D) List all the regions and the number of territories in each region

from place in Regions
select new
{
	Region = place.RegionDescription,
	Territories = place.Territories.Count()
}


//E) List all the region and territory names in a "flat" list

from place in Territories
select new
{
	Region = place.Region.RegionDescription,
	Territory = place.TerritoryDescription
}


//F) List all the region and territory names as an "object graph"
//   - use a nested query

from place in Regions
select new
{
	Region = place.RegionDescription,
	Territory = from territory in place.Territories
				select territory.TerritoryDescription
}


//G) List all the product names that contain the word "chef" in the name.

from item in Products
where item.ProductName.ToLower().Contains("chef")
select item.ProductName


//H) List all the discontinued products, specifying the product name and unit price.


from item in Products
where item.Discontinued //== true -> not necessary
select new
{
	Name = item.ProductName,
	Price = item.UnitPrice
}


//I) List the company names of all Suppliers in North America (Canada, USA, Mexico)
from vendor in Suppliers
where vendor.Address.Country == "Canada"
	|| vendor.Address.Country == "USA"
	|| vendor.Address.Country == "Mexico"
select vendor.CompanyName































