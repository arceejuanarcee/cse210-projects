public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }

    public override string ToString()
    {
        return _name;
    }

    public Address Address
    {
        get { return _address; }
    }
}
