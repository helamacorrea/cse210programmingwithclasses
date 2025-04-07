public class Order 
{
    private List<Product> _productsList = new List<Product>();
    private Customer _customer;
    public Order(Customer customer)
    {
        _customer = customer;
    }
    public double TotalPrice()
    {
        double TotalCost = 0.0;
        foreach (Product product in _productsList)
        {
            TotalCost += product.Cost();
        }
        if (_customer.InUsa())
        {
            TotalCost += 5.0;
        }
        else //outside usa
        {
            TotalCost += 35.0;
        }

        return TotalCost;
    }
    public string PackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _productsList)
        {
            packingLabel += product.ProductLabel();
        }
        
        return packingLabel;
    }
    public string ShippingLabel()
    {
        return _customer.GetShippingLabel();
    }

    public void DisplayOrder()
    {
        Console.WriteLine(PackingLabel());
        Console.WriteLine(ShippingLabel());
        Console.WriteLine($"Total Price: ${TotalPrice()}\n");
    }

    public void AddToProductsList(params Product[] product)
    {
        foreach (Product p in product)
        {
            _productsList.Add(p);
        }
    }

}
