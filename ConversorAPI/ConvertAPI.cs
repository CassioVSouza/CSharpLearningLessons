namespace ConversorAPI
{
    public class ConvertAPI
    {
        public void RecevingDegreeAndChoice(int userChoice, double Degree) 
        {
            if(userChoice == 1)
            {
                ConvertCtoF(Degree);
            }
            else if(userChoice == 2)
            {
                ConvertFtoC(Degree);
            }
        }
        private void ConvertCtoF(double Degree)
        {
            double DegreeConverted = (Degree * 9 / 5) + 32;
            Console.WriteLine($"C°{Degree} is F°{DegreeConverted}!");
        }
        private void ConvertFtoC(double Degree)
        {
            double DegreeConverted = (Degree - 32) * 5 / 9;
            Console.WriteLine($"F°{Degree} is C°{DegreeConverted}!");
        }
    }
}
