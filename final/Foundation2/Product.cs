public class Product
{
    private int _product_id;
    private int _price;
    private int _quantity;
    private string _name;

    public Product(string name, int productId, int price, int quantity)
    {
        _product_id = productId;
        _price = price;
        _quantity = quantity;
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }
    public int GetProductId()
    {
        return _product_id;
    }
    public int GetPrice()
    {
        return _price;
    }
    public int GetQuantity()
    {
        return _quantity;
    }


    public void SetName(string name)
    {
        _name = name;
    }
    public void SetProductId(int productId)
    {
        _product_id = productId;
    }
    public void SetPrice(int price)
    {
        _price = price;
    }
    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }

    public int GetProductPrice()
    {
        return _price * _quantity;
    }
}