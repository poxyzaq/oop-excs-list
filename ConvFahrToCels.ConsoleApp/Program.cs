namespace ConvFahrToCels.ConsoleApp;

public class Program
{
    public static void Main()
    {
        Console.Clear();

        Console.WriteLine("-----------------------");
        Console.WriteLine($"C to F");
        Console.WriteLine("-----------------------");
        Console.Write("C > ");
        decimal celsius = 
            Convert.ToDecimal(Console.ReadLine());

        Temperature temp = new();
        temp.CelsiusToFahrenheit(celsius);

        Console.WriteLine("-----------------------");
        Console.WriteLine($"{temp.celsius} (C) to F -> {temp.fahrenheit} (F)");
    }
}

//To convert Celsius (C) to Fahrenheit (F) easily, 
//double the Celsius number and add 30 (C * 2 + 30)

//For a more accurate conversion, multiply the Celsius 
//temperature by 1.8 and add 32. 

public class Temperature
{
    public decimal celsius;
    public decimal fahrenheit;

    public decimal CelsiusToFahrenheit(decimal celsius)
    {
        this.celsius = celsius;
        fahrenheit = (celsius * 1.8m) + 32m;
        //m suffix cause decimal
        return fahrenheit;
    }
}
