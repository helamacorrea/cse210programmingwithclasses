using System;

class Program
{
    static void Main(string[] args)
    {
        Product p1 = new Product("Helmet", 290398, 50, 2);
        Product p2 = new Product("Towell", 291398, 5, 4);
        Product p3 = new Product("Bag", 290378, 20, 1);
        Product p4 = new Product("TV", 272346398, 500, 3);
        Product p5 = new Product("Spoon", 29032764, 2, 6);
        Product p6 = new Product("T-Shirt", 223430398, 25, 10);

        Address a1 = new Address("432", "Itapema", "SC", "Brazil");
        Address a2 = new Address("432", "Rexburg", "Idaho", "USA");

        Customer c1 = new Customer("Gabrielly", a1);
        Customer c2 = new Customer("Helaman", a2);

        Order o1 = new Order(c1);
        o1.AddToProductsList(p1,p2,p3);

        Order o2 = new Order(c2);
        o2.AddToProductsList(p1,p2,p3);

        Order o3 = new Order(c1);
        o3.AddToProductsList(p4,p5,p6);

        Order o4 = new Order(c2);
        o4.AddToProductsList(p4,p5,p6);

        o1.DisplayOrder();
        o2.DisplayOrder();
        o3.DisplayOrder();
        o4.DisplayOrder();
    }
}