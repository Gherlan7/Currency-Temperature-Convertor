namespace Currency_Temperature_Convertor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Currency/Temperature Convertor !");
            while (true) 
            {
                Console.WriteLine("Press c or C to access the Currency Convertor or anything else for the Temperature Convertor.");
                string choice1 = Console.ReadLine();

                while (choice1 == "c" || choice1 == "C")
                {
                    Console.WriteLine("Enter e or E to convert from euros to dollars, x or X to switch for Temperature Convertor, anything else to convert from dollars to euros.");
                    string choice2 = Console.ReadLine();
                    if (choice2 == "e" || choice2 == "E")
                    {
                        Console.WriteLine("Enter the sum you want to convert from euros to dollars.");
                        float euros = float.Parse(Console.ReadLine());
                        //Put the f at the end of the number to be interpreted as a float, by default, it is interpreted as a double
                        float dollars = euros * 1.08f;
                        Console.WriteLine($"The amount in dollars is {dollars.ToString("0.00")} dollars.");
                    }
                    else if (choice2 == "x" || choice2 == "X")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Enter the sum you want to convert from dollars to euros.");
                        float dollars = float.Parse(Console.ReadLine());
                        float euros = dollars / 1.08f;
                        Console.WriteLine($"The amount in euros is {euros.ToString("0.00")} dollars.");
                    }
                }
                while (choice1 != "c" || choice1 != "C")
                {
                    Console.WriteLine("Enter f or F to convert from Farenheit to Celsius, x or X to exit to main menu, anything else to convert from Celsius to Farenheit.");
                    string choice2 = Console.ReadLine();
                    if (choice2 == "f" || choice2 == "F")
                    {
                        Console.WriteLine("Enter the value you want to convert from Farenheit to Celsius.");
                        float farenheit = float.Parse(Console.ReadLine());
                        float celsius = (farenheit - 32f) / 1.8f;
                        Console.WriteLine($"The value in Celsius is {celsius.ToString()} degrees.");
                    }
                    else if (choice2 == "x" || choice2 == "X")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Enter the value you want to convert from Celsius to Farenheit.");
                        float celsius = float.Parse(Console.ReadLine());
                        float farenheit = celsius * 1.8f + 32f;
                        Console.WriteLine($"The value in Farenheit is {farenheit.ToString()} degrees.");
                    }
                }
            }
            
        }
    }
}