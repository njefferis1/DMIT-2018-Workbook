# Order Processing

> Orders are shipped directly from our suppliers to our customers. As such, suppliers log onto our system to see what orders there are for the products that they provide.

## User Interface

Suppliers will be interacting with a page that shows the following information.

![Mockup](./Shipping-Orders.svg)

The information shown here will be displayed in a **ListView**, using the *SelectedItemTemplate* as the part that shows the details for a given order.

## POCOs

### Commands

### Queries

```csharp
public class Orderitem
{
    public int ProductID {get;set;}
    public string ProductName {get;set;}
    public short Qty {get;set;}
    public string QtyPerUnit {get;set;}
    public short Outstanding {get;set;}// calculated as OD.Quantity - Sum(ShippedQty)
}

public class ShippingInfo
{
    public datetime RequiredDate {get;set;}
    public datetime OrderDate {get;set;}
    public int OrderID {get;set;}
    public string FullAddress {get;set;}
    public string Comments {get;set;}
}

public class ShipQty
{
    public short ShipQuantity {get;set;}
    public int ProductID {get;set;}
}

public class ManifestInfo
{
    public int OrderID {get;set;}
    public int SupplierID {get;set;}
    public datetime ShippedDate {get;set;}
}
```

## BLL Processing
