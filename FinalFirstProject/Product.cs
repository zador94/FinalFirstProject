namespace FinalFirstProject;

public class Product
{
    public string ProductName { get; set; }
    public float Price { get; set; }
    public int Quantity { get; set; }

    public Product(string name, float price, int quantity)
    {
        ProductName = name;
        Price = price;
        Quantity = quantity;
    }
    
    public Product()
    {
    }
}