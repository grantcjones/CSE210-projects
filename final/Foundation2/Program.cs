using System;
using static System.Console;
class Program
{
    static void Main(string[] args)
    {   
        //First Order
        Address a1 = new Address("234 Easy St", "Portland", "OR", "USA");
        Customer c1 = new Customer("Bon Jovi", a1);
        
        Product p1 = new Product("Box", "232", 50, 2);
        Product p2 = new Product("Cube", "323", 12, 30);
        
        int purchases = p1.GetPrice() + p2.GetPrice();

        Order o1 = new Order(purchases, c1.CustomerOrigin(a1), a1.GetAddress());
        {
            o1.AddProduct(p1.GetProduct());
            o1.AddProduct(p2.GetProduct());
            
            WriteLine("    Order #1");
            WriteLine(o1.CostTotal());

            o1.PackingLabel();
            o1.ShippingLabel(c1.GetCustomer());
        }

        //Second Order
        Address a2 = new Address("1200 McLaren St", "Seattle", "WA", "USA");
        Customer c2 = new Customer("Bill Bob", a2);

        Product p3 = new Product("Another Box", "1243", 12, 3);
        Product p4 = new Product("Another Cube", "1324", 1, 200);

        int total2 = p3.GetPrice() + p4.GetPrice();

        Order o2 = new Order(total2, c2.CustomerOrigin(a2), a2.GetAddress());
        {
            o2.AddProduct(p3.GetProduct());
            o2.AddProduct(p4.GetProduct());

            WriteLine("    Order #2");
            WriteLine(o2.CostTotal());

            o2.PackingLabel();
            o2.ShippingLabel(c1.GetCustomer());
        }
    }
}