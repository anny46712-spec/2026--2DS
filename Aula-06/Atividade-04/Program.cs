internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== Fila de Atendimento ===");

        // Cria uma nova fila vazia
        Queue<string> filaAtendimento = new Queue<string>();

        //Adicionar elementos na fila
        filaAtendimento.Enqueue("Maria");  
        filaAtendimento.Enqueue("Mauro"); 
        filaAtendimento.Enqueue("Antoni"); 
        filaAtendimento.Enqueue("Francisco"); 
        filaAtendimento.Enqueue("Francisca"); 

        // Percorrer elementos de uma fila 
        Console.WriteLine();
        foreach (var pessoa in filaAtendimento)
        {
            Console.WriteLine(pessoa);
        }

        // Retirar um elemento da lista
        string pessoaRetirada = filaAtendimento.Dequeue();
        Console.WriteLine();
        Console.WriteLine($"O Nome chamado foi: {pessoaRetirada}");

         Console.WriteLine();
        
        foreach (var pessoa in filaAtendimento)
        {
            Console.WriteLine(pessoa);
        }

         string pessoaRetirada2 = filaAtendimento.Dequeue();
        Console.WriteLine();
        Console.WriteLine($"O Nome chamado foi: {pessoaRetirada2}");

         Console.WriteLine();
        
        foreach (var pessoa in filaAtendimento)
        {
            Console.WriteLine(pessoa);
        }
    }
}