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

//*****************************SKIP*********************************

from employee in Employees
select new
{
	Region = employee.Address.Region,
	Employees = employee.FirstName + " " + employee.LastName
}

// B) List all the Customers by Company Name. Include the Customer's company name, contact name, and other contact information in the result.

from customer in Customers
select new
{
	customer.CompanyName,
	customer.ContactName,
	customer.ContactTitle,
	customer.ContactEmail,
	customer.Phone,
	customer.Fax,
}


// C) List all the employees and sort the result in ascending order by last name, then first name. Show the employee's first and last name separately, along with the number of customer orders they have worked on.
from employee in Employees
orderby employee.LastName ascending
select new
{
	employee.LastName,
	employee.FirstName,
	employee.SalesRepOrders.Count
}

// D) List all the employees and sort the result in ascending order by last name, then first name. Show the employee's first and last name separately, along with the number of customer orders they have worked on.
from employee in Employees
orderby employee.LastName ascending
select new
{
	employee.LastName,
	employee.FirstName,
	employee.SalesRepOrders.Count
}

// E) Group all customers by city. Output the city name, aalong with the company name, contact name and title, and the phone number.
from customers in Customers
select new
{
	city = customers.Address.City,
	company = customers.CompanyName,
	contact = customers.ContactName,
	title = customers.ContactTitle,
	phone = customers.Phone
}
//****************************doesnt sort by city***********************************




































































