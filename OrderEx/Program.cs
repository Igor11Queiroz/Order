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
        Console.Write("Birth date: ");
        DateTime clientBirth = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Enter ");
    }
}