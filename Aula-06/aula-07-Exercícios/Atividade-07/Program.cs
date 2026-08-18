internal class Program
{
    public class Produto
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public double Preco { get; set; }
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("=== TRABALHANDO COM PRODUTOS ===");

        //Iniciar uma nova lista
        List<Produto> listaProdutos = new List<Produto>();

        Produto produto1 = new Produto { Id = 1, Nome = "Picanha", Preco = 89.90 };
        Produto produto2 = new Produto { Id = 2, Nome = "Macarrão", Preco = 5.99 };
        Produto produto3 = new Produto { Id = 3, Nome = "Chocolate", Preco = 10.00 };
        Produto produto4 = new Produto { Id = 4, Nome = "Café", Preco = 60.00 };
        Produto produto5 = new Produto { Id = 5, Nome = " filé Mignon", Preco = 130.00 };

        //Adicionar produtos na lista
        listaProdutos.Add(produto1);
        listaProdutos.Add(produto2);
        listaProdutos.Add(produto3);
        listaProdutos.Add(produto4);
        listaProdutos.Add(produto5);

        //Filtrando produtos com preço maior que R$ 50,00
        var produtosFiltrados = listaProdutos.Where(produto => produto.Preco > 50);

        // 4 - Imprimir os produtos encontrados
        Console.WriteLine();

        foreach (var produto in produtosFiltrados)
        {
            Console.WriteLine($"{produto.Nome} - R$ {produto.Preco:F2}");
        }
    }
}
