<Query Kind="Expression">
  <Connection>
    <ID>4a556e81-9d4c-4a3e-8452-a454259f82f1</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WestWind</Database>
  </Connection>
</Query>

// List all the customers grouped by country and region.
from row in Customers
group row by new 
{ 
	Nation = row.Address.Country, 
	row.Address.Region 
} 

into CustomerGroups

select new
{
   Key = CustomerGroups.Key,
   Country = CustomerGroups.Key.Nation,
   Region = CustomerGroups.Key.Region,
   Customers = from data in CustomerGroups
               select new
               {
                   Company = data.CompanyName,
                   City = data.Address.City
               }
}