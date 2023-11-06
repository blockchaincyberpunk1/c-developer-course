using System;
using System.Collections.Generic;

// Base class representing a Product
class Product
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public Seller Seller { get; set; }

    public Product(int productId, string name, decimal price, Seller seller)
    {
        ProductId = productId;
        Name = name;
        Price = price;
        Seller = seller;
    }
}

// Base class representing a User
class User
{
    public int UserId { get; set; }
    public string Username { get; set; }

    public User(int userId, string username)
    {
        UserId = userId;
        Username = username;
    }
}

// Cart class
class Cart
{
    public int CartId { get; set; }
    public User User { get; set; }
    public List<Product> Products { get; set; }

    public Cart(int cartId, User user)
    {
        CartId = cartId;
        User = user;
        Products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }
}

// Order class
class Order
{
    public int OrderId { get; set; }
    public User User { get; set; }
    public List<Product> OrderedProducts { get; set; }
    public decimal TotalPrice { get; set; }

    public Order(int orderId, User user)
    {
        OrderId = orderId;
        User = user;
        OrderedProducts = new List<Product>();
        TotalPrice = 0;
    }

    public void AddProduct(Product product)
    {
        OrderedProducts.Add(product);
        TotalPrice += product.Price;
    }
}

// Payment class
class Payment
{
    public int PaymentId { get; set; }
    public User User { get; set; }
    public decimal Amount { get; set; }
    public DateTime PaymentDate { get; set; }

    public Payment(int paymentId, User user, decimal amount)
    {
        PaymentId = paymentId;
        User = user;
        Amount = amount;
        PaymentDate = DateTime.Now;
    }
}

// Review class
class Review
{
    public int ReviewId { get; set; }
    public User User { get; set; }
    public Product Product { get; set; }
    public string Comment { get; set; }

    public Review(int reviewId, User user, Product product, string comment)
    {
        ReviewId = reviewId;
        User = user;
        Product = product;
        Comment = comment;
    }
}

// Seller class
class Seller
{
    public int SellerId { get; set; }
    public string SellerName { get; set; }

    public Seller(int sellerId, string sellerName)
    {
        SellerId = sellerId;
        SellerName = sellerName;
    }
}

class Program
{
    static void Main()
    {
        // Create instances of Product, User, Cart, Order, Payment, Review, and Seller
        Seller seller1 = new Seller(1, "AwesomeSeller");
        Product product1 = new Product(101, "Product1", 10.99m, seller1);
        User user1 = new User(1, "User1");
        Cart cart1 = new Cart(1, user1);
        Order order1 = new Order(1, user1);
        Payment payment1 = new Payment(1, user1, 10.99m);
        Review review1 = new Review(1, user1, product1, "Great product!");

        // Add product to the cart
        cart1.AddProduct(product1);

        // Place an order from the cart
        foreach (var product in cart1.Products)
        {
            order1.AddProduct(product);
        }

        // Display order details
        Console.WriteLine($"Order ID: {order1.OrderId}");
        Console.WriteLine($"User: {order1.User.Username}");
        Console.WriteLine("Ordered Products:");
        foreach (var product in order1.OrderedProducts)
        {
            Console.WriteLine($"  - {product.Name}");
        }
        Console.WriteLine($"Total Price: ${order1.TotalPrice}");

        // Make a payment
        Console.WriteLine($"Payment ID: {payment1.PaymentId}");
        Console.WriteLine($"User: {payment1.User.Username}");
        Console.WriteLine($"Amount: ${payment1.Amount}");
        Console.WriteLine($"Payment Date: {payment1.PaymentDate}");

        // Write a review
        Console.WriteLine($"Review ID: {review1.ReviewId}");
        Console.WriteLine($"User: {review1.User.Username}");
        Console.WriteLine($"Product: {review1.Product.Name}");
        Console.WriteLine($"Comment: {review1.Comment}");
    }
}
