namespace BlazorApp1.Data.Models;

public class Order
{
    public int Id { get; set; }
    public string Date { get; set; }
    public int Amount { get; set; }
    public int Cost { get; set; }
    public int[] Product { get; set; }
    public int[] Service { get; set; }
    public int[] Address { get; set; }
}