namespace ConvCelsToFahr.ConsoleApp
{
    internal class Program
    {
        private static void Main()
        {
            Console.Write("Celsius > ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            Temperature temperature = new Temperature
            {
                Celsius = celsius
            };

            Console.WriteLine
                ($"{celsius}(C) to (F) is -> {temperature.Fahrenheit:F2}(F)");
        }
    }

    internal class Temperature
    {
        public double Celsius { private get; init; }

        public double Fahrenheit =>
            (Celsius * 1.8) + 32;
    }
}

