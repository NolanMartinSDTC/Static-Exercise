namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To convert from Fahrenheit to Celsius, enter 1\nTo convert from Celsius to Fahrenheit, enter 2\nOption 1, or option 2: ");
            var userInput = int.Parse(Console.ReadLine());

            while (userInput !=1 && userInput != 2)
            {
                Console.WriteLine("Please enter either 1 or 2: ");
                userInput = int.Parse(Console.ReadLine());
            }


            if (userInput == 1)
            {
                Console.WriteLine("What temperature would you like to convert from Fahrenheit to Celsius? ");
                var userTemp = Convert.ToDouble(Console.ReadLine());

                double convTemp = TempConverter.FahrenheitToCelsius(userTemp);
                Console.WriteLine($"{userTemp} degrees Fahrenheit is approximately {convTemp} degrees Celsius.");
            }

            else
            {
                Console.WriteLine("What temperature would you like to convert from Celsius to Fahrenheit? ");
                var userTemp = Convert.ToDouble(Console.ReadLine());

                double convTemp = TempConverter.CelsiusToFahrenheit(userTemp);
                Console.WriteLine($"{userTemp} degrees Celsius is approximately {convTemp} degrees Fahrenheit.");

            }
        }
    }
}
