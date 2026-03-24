namespace Supermarket.Tests;

public class SupermarketTests
{
    [Fact]
    public void GivenAProduct_WhenAddedToCart_ThenCartContainsProduct()
    {
        // Arrange
        var cart = new Cart();
        var product = new Product("Apple", 0.5m);

        // Act
        cart.Products.Add(product);

        // Assert
        Assert.Contains(product, cart.Products); 
    }

    [Fact]
    public void GivenOneProduct_TotalPriceShouldBeProductPrice()
    {
        // Arrange
        var cart = new Cart();
        const decimal PRICE= 0.5m;
        var product = new Product("Apple", PRICE);
        cart.Products.Add(product);

        // Act and Assert
        Assert.Equal(PRICE, cart.GetTotalPrice());
    } 

    [Fact]
    public void GivenTwoProducts_TotalPriceShouldBeSumOfProductPrices()
    {
        // Arrange
        var cart = new Cart();
        var product1 = new Product("Apple", 0.5m);
        var product2 = new Product("Banana", 0.3m);
        decimal totalPrice= product1.Price + product2.Price;
        cart.Products.Add(product1);
        cart.Products.Add(product2);

        // Act and Assert
        Assert.Equal(totalPrice, cart.GetTotalPrice());
    }   

    [Fact]
    public void GivenThreeProducts_WhenBulkPriceIsThreeForOneEuro_ThenTotalShouldBeOneEuro()
    {
        // Arrange
        var cart = new Cart();
        var yogurt = new Product("Yogurt", 0.40m);
        cart.Products.Add(yogurt);
        cart.Products.Add(yogurt);
        cart.Products.Add(yogurt);

        // Act
        var totalPrice = cart.GetTotalPrice();

        // Assert
        // This test defines the first pricing-policy requirement (BulkPrice 3x1.00).
        Assert.Equal(1.00m, totalPrice);
    }
}
