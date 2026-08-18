using System.Security.Claims;

internal class Program         
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== Dictionary de Produtos ===");
        
        // Criar um Dicionário vazio
        Dictionary<int, string> dicionario = new Dictionary<int, string>();

        // Adicionar elementos no dicionario
        dicionario.Add(1, "Tradicional");
        dicionario.Add(2, "X-Salada");
        dicionario.Add(3, "X-Bacon");
        dicionario.Add(4, "X-Tudo");

         //Percorrer todos os elemetos de um Dicionario
        Console.WriteLine();
        foreach (var item in dicionario)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }
    }
}