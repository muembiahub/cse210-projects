using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
public class Program
{
    public static void Main()
        {
        // Create wellcome message 
        Console.WriteLine("Welcome to you (All)");
        
        // Create addresses
        Address address1 = new Address("348 Kinshasa Bld", "Togo", "IL Arizona", "USA");
        Address address2 = new Address("19086 Lubumbashi Rdc", "Congo Kinshasa", "France", "Canada");

        // Create customers
        Customer customer1 = new Customer("Jonathan Muembia", address1);
        Customer customer2 = new Customer("Sarah Muembia", address2);

        // Create products
        Product product1 = new Product("Milk", "Lg45", 30.0, 3);
        Product product2 = new Product("Cookies", "94Tg", 60.0, 2);
        Product product3 = new Product("Apple", "Gt789", 105.0, 1);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        // Display results
        System.Console.WriteLine("Order 1 Packing Label:");
        System.Console.WriteLine(order1.GetPackingLabel());
        System.Console.WriteLine("Order 1 Shoping  Label:");
        System.Console.WriteLine(order1.GetShippingLabel());
        System.Console.WriteLine("Order 1 Total Cost:");
        System.Console.WriteLine(order1.GetTotalCost());

        System.Console.WriteLine();

        System.Console.WriteLine("Order 2  Label:");
        System.Console.WriteLine(order2.GetPackingLabel());
        System.Console.WriteLine("Order 2  Label:");
        System.Console.WriteLine(order2.GetShippingLabel());
        System.Console.WriteLine("Order 2 Total Cost:");
        System.Console.WriteLine(order2.GetTotalCost());
    }
}
public class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
        this.products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double GetTotalCost()
    {
        double totalCost = 0;
        foreach (var product in products)
        {
            totalCost += product.GetTotalCost();
        }
        totalCost += customer.IsInUSA() ? 5 : 35;
        return totalCost;
    }

    public string GetPackingLabel()
    {
        StringBuilder packingLabel = new StringBuilder();
        foreach (var product in products)
        {
            packingLabel.AppendLine($"Product: {product.GetName()}, ID: {product.GetProductId()}");
        }
        return packingLabel.ToString();
    }

    public string GetShippingLabel()
    {
        return $"{customer.GetName()}\n{customer.GetAddress().GetFullAddress()}";
    }
}
public class Product
{
    private string name;
    private string productId;
    private double price;
    private int quantity;

    public Product(string name, string productId, double price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }

    public double GetTotalCost()
    {
        return price * quantity;
    }

    public string GetName()
    {
        return name;
    }

    public string GetProductId()
    {
        return productId;
    }
}
public class Customer
{
    private string name;
    private Address address;

    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    public bool IsInUSA()
    {
        return address.IsInUSA();
    }

    public string GetName()
    {
        return name;
    }

    public Address GetAddress()
    {
        return address;
    }
}
public class Address
{
    private string streetAddress;
    private string city;
    private string stateProvince;
    private string country;

    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        this.streetAddress = streetAddress;
        this.city = city;
        this.stateProvince = stateProvince;
        this.country = country;
    }

    public bool IsInUSA()
    {
        return country.ToLower() == "usa";
    }

    public string GetFullAddress()
    {
        return $"{streetAddress}\n{city}\n{stateProvince}\n{country}";
    }
}