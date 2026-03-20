public class Product
{
    //Attributes

    private string _name;
    private string _productId;
    private double _pricePerUnit;
    private int _quantity;


    //Constructor
    public Product (string name, string productId, double pricePerUnit, int quantity)
    {
        _name = name;
        _productId = productId;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }


    //Methods/gettters
    public string GetName()
    {
        return _name;
    }

    public string GetProductId()
    {
        return _productId;
    }

    public double GetPricePerUnit()
    {
        return _pricePerUnit;
    }

    public double GetTotalPrice()
    {
        return _pricePerUnit * _quantity;
    }
}