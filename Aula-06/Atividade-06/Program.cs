internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== Lambda Expression ===");

        //Criar uma função utilizando Func
        Func<int, int, int> multiplicar;

        //Criar uma Lambda Expression
        multiplicar = (numero1, numero2) => numero1 * numero2;

        // Testando a função com 3 pares de valores diferentes
        int resultado1 = multiplicar(9, 4);
        int resultado2 = multiplicar(7, 7);
        int resultado3 = multiplicar(3, 8);

        //Resultado
        Console.WriteLine();
        Console.WriteLine($"9 x 4 = {resultado1}");
        Console.WriteLine($"7 x 7 = {resultado2}");
        Console.WriteLine($"3 x 8 = {resultado3}");
    }
}