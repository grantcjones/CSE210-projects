using System;
using static System.Console;
class Program
{
    static void Main(string[] args) //TODO Clean up output
    {   
        Address a1 = new Address("234 Easy St", "Portland", "OR", "USA");
        Customer c1 = new Customer("Bon Jovi", a1); //! Must have valid address but still be class Address?
        
        Product p1 = new Product("Box", "232", 50, 2);
        Product p2 = new Product("Cube", "323", 12, 30);
        
        int total = (c1.CustomerOrigin(a1)) + p1.GetPrice() + p2.GetPrice();

        Order o1 = new Order(p1.GetPrice(), c1.CustomerOrigin(a1), a1.GetAddress());
        {
            o1.AddProduct(p1.GetProduct());
            o1.AddProduct(p2.GetProduct());

            WriteLine($"Order Total:\n  ${total}\n");

            o1.PackingLabel();

            o1.ShippingLabel(c1.GetCustomer());
        }
    }
}