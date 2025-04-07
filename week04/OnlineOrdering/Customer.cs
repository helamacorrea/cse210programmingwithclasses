public class Customer 
{
    private string _name;
    private Address _address;
    
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public bool InUsa()
    {
        return _address.InUsa();
    }

    public string GetShippingLabel()
    {
        return $"Name: {_name}\n{_address.FullAddress()}";
    }
}