<Query Kind="Statements">
  <Connection>
    <ID>4a556e81-9d4c-4a3e-8452-a454259f82f1</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WestWind</Database>
  </Connection>
</Query>

// List all the orders showing the order ID, Company Name, Freight Charge,
// and Subtotal (no discounts) as well as the Subtotal of the discount.
var result = from sale in Orders
select new
{
    OrderId = sale.OrderID,
    Company = sale.Customer.CompanyName,
    FreightCharge = sale.Freight,
    Subtotal = sale.OrderDetails.Sum(lineItem => lineItem.Quantity * lineItem.UnitPrice),
    DiscountSubtotal = 
        sale.OrderDetails.Sum(lineItem =>
                              lineItem.Quantity * lineItem.UnitPrice * (decimal)lineItem.Discount)
};

var highestToLowest = result.OrderByDescending(sale => sale.Subtotal);
highestToLowest.Dump();