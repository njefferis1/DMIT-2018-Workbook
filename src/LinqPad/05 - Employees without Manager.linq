<Query Kind="Expression">
  <Connection>
    <ID>8d96283b-7616-47ed-a9f0-f215a0730edd</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WestWind</Database>
  </Connection>
</Query>

// List all the employees who do not have a manager
// (i.e.: they do not report to anyone).
from person    in	 Employees
//  Employee   	  Table<Employees> 
where person.ReportsToEmployee == null
//   Employee     Employee
select new // Creating an anonymous data type
// The curly braces section below is called the initializer List
{
  Name = person.FirstName + " " + person.LastName
}