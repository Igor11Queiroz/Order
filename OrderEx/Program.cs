using System.Globalization;
using OrderEx.Entities;
using OrderEx.Entities.Enum;
using DateTime = System.DateTime;

namespace OrderEx;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter client data:");
        Console.Write("Name: ");
        string clientName = Console.ReadLine();
        Console.Write("Email: ");
        string clientEmail = Console.ReadLine();
        Console.Write("Birth date (DD/MM/YYYY): ");
        DateTime clientBirth = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Enter order data: ");
        Console.Write("Status:");
        OrderStatus orderStatus = Enum.Parse<OrderStatus>(Console.ReadLine());

        Client client = new Client(clientName, clientEmail,clientBirth );
        Order order = new Order(DateTime.Now, orderStatus, client);
        Console.Write("How many itens to this order?");
        int orderNumber = int.Parse(Console.ReadLine());

        for (int i = 1; i <= orderNumber; i++)
        {
            Console.WriteLine($"Enter {i}# item data: ");
            Console.Write("Product name:");
            string productName = Console.ReadLine();
            Console.Write("Product price: ");
            double productPrice = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
           
            Product product = new Product(productName, productPrice);
            
            Console.Write("Quantity: ");
            int productQuantity = int.Parse(Console.ReadLine());
           

            Orderitem orderItem = new Orderitem(productQuantity, productPrice, product);

            order.AddItem(orderItem);
        }

        // 15/03/1985
        Console.WriteLine("ORDER SUMMARY:");
        Console.WriteLine(order);

    }
}