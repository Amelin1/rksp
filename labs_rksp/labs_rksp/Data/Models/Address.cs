namespace labs_rksp.Data.Models;

public class Address
{
    public int Id { get; set; }
    public string  City { get; set; }
    public string Street { get; set; }
    public int HomeNumber { get; set; }
    public IEnumerable<Order>? Orders { get; set; }
}