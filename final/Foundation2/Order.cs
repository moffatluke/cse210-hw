public class Order
{
    //Attributes
    private List<Product> _products;
    private Customer _customer;

    //Constuctor
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product products)
    {
        _products.Add(products);
    }


    public double GetTotalCost()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total = total + product.GetTotalPrice();
            //loop through on the items to add them together to get the total price. 
        }

        if (_customer.IsInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }
    public string GetPackingLabel()
    {
        string packingLabel = "";

        foreach (Product product in _products)
        {
            packingLabel +=  $"{product.GetName()}: {product.GetProductId()}\n";
        }
        return packingLabel;
    }


    public string GetShippingLabel()
    {
        Address address = _customer.GetAddress();
        return $"{_customer.GetName()}\n {address.GetFullAddress()}";
    }
}