public class Customer
{
    private string _name;
    Address Address;

    public Customer(string name, Address address)
    {
        _name = name;
        Address = address;
    }

    public string Getname()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public bool IsUSAResident()
    {
        return Address.IsInUSA();
    }

    public string CustomerAddress()
    {
        return Address.GetAddressString();
    }
}