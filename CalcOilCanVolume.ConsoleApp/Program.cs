namespace CalcOilCanVolume.ConsoleApp
{
    internal class Program
    {
        private static void Main()
        {
            Console.Write("Radius > ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.Write("Height > ");
            double height = Convert.ToDouble(Console.ReadLine());

            OilCan oilCan = new OilCan
            {
                Radius = radius,
                Height = height
            };

            Console.WriteLine($"The oil can volume is {oilCan.Volume:F2}");
        }
    }

    internal class OilCan
    {
        public double Radius { private get; init; }
        public double Height { private get; init; }
        
        public double Volume =>
            Math.PI * Math.Pow(Radius, 2) * Height;
    }
}
