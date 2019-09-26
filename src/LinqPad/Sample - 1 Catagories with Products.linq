<Query Kind="Expression">
  <Connection>
    <ID>8d96283b-7616-47ed-a9f0-f215a0730edd</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WestWind</Database>
  </Connection>
</Query>

//copied from westwind demo.BLL.ProductManagerController

from cat in Categories
select new //ProductCategory
{
	 CategoryName = cat.CategoryName,
	 Description = cat.Description,
	 Picture = cat.Picture.ToImage(), // note: remove '.ToImage()' for visual studio
	 MimeType = cat.PictureMimeType,
	 Products = from item in cat.Products
            select new //ProductSummary
            {
                Name = item.ProductName,
                Price = item.UnitPrice,
                Quantity = item.QuantityPerUnit
            }
}