<Query Kind="Expression">
  <Connection>
    <ID>4a556e81-9d4c-4a3e-8452-a454259f82f1</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WestWind</Database>
  </Connection>
</Query>

// Display all the company names and contact names for our customers, grouped by country
from 	row 			in 					Customers
//Customer	Table<Customers>
group  row   by   row.Address.Country 
//   Customer	   		 string
//    \what/      \       how       /
//				   \      key      /

into CustomersByCountry
//IGrouping<String,Customers>
select new
{
   Country = CustomersByCountry.Key, // the key is "how" we have sorted the data
   Customers = from data in CustomersByCountry
               select new
               {
			       Company = data.CompanyName,
				   Contact = data.ContactName
               }
}