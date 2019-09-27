<Query Kind="Expression">
  <Connection>
    <ID>4a556e81-9d4c-4a3e-8452-a454259f82f1</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WestWind</Database>
  </Connection>
</Query>

// Display the Employees, grouped by the region in which the employee lives. Show the employee's first name, last name, and job title as separate properties within each group.
// TODO: write the data types
from person in Employees
// Employee    Table<Employees>
group person by person.Address.Region into EmployeeGroups
// Employee    string				IGrouping<String,Employees>
select new
{
    Region = EmployeeGroups.Key,
	Employee = from staff in EmployeeGroups
	           select new
               {
			       FirstName = staff.FirstName,
				   LastName = staff.LastName,
				   JobTitle = staff.JobTitle
               }
}