<Query Kind="Expression">
  <Connection>
    <ID>8d96283b-7616-47ed-a9f0-f215a0730edd</ID>
    <Server>.</Server>
    <Database>WestWind</Database>
  </Connection>
</Query>

from vendor in Suppliers
select new
{
	CompanyName = vendor.CompanyName,
	Contact = vendor.ContactName,
	Phone = vendor.Phone,
	Products = from item in vendor.Products
		select new
		{
			Name = item.ProductName,
			Category = item.Category.CategoryName,
			Price = item.UnitPrice,
			PerUnitQuantity = item.QuantityPerUnit
		}
}
/*
Supplier:
	Company Name
	Contact Name
	Phone Number
	Product Summary:
		Product Name
		Category Name
		Unit Price
		Quantity/Unit
*/
