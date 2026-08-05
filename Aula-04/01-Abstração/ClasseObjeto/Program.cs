internal class Program
{
    private static void Main(string[] args)
    {
        /*
        Classe -> É a abstração de um objeto do mundo real para o mundo computacional.
        Objeto -> É a instância de uma classe.
        */

        // Instancia objetos do tipo Aluno
        Aluno aluno01 = new Aluno();
        Aluno aluno02 = new Aluno();

        aluno01.Nome = "José da Silva";
        aluno01.RM = 2444;
        aluno01.DataNascimento = new DateOnly(2010, 01, 15);

         aluno02.Nome = "João dos Santos";
        aluno01.RM = 1234;
        aluno01.DataNascimento = new DateOnly(2006, 12, 07);

        // Executar os Metodos
        aluno01.ApresentarSe();
        aluno02.ApresentarSe();      
    }
}

public class Aluno // Declaração da classe
{
    // Atributos (características)
    public string Nome { get; set; }
    public int RM { get; set; }
    public DateOnly DataNascimento { get; set; }

    // Método (ação)
    public void ApresentarSe()
    {
        Console.WriteLine($"Olá, meu nome é {Nome}, meu RM é {RM} e nasci na data {DataNascimento}.");
    }
}