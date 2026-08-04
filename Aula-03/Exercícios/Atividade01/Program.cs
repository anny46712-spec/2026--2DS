using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        int celsius; 
        Console.WriteLine("Digite a temperatura em Celsius:");
        celsius = int.Parse(Console.ReadLine());

        double fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine("A temperatura em Fahrenheit é : " + fahrenheit );
    }
}