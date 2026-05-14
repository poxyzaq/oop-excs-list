namespace CalcSphereVolume.ConsoleApp
{
    internal class Program
    {
        private static void Main()
        {
            Console.Write("Enter the radius > ");
            double radius = Convert.ToDouble(Console.ReadLine());

            Sphere sphere = new Sphere
            {
                Radius = radius
            };

            Console.WriteLine($"The volume is {sphere.Volume:F2}");
        }
    }

    internal class Sphere
    {
        public double Radius { private get; init; }

        // V = 4/3 x 3.14 x r3
        public double Volume =>
            4.0 / 3.0 * Math.PI * Math.Pow(Radius, 3);
    }
}
