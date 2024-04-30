using OrderEx.Entities.Enum;

namespace OrderEx.Entities;

public class Order
{
    public DateTime Moment { get; set; }
    public OrderStatus Status { get; set; }
    public List<Orderitem> OrderItems { get; set; } = new List<Orderitem>();
    public Client Client { get; set; }
    public Order()  
    {
    }

    public Order(DateTime moment, OrderStatus status, Client client)
    {
        Moment = moment;
        Status = status;
        Client = client;
    }

    public void AddItem(Orderitem orderitem)
    {
        OrderItems.Add(orderitem);
    }

    public void RemoveItem(Orderitem orderitem)
    {
        OrderItems.Add(orderitem);
    }

    public double Total()
    {
        double sum = 0.0;
        foreach (Orderitem item in OrderItems) {
            sum += item.SubTotal();
        }
        return sum;
    }
}
