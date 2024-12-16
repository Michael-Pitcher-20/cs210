using System;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    private bool _inUSA;

    public Address(string street, string city, string state, string country, bool inUSA)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
        _inUSA = inUSA;
    }
   public bool GetIsInUSA()
   {
    return _inUSA;
   }
   public string GetAddress()
   {
    return  ($"Street: {_street}\nCity: {_city}\nState: {_state}\nCountry: {_country}\nLives in USA : {_inUSA}");
   }
}