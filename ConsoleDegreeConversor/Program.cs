
using ConversorAPI;
using RandomNumberAPI;

namespace ConsoleDegreeConversor
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Welcome, what function do you want to use ?\n1 - DegreeConvert\n2 - Random Number");
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
                default:
                    Console.WriteLine("Insert a valid operation!");
                    break;
            }
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
