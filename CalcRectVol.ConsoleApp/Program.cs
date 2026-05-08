namespace CalcRectVol.ConsoleApp;

class Program
{
    static void Main()
    {
        Rectangle rect = new();

        Console.Write("W > ");
        rect.width = Convert.ToDecimal(Console.ReadLine());
        Console.Write("H > ");
        rect.height = Convert.ToDecimal(Console.ReadLine());
        Console.Write("L > ");
        rect.length = Convert.ToDecimal(Console.ReadLine());

        rect.volume = rect.length * rect.width * rect.height;
        Console.WriteLine($"\nVolume -> {rect.volume}");
    }
}
