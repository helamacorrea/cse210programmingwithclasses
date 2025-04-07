public class Product
{
    private string _name;
    private int _id;
    private double _price;
    private int _quantity;

    public Product(string name, int id, double price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public double Cost()
    {
        return _price * _quantity;
    }

    public string ProductLabel()
    {
        return $"\nProduct Name: {_name} Product ID: {_id}";
    }
}