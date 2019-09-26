<Query Kind="Expression">
  <Connection>
    <ID>8d96283b-7616-47ed-a9f0-f215a0730edd</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WestWind</Database>
  </Connection>
</Query>

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

from company in Suppliers
select new // Supplier
{
	CompanyName = company.CompanyName,
	ContactName = company.ContactName,
	PhoneNumber = company.Phone,
	Products = from item in company.Products
		select new // ProductSummary
		{
			ProductName = item.ProductName,
			CategoryName = item.Category.CategoryName,
			UnitPrice = item.UnitPrice,
			QuantiyperUnit = item.QuantityPerUnit
			
		}
}