namespace OrdersWeb.Api;

public class OrderRequest
{
    public int Id { get; set; }
    public string OrderNumber { get; set; }
    public string Customer { get; set; }
    public string Address { get; set; }
    public List<Product> Products { get; set; }

}