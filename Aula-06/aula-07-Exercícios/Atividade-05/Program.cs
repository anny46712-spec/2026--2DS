
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== Pilha de Ações ===");

        // Criar uma nova pilha vazia
        Stack<string> pilhaAcoes = new Stack<string>();

        //Adicionar elementos em uma pilha
        pilhaAcoes.Push("Digitar");
        pilhaAcoes.Push("Colar");
        pilhaAcoes.Push("Negrito");
        pilhaAcoes.Push("Apagar");

        // Percorrer todos os elementos de uma pilha
        Console.WriteLine();
        foreach (var acoes in pilhaAcoes)
        {
            Console.WriteLine(acoes);
        }

        // 4 - Remover um elemento da pilha
        string acoesRemovido = pilhaAcoes.Pop();
        Console.WriteLine();
        Console.WriteLine($"A ação retirado foi: {acoesRemovido}");

        Console.WriteLine();
        foreach (var acoes in pilhaAcoes)
        {
            Console.WriteLine(acoes);
        }

         string acoesRemovido2 = pilhaAcoes.Pop();
        Console.WriteLine();
        Console.WriteLine($"A ação retirado foi: {acoesRemovido2}");

        Console.WriteLine();
        foreach (var acoes in pilhaAcoes)
        {
            Console.WriteLine(acoes);
        }
    }
}
