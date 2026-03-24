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
}
