namespace _8._10._leveringsbedrijf;
class Program
{
    
    
    static void Main(string[] args)
    {
        int[] postalCodes = { 59100, 59110, 59111, 59112, 59113, 59114, 59115, 59116, 59117, 59118 };
        int[] price = { 150, 160, 170, 180, 190, 200, 170, 180, 210, 160 };
        

        double weight = Input.AskDouble("Geef gewicht pakket? ");
        int postalCode = Input.AskInteger("Naar welke postcode wenst u dit pakket te versturen?");
        double cost = priceCalculation(weight, postalCode, postalCodes, price);
        Console.WriteLine($"Dit zal {cost} euro kosten.");

    }

    // Methods

    public static double priceCalculation(double weight, int postalCode, int[]postalCodes, int[]price)
    {
        int index = Array.BinarySearch(postalCodes, postalCode);
        return price[index] * weight;
    }
    // Classes
    public static class Input
    {
        public static string AskString(string question)
        {
            Console.Write($"{question}");
            return Console.ReadLine() ?? string.Empty;
        }
        public static int AskInteger(string question)
        {
            while (true)
            {
                Console.Write($"{question}");
                if (int.TryParse(Console.ReadLine(), out int r))
                    return r;

            }
        }
        public static char AskChar(string question)
        {
            while (true)
            {
                Console.Write($"{question}");
                if (char.TryParse(Console.ReadLine(), out char r))
                    return r;

            }


        }

        public static double AskDouble(string question)
        {
            while (true)
            {
                Console.Write($"{question}");
                if (double.TryParse(Console.ReadLine(), out double r))
                    return r;

            }
        }
    }
}
