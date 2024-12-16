using System;

public class Order
{
    private Customer _customer;
    private List<Product> _items = new List<Product>();
    public Order(Customer customer,List<Product> items)
    {
        _customer = customer;
        _items = items;
    }

public void GetPackingLabel()
{
    foreach (var item in _items)
    {
        Console.WriteLine(item.GetProductInformation());
    }
     
}
public void GetShippingLabel()
{
    Console.WriteLine($"Name: {_customer.GetName()}\nAddress: {_customer.GetAddress()}");
}
public void GetTotalCost()
{
    int total = 0;

    foreach (var item in _items)
    {
        total += item.GetCost();
        
    }
    if (_customer.LivesInCountry())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
    Console.WriteLine($"Total Cost: ${total}");
}

}