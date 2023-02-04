namespace StaticExercise
{
    class program
    {
        static void Main(string[] args)
        {
           var celsius= TempConverter.FahrenheitToCelsius(68);
            var fahrenheit = TempConverter.CelsiusToFahrenheit(20);
            Console.WriteLine("After conversion:");
            Console.WriteLine($"celsius {celsius}");
            Console.WriteLine($"Fahrenheit {fahrenheit}");

        }
        
    }
}
