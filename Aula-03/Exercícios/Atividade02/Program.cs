internal class Program
{
    private static void Main(string[] args)
    {
        int num1;
        int num2;

        Console.WriteLine("Digite o Primeiro Número: ");
        num1 = int.Parse(Console.ReadLine());


        Console.WriteLine("Digite o Segundo Número: ");
        num2 = int.Parse(Console.ReadLine());

        Console.Write("1 - Soma");
        Console.Write("2 - Subtração");
        Console.Write("3 - Multiplicação");
        Console.Write("4 - Divisão");

        string operacao;
        
        Console.Write("Selecione uma Operação: ");
        operacao = Console.ReadLine();

        switch (operacao)
        {
            case "1": 
                Console.WriteLine(num1 + num2);
                break;
            case "2": 
                Console.WriteLine(num1 - num2);
                break;
            case "3": 
                Console.WriteLine(num1 * num2);
                break;
            case "4": 
                Console.WriteLine(num1 / num2);
                break;
            default:
                Console.WriteLine("Operador informado não é válido.");
                break;
        }
    }
}