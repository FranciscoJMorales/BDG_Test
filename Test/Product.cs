public class Product
{
    public string Name { get; }
    private int quantity;
    public int Quantity
    {
        get
        {
            return quantity;
        }
        set
        {
            if (value < 1) quantity = 1;
            else quantity = value;
        }
    }

    public Product(string name, int quantity)
    {
        this.Name = name;
        this.quantity = quantity;
    }
}
