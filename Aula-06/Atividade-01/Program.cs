internal class Program
{
    //Lista de Cidades
    private static void Main(string[] args)
    {
        Console.WriteLine("=== TRABALHANDO COM LISTAS ===");

        // Iniciar uma nova lista
        List<string> listaCidades = new List<string>();

        listaCidades.Add("Salvador");
        listaCidades.Add("Curitiba");
        listaCidades.Add("Rio de Janeiro");
        listaCidades.Add("São Paulo");
        listaCidades.Add("Gramado");

         foreach (var item in listaCidades)
        {
            Console.WriteLine(item);
        }
    }
}
         
