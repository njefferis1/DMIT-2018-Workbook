<Query Kind="Expression">
  <Connection>
    <ID>5e678b02-e058-4518-a220-8a061d9b5d56</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WestWind</Database>
  </Connection>
</Query>

// - Filter on partial name
// List employees who have an "an" in their first name
from person in Employees
where person.FirstName.Contains("an")
select person