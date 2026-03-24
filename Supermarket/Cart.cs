namespace Supermarket;

public class Cart
{
    public List<Product> Products { get; private set; } = new List<Product>();

    public decimal GetTotalPrice()
    {
        return Products.Sum(p => p.Price);
    }
}