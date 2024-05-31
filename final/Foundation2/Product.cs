public class Product
{
    private string _name;
    private string _productId;
    private float _price;
    private int _quantity;

    public Product(string name, string productId, float price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public float GetTotalCost()
    {
        return _price * _quantity;
    }

    public override string ToString()
    {
        return $"{_name} ({_productId})";
    }

    public string ProductId
    {
        get { return _productId; }
    }

    public float Price
    {
        get { return _price; }
    }

    public int Quantity
    {
        get { return _quantity; }
    }

    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }
}
