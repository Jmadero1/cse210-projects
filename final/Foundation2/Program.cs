class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Online Ordering System");

        // Get customer information
        Console.Write("Enter customer name: ");
        string customerName = Console.ReadLine();

        Console.Write("Enter street address: ");
        string streetAddress = Console.ReadLine();

        Console.Write("Enter city: ");
        string city = Console.ReadLine();

        Console.Write("Enter state/province: ");
        string state = Console.ReadLine();

        Console.Write("Enter country: ");
        string country = Console.ReadLine();

        Address customerAddress = new Address(streetAddress, city, state, country);
        Customer customer = new Customer(customerName, customerAddress);

        // Create order
        Order order = new Order(customer);

        // Get product information for user
        while (true)
        {
            Console.WriteLine("\nEnter product information (or type 'done' to finish):");

            Console.Write("Enter product name: ");
            string productName = Console.ReadLine();

            if (productName.ToLower() == "done")
                break;

            Console.Write("Enter product ID: ");
            string productId = Console.ReadLine();

            Console.Write("Enter price per unit: ");
            double pricePerUnit = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            Product product = new Product(productName, productId, pricePerUnit, quantity);
            order.AddProduct(product);
        }

        // Display order information input for user 
        Console.WriteLine("\nOrder Summary:");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order.CalculateTotalCost()}");

        Console.WriteLine("\nThank you for using the Online Ordering System");
    }
}