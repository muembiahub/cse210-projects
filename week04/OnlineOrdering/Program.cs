using System;
using System.Collections.Generic;
class OnligneOrdering
{
    static void Main(string[] args)
    {
// Create instances of Address for different customers
        Address address1 = new Address("Luano", "lubumbashi", "Haut-katanga", "DRCongo");
        Address address2 = new Address("1 Microsoft Way", "Redmond", "WA 98052", "USA");
        Address address3 = new Address("789 Pine Road","Montreal", "QC H2X 3Y7","Canada");
        Customer customer1 = new Customer("Cristoph Nkole", address1);
        Customer customer2 = new Customer("Sarah Muembia", address2);
        Customer customer3 = new Customer("Jonathan Muembia", address3);
        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);
        Order order3 = new Order(customer3);
// Create instances of Address for different customers
        Product product1 = new Product("Desktop", "5366", 999.99, 32);
        Product product2 = new Product("Mouse", "B456", 25.50 , 22);
        Product product3 = new Product("Keyboard", "K789", 45.00, 9);
        Product product4 = new Product("Monitor", "M123", 150.00, 10);
// Create instances of Product for different products on Order 1
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);
        order1.AddProduct(product4);
// Create instances of Product for different products on Order 2
        order2.AddProduct(product1);
        order2.AddProduct(product2);
        order2.AddProduct(product3);
        order3.AddProduct(product4);
// Create instances of Product for different products on Order 3
        order3.AddProduct(product1);
        order3.AddProduct(product2);
        order3.AddProduct(product3);
        order3.AddProduct(product4);
// Display order details for  order 1
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShoppingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}");
// Display order details for  order 2
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShoppingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}");
// Display order details for  order 3
        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine(order3.GetShoppingLabel());
        Console.WriteLine($"Total Cost: ${order3.GetTotalCost()}");
    }
}
class Product
{
    public string Name { get; set; }
    public string ProductId { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }

    public Product(string name, string productId, double price, int quantity)
    {
        Name = name;
        ProductId = productId;
        Price = price;
        Quantity = quantity;
    }

    public double GetTotalPrice()
    {
        return Price * Quantity;
    }
}

class Customer
{
    public string Name { get; set; }
    public Address Address { get; set; }

    public Customer(string name, Address address)
    {
        Name = name;
        Address = address;
    }
}

class Address
{
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }

    public Address(string street, string city, string state, string country)
    {
        Street = street;
        City = city;
        State = state;
        Country = country;
    }

    public bool IsInUSA()
    {
        return Country.ToLower() == "usa";
    }

    public override string ToString()
    {
        return $"{Street}, {City}, {State}, {Country}";
    }
    public string GetFormattedAddress()
    {
        return $"{Street},{City},{State}, {Country}";
    }
}

class Order
{
    public List<Product> Products { get; set; }
    public Customer Customer { get; set; }

    public Order(Customer customer)
    {
        Customer = customer;
        Products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public double GetTotalCost()
    {
        double total = 0;
        foreach (var product in Products)
        {
            total += product.GetTotalPrice();
        }
        total += Customer.Address.IsInUSA() ? 5 : 35;
        return total;
    }

    public string GetPackingLabel()
    {
        string label = $"Packing Label: \n";
        foreach (var product in Products)
        {
            label += $"Product: {product.Name}\n";
            label += $"ID: {product.ProductId}\n";
        }
        return label;
    }

    public string GetShoppingLabel()
    {
        return $"Shopping Orded:\nCustomer Name: {Customer.Name}\nCustomer Address : {Customer.Address}";
    }
}


