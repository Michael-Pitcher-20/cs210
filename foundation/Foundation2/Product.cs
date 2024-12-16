using System;

public class Product
{
    private string _product;
    private int _id;
    private int _price;
    private int _quantity;

    public Product(string product, int id, int price, int quantity)
    {
        _product = product;
        _id = id;
        _price = price;
        _quantity = quantity;
    }
    public int GetCost()
    {
        return _price * _quantity;
    }
    public string GetProductInformation()
    {
        return ($"{_product}:{_id}");
    }
}