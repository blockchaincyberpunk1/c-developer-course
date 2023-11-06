using System;
using System.Collections.Generic;

// Base class representing a Person
class Person
{
    public int PersonId { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime DateOfBirth { get; set; }

    public Person(int personId, string name, string address, string phoneNumber, DateTime dateOfBirth)
    {
        PersonId = personId;
        Name = name;
        Address = address;
        PhoneNumber = phoneNumber;
        DateOfBirth = dateOfBirth;
    }
}

// Class representing a Supplier
class Supplier : Person
{
    public string CompanyName { get; set; }
    public List<Product> ProductsSupplied { get; set; }

    public Supplier(int supplierId, string name, string address, string phoneNumber, DateTime dateOfBirth, string companyName)
        : base(supplierId, name, address, phoneNumber, dateOfBirth)
    {
        CompanyName = companyName;
        ProductsSupplied = new List<Product>();
    }

    public void SupplyProduct(Product product)
    {
        ProductsSupplied.Add(product);
    }
}

// Class representing a Category
class Category
{
    public int CategoryId { get; set; }
    public string Name { get; set; }
    public List<Product> ProductsInCategory { get; set; }

    public Category(int categoryId, string name)
    {
        CategoryId = categoryId;
        Name = name;
        ProductsInCategory = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        ProductsInCategory.Add(product);
    }
}

// Class representing a Product
class Product
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public Category Category { get; set; }
    public List<OrderItem> OrderItems { get; set; }

    public Product(int productId, string name, decimal price, Category category)
    {
        ProductId = productId;
        Name = name;
        Price = price;
        Category = category;
        OrderItems = new List<OrderItem>();
    }

    public void AddToOrder(Order order, int quantity)
    {
        OrderItem orderItem = new OrderItem(this, quantity);
        order.OrderItems.Add(orderItem);
    }
}

// Class representing an Order
class Order
{
    public int OrderId { get; set; }
    public Customer Customer { get; set; }
    public List<OrderItem> OrderItems { get; set; }

    public Order(int orderId, Customer customer)
    {
        OrderId = orderId;
        Customer = customer;
        OrderItems = new List<OrderItem>();
    }

    public void AddOrderItem(Product product, int quantity)
    {
        OrderItem orderItem = new OrderItem(product, quantity);
        OrderItems.Add(orderItem);
    }
}

// Class representing an Order Item
class OrderItem
{
    public Product Product { get; set; }
    public int Quantity { get; set; }

    public OrderItem(Product product, int quantity)
    {
        Product = product;
        Quantity = quantity;
    }
}

// Class representing a Customer
class Customer : Person
{
    public List<Order> Orders { get; set; }

    public Customer(int customerId, string name, string address, string phoneNumber, DateTime dateOfBirth)
        : base(customerId, name, address, phoneNumber, dateOfBirth)
    {
        Orders = new List<Order>();
    }

    public void PlaceOrder(Order order)
    {
        Orders.Add(order);
    }
}

// Class representing a Warehouse
class Warehouse
{
    public int WarehouseId { get; set; }
    public string Name { get; set; }
    public List<Product> ProductsInWarehouse { get; set; }

    public Warehouse(int warehouseId, string name)
    {
        WarehouseId = warehouseId;
        Name = name;
        ProductsInWarehouse = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        ProductsInWarehouse.Add(product);
    }
}

class Program
{
    static void Main()
    {
        // Create instances of Supplier, Category, Product, Customer, Order, and Warehouse
        Supplier supplier1 = new Supplier(1, "Supplier1", "Supplier Address", "123-456-7890", DateTime.Now, "SupplierCo");
        Category category1 = new Category(1, "Electronics");
        Product product1 = new Product(1, "Laptop", 999.99m, category1);
        Customer customer1 = new Customer(1, "Customer1", "Customer Address", "555-123-4567", DateTime.Now);
        Order order1 = new Order(1, customer1);
        Warehouse warehouse1 = new Warehouse(1, "Warehouse1");

        // Perform the interactions
        // Add products to the supplier
        supplier1.SupplyProduct(product1);
        // You can add more products if needed

        // Check the products supplied by the supplier
        foreach (var product in supplier1.ProductsSupplied)
        {
            Console.WriteLine($"Supplier {supplier1.Name} supplies {product.Name}");
        }


        // Add products to the category
        category1.AddProduct(product1);
        // You can add more products to the category

        // Check the products in the category
        foreach (var product in category1.ProductsInCategory)
        {
            Console.WriteLine($"Category {category1.Name} contains {product.Name}");
        }

        // Add products to the warehouse
        warehouse1.AddProduct(product1);
        // You can add more products to the warehouse

        // Check the products in the warehouse
        foreach (var product in warehouse1.ProductsInWarehouse)
        {
            Console.WriteLine($"Warehouse {warehouse1.Name} stores {product.Name}");
        }

        // Create an order item for the product
        OrderItem orderItem1 = new OrderItem(product1, 2); // Order 2 laptops

        // Create an order and add the order item
        Order order1 = new Order(1, customer1);
        order1.AddOrderItem(product1, 2); // Add the order item to the order

        // Place the order for the customer
        customer1.PlaceOrder(order1);

        // Check the orders placed by the customer
        foreach (var order in customer1.Orders)
        {
            Console.WriteLine($"Customer {customer1.Name} placed order {order.OrderId}");
        }

    }

}
