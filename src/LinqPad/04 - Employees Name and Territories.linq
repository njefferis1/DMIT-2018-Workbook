<Query Kind="Expression">
  <Connection>
    <ID>5e678b02-e058-4518-a220-8a061d9b5d56</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WestWind</Database>
  </Connection>
</Query>

// List the first and last name of all the employees who look after 7 or more territories
// as well as the names of all the territories they are responsible for
from person in Employees
where person.EmployeeTerritories.Count >= 7
select new
{
   Title = person.JobTitle,
   First = person.FirstName,
   Last = person.LastName,
   Territories = from place in person.EmployeeTerritories
                 select place.Territory.TerritoryDescription
}