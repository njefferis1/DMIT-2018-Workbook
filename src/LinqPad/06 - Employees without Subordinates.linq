<Query Kind="Expression">
  <Connection>
    <ID>8d96283b-7616-47ed-a9f0-f215a0730edd</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WestWind</Database>
  </Connection>
</Query>

// List all the employees who do not manage anyone.
from person in Employees
//  Employee  Table<Employee> 
where person.ReportsToChildren.Count == 0
//   Employee  IEnumerable<Employee>		=> enumerate == count up
select new
{
  Name = person.FirstName + " " + person.LastName,
  Manager = person.ReportsToEmployee.FirstName + " " + person.ReportsToEmployee.LastName
}