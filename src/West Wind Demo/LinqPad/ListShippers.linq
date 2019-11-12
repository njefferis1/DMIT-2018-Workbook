<Query Kind="Program">
  <Connection>
    <ID>c7db4e33-b944-4314-a549-59bce3958035</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WestWind</Database>
  </Connection>
</Query>

void Main()
{
	var output = ListShippers();
	output.Dump();
}

// Define other methods and classes here
        public List<ShipperSelection> ListShippers()
        {
            //throw new NotImplementedException();
            // TODO: Get all the shippers from the Db
			var result = from shipper in Shippers
						 orderby shipper.CompanyName
			             select new ShipperSelection
						 {
						     ShipperId = shipper.ShipperID,
							 Shipper = shipper.CompanyName
						 };
			return result.ToList();
        }

    public class ShipperSelection
    {
        public int ShipperId { get; set; }
        public string Shipper { get; set; }
    }