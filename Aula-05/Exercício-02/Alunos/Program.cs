using System.Runtime.InteropServices.Marshalling;
using System.Threading.Tasks.Dataflow;

internal class Program
{
    private static void Main(string[] args)
    {
        // Primeiro Aluno
        Aluno aluno1 = new Aluno();
        aluno1.RM = "4523";
        aluno1.Nome = "Maria";
        aluno1.Nascimento = "2009.04.12";
        aluno1.Email = "maria23@gmail.com";

         // Segundo Aluno
        Aluno aluno2 = new Aluno();
        aluno2.RM = "9834";
        aluno2.Nome = "João";
        aluno2.Nascimento = "2009.11.23";
        aluno2.Email = "João@gmail.com";

         // Terceiro Aluno
        Aluno aluno3 = new Aluno();
        aluno3.RM = "2301";
        aluno3.Nome = "Clara";
        aluno3.Nascimento = "2009.2.17";
        aluno3.Email = "Clara02@gmail.com";

        // Exibindo os livros
        Console.WriteLine("==== Alunos ====");
        Console.WriteLine($"\nAluno 01: {aluno1.RM} | Nome: {aluno1.Nome} | RM: {aluno1.RM} | Nascimento: {aluno1.RM} | Email: {aluno1.Email} ");
        Console.WriteLine($"\nAluno 02: {aluno2.RM} | Nome: {aluno2.Nome} | RM: {aluno2.RM} | Nascimento: {aluno2.RM} | Email: {aluno2.Email}");
        Console.WriteLine($"\nAluno 03: {aluno3.RM} | Nome: {aluno3.Nome} | RM: {aluno3.RM} | Nascimento: {aluno3.RM} | Email: {aluno3.Email}");
    }
}

public class Aluno
{
    public string RM { get; set; }
    public string Nome { get; set; }
    public string Nascimento { get; set; }
    public string Email { get; set; }
}