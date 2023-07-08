using System;

class Program
{
    static void Main(string[] args)
    {
        List<Product> order1 = new List<Product>(); 
        order1.Add(new Product("Shirt", 1124, 500, 5)); 
        order1.Add(new Product("Jeans", 1125, 700, 3));
        List<Product> order2 = new List<Product>();
        order2.Add(new Product("Playstation 5", 1865, 1000, 1)); 
        order2.Add(new Product("Samsung galaxy s22", 2449, 1300, 2));
        Address customerAddress = new Address("15 Morenike close", "Ikeja", "Lagos", "Nigeria");
        Address secondCustomerAddress = new Address("50 ekenwan road", "Benin-city", "Edo state", "Nigeria");
        Customer c1 = new Customer("Oswald", customerAddress);
        Customer c2 = new Customer("Eghosa", secondCustomerAddress);
        Order firstOrder = new Order(order1, c1);
        Order secondOrder = new Order(order2, c2);

        Console.WriteLine(firstOrder.CalculateTotalCost());
        Console.WriteLine(" ");
        Console.WriteLine(firstOrder.GetPackagingLabel());
        Console.WriteLine(" ");
        Console.WriteLine(firstOrder.GetShippingLabel());
        Console.WriteLine(" ");

        Console.WriteLine(secondOrder.CalculateTotalCost());
        Console.WriteLine(" ");
        Console.WriteLine(secondOrder.GetPackagingLabel());
        Console.WriteLine(" ");
        Console.WriteLine(secondOrder.GetShippingLabel());
        Console.WriteLine(" ");

    }
}