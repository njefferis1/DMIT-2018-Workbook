<Query Kind="Expression">
  <Connection>
    <ID>824df4a6-4961-4634-b3d8-7e172c07a138</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WestWind</Database>
  </Connection>
</Query>

//Orders.Max(sale => sale.OrderDate).Value.Month

from sale in Orders
where sale.OrderDate.Value.Month == 5
	&& sale.OrderDate.Value.Year == 2018
select new //sale
{
	Customer = sale.Customer.CompanyName,
	ResponseTime = sale.RequiredDate.Value - sale.OrderDate.Value,
	PaymentDueOn = sale.PaymentDueDate,
	FirstPayment = sale.Payments.First().PaymentDate,
	PaymentResponseTime = sale.Payments.First().PaymentDate - sale.PaymentDueDate.Value
}




























