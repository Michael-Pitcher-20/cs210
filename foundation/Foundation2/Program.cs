using System;

class Program
{
    static void Main(string[] args)
    {
        Address home1 = new Address("150 Washington Plaza", "Spokane","Washington","USA",true); 
        Customer Miguel = new Customer("Miguel",home1);
        List<Product> products1 = new List<Product>();
        Product bananas = new Product("bananas", 2121,3,2);
        Product pudding = new Product("pudding",4681, 2,5);
        products1.Add(bananas);
        products1.Add(pudding);
        Order order1 = new Order(Miguel,products1);
        order1.GetShippingLabel();
        order1.GetPackingLabel();
        order1.GetTotalCost();

        Console.Write(Environment.NewLine);

        Address home2 = new Address("1492 Mayflower Drive", "Brighton","SouthEast","England",false); 
        Customer Cristobal = new Customer("Cristobal",home2);
        List<Product> products2 = new List<Product>();
        Product flour = new Product("flour", 8765,5,1);
        Product eggs = new Product("eggs",1234, 9,2);
        products2.Add(flour);
        products2.Add(eggs);
        Order order2 = new Order(Cristobal,products2);
        order2.GetShippingLabel();
        order2.GetPackingLabel();
        order2.GetTotalCost();


    }
}