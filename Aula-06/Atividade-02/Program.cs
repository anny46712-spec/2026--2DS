internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== Manipulação de List ===");

        // 1 - Iniciar uma nova lista
        List<int> listaNumeros = new List<int>
        {
            10, 25, 8, 42, 15, 30
        };

        // 2 - Inserir o número 100 na posição 2
        listaNumeros.Insert(2, 100);

        //Remover o elemento que está na última posição
        listaNumeros.RemoveAt(listaNumeros.Count - 1);

        //Percorrer todos os elementos de uma lista
        Console.WriteLine();

        foreach (var numero in listaNumeros)
        {
            Console.WriteLine(numero);
        }
    }
}