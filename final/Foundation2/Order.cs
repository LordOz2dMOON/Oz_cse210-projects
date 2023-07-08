public class Order
{
    List<Product> productsList =  new List<Product>();
    Customer _customer;

    public Order(List<Product> products, Customer customer) 
    {
        this.productsList = products; 
        this._customer = customer;
    }

    public int CalculateTotalCost()
    {
        int total = 0;
        foreach(Product p in productsList) 
        {
            total += p.GetPrice();
        }

        if (_customer.IsUSAResident())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }
    public string GetPackagingLabel()
    {
        String label = "";
        foreach(Product p in productsList) 
        {
            label += $"{p.GetName()}, {p.GetProductId()} \n"; 
        }
        return label;
    }
    public string GetShippingLabel()
    {
        String shippingLabel = "";
        shippingLabel += $"{_customer.Getname()}, {_customer.CustomerAddress()}";
        return shippingLabel;
    }
}