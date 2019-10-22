<Query Kind="Expression">
  <Connection>
    <ID>5df9fa6a-9911-4413-9135-80e2d4a86360</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WestWind</Database>
  </Connection>
</Query>

// Practice questions - do each one in a separate LinqPad query.

// A) Group employees by region and show the results in this format:
/* ----------------------------------------------
 * | REGION        | EMPLOYEES                  |
 * ----------------------------------------------
 * | Eastern       | ------------------------   |
 * |               | | Nancy Devalio        |   |
 * |               | | Fred Flintstone      |   |
 * |               | | Bill Murray          |   |
 * |               | ------------------------   |
 * |---------------|----------------------------|
 * | ...           |                            |
 * 
 */

// B) List all the Customers by Company Name. Include the Customer's company name, contact name, and other contact information in the result.

// C) List all the employees and sort the result in ascending order by last name, then first name. Show the employee's first and last name separately, along with the number of customer orders they have worked on.

// D) List all the employees and sort the result in ascending order by last name, then first name. Show the employee's first and last name separately, along with the number of customer orders they have worked on.

// E) Group all customers by city. Output the city name, aalong with the company name, contact name and title, and the phone number.

// F) List all the Suppliers, by Country



// A) Group employees by region

from place in Regions
select new
{
	Region = place.RegionDescription,
	//Getting employees and removing duplicates
	Employees = (from area in place.Territories
				from manager in area .EmployeeTerritories
				select manager.Employee.FirstName + " " + manager.Employee.LastName).Distinct(),
	Employees2 = from area in place.Territories
					from manager in area.EmployeeTerritories
					group manager by manager.Employee into areaManagers
					select areaManagers.Key.FirstName + " " + areaManagers.Key.LastName
}

// B) List all the Customers sorted by Company Name. Include the Customer's company name, contact name, and other contact information in the result.

from company in Customers
select new
{
	CompanyName = company.CompanyName,
	Contact = new
			{
				Name = company.ContactName,
				Title = company.ContactTitle,
				Email = company.ContactEmail,
				Phone = company.Phone,
				Fax = company.Fax
			}
}


// C) List all the employees and sort the result in ascending order by last name, then first name. Show the employee's first and last name separately, along with the number of customer orders they have worked on.
from person in Employees
orderby person.LastName, person.FirstName //ascending -> not needed
select new
{
	person.FirstName,
	person.LastName,
	OrderCount = person.SalesRepOrders.Count()
}

// D) List all the employees and sort the result in ascending order by last name, then first name. Show the employee's first and last name separately, along with the number of customer orders they have worked on.
from person in Employees
orderby person.LastName, person.FirstName //ascending -> not needed
select new
{
	person.FirstName,
	person.LastName,
	OrderCount = person.SalesRepOrders.Count()
}

// E) Group all customers by city. Output the city name, along with the company name, contact name and title, and the phone number.
from company in Customers
group company by company.Address.City into customerByCity
select new
{
	city = customerByCity.Key,
	Customers = from buyer in customerByCity
				select new
				{
					buyer.CompanyName,
					buyer.ContactName,
					buyer.ContactTitle,
					buyer.Phone
				}
}


// F) List all the Suppliers, by Country

from vendor in Suppliers
group vendor by vendor.Address.Country into nationalSuppliers
select new
{
	Country = nationalSuppliers.Key,
	Suppliers = from company in nationalSuppliers
				select company.CompanyName
}






















