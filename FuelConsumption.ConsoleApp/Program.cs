namespace FuelConsumption.ConsoleApp
{
    internal class Program
    {
        private static void Main()
        {
            Console.Write("Initial mileage > ");
            double initialMileage = Convert.ToDouble(Console.ReadLine());
            Console.Write("Final mileage > ");
            double finalMileage = Convert.ToDouble(Console.ReadLine());
            Console.Write("Fuel consumed > ");
            double fuelConsumed = Convert.ToDouble(Console.ReadLine());

            Vehicle vehicle = new Vehicle
            {
                InitialMileage = initialMileage,
                FinalMileage = finalMileage,
                FuelConsumed = fuelConsumed 
            };

            Console.WriteLine
                ($"Consumed fuel per kilometer is {vehicle.ConsumptionPerKm:F2}");
        }
    }

    internal class Vehicle
    {
        public double InitialMileage { private get; init; }
        public double FinalMileage { private get; init; }
        public double FuelConsumed { private get; init; }

        private double KilometersTraveled =>
            FinalMileage - InitialMileage;
        public double ConsumptionPerKm =>
           FuelConsumed / KilometersTraveled; 
    }
}
