namespace CalcCiliVol.ConsoleApp
{
    internal static class MyVeryCoolClass
    {
        private static int Main()
        {
            Console.Clear();
            Console.WriteLine("---------------------");
            Console.Write("R > ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("---------------------");

            Console.WriteLine("---------------------");
            Console.Write("H > ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("---------------------");
            
            Cylinder cylinder = new Cylinder
            {
                Radius = radius,
                Height = height
            };

            Console.WriteLine("---------------------");
            Console.WriteLine($"Volume -> {cylinder.Volume:F2}");

            return 0;
        }
    }

    internal class Cylinder 
    {
        public double Radius { private get; init; }
        public double Height { private get; init; }
        public double Volume =>
            Math.PI * Math.Pow(Radius, 2) * Height;
    }
}
