namespace OrderEx.Entities;

public class Orderitem
{
    public int Quantity { get; set; }
    public double Price { get; set; }
    public Product Product { get; set; }


    public Orderitem()
    {
    }

    public Orderitem(int quantity, double price)
    {
        Quantity = quantity;
        Price = price;
    }

    public Orderitem(int quantity, double price, Product product)
    {
        Quantity = quantity;
        Price = price;
        Product = product;
    }

    public double SubTotal()
    {
        return Quantity * Price;
    }
    public override string ToString()
    {
        if (Product != null)
        {
            return $"{Product.Name}, ${Price}, {Quantity}, Subtotal: ${SubTotal()}";
        }
        else
        {
            return "Product not set";
        }
    }

  
}
