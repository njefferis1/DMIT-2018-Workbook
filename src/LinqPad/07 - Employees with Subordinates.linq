<Query Kind="Expression">
  <Connection>
    <ID>8d96283b-7616-47ed-a9f0-f215a0730edd</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WestWind</Database>
  </Connection>
</Query>

// List all the employees who are managers.
from person in Employees
//   thing      thing[] 
where person.ReportsToChildren.Count > 0
//     thing    thing[]
select new
{
  Name = person.FirstName + " " + person.LastName,
  Subordinates = from sub in person.ReportsToChildren
  				 select sub.FirstName + " " + sub.LastName
}