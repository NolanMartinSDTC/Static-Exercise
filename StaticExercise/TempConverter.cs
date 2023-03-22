using System;
namespace StaticExercise
{
	public static class TempConverter
	{
		
		static TempConverter()
		{
		}

		public static double FahrenheitToCelsius(double degInput)
		{
			Console.WriteLine($"Input temp: {degInput}");
			double degOutput = ((degInput - 32) * (5d / 9d));
			Console.WriteLine($"Output temp: {degOutput}");
			return degOutput;
		}

		public static double CelsiusToFahrenheit(double degInput)
		{
			double degOutput = ((degInput * (9d / 5d)) + 32);
			return degOutput;
		}
	}
}

