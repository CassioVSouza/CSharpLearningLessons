
using ConversorAPI;
using RandomNumberAPI;
using Shipment;

namespace ConsoleDegreeConversor
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Welcome, what function do you want to use ?\n1 - DegreeConvert\n2 - Random Number\n3 - Random Number");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            switch (userChoice)
            {
                case 1:
                    DegreeConvert();
                    break;

                case 2:
                    RandomNumber randomMethod = new RandomNumber();
                    randomMethod.RandomList(random);
                    break;

                case 3: ShipProduct();
                    break;

                default:
                    Console.WriteLine("Insert a valid operation!");
                    break;
            }
        }

        private static void ShipProduct()
        {
            List<IProductModel> products = AddingProducts();
            CustomerModel customer = GetCustomer();

            foreach(IProductModel product in products)
            {
                product.Shipment(customer);
                product.
            }
        }

        private static CustomerModel GetCustomer()
        {
            return new CustomerModel() //Example of customer
            {
                FirstName = "Dexter",
                LastName = "Connor",
                EmailAdress = "dexter@gmail.com",
                PhoneNumber = "567-4335",
                Address = "123, Frank St.Boulevard",
                City = "Los Angeles"
            };
        }

        private static List<IProductModel> AddingProducts()
        {
            List<IProductModel> productModels = new List<IProductModel>();

            productModels.Add(new PhysicalProductModel { Name = "Chocolate" });
            productModels.Add(new PhysicalProductModel { Name = "Shirt" });
            productModels.Add(new DigitalProduct { Name = "God Of War" });

            return productModels;
        }

        private static void DegreeConvert()
        {
            Console.WriteLine("Hello, Welcome to the Degree Converter! What do you want ?");
            Console.WriteLine("1 - Convert C° to F°\n2 - Convert F° to C°");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            double Degree = 0;
            ConvertAPI convert = new ConvertAPI();

            switch (userChoice)
            {
                case 1:
                    Console.WriteLine("Insert the C°: ");
                    Degree = Convert.ToInt32(Console.ReadLine());
                    convert.RecevingDegreeAndChoice(userChoice, Degree);
                    break;

                case 2:
                    Console.WriteLine("Insert the F°: ");
                    Degree = Convert.ToInt32(Console.ReadLine());
                    convert.RecevingDegreeAndChoice(userChoice, Degree);
                    break;

                default:
                    Console.WriteLine("Insert a valid operation!");
                    break;
            }
        }
    }
}
