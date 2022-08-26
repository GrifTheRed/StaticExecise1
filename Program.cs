using System;

namespace StaticExersice1
{
    class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(68);
            var fahrenheit = TempConverter.CelsiusToFahrenheit(20);

            Console.WriteLine("After conversion: ");
            Console.WriteLine($"fahrenheit {fahrenheit}");
            Console.WriteLine($"celsius {celsius}");
        }
    }
}

