internal class Program
{
    private static void Main(string[] args)
    {
        
        string nome;
         Console.WriteLine("Digite o seu nome: ");
         nome = Console.ReadLine();

         int nota1;
         int nota2;
         int nota3;
         int resultado;

         Console.WriteLine("Digite a Primeira nota: ");
         nota1 = int.Parse(Console.ReadLine());


         Console.WriteLine("Digite a Segunda nota: ");
         nota2 = int.Parse(Console.ReadLine());


         Console.WriteLine("Digite a Terceira nota: ");
         nota3 = int.Parse(Console.ReadLine());

         resultado = (nota1 + nota2 + nota3) / 3;
         Console.WriteLine("A soma das notas é: " + resultado);


         double media = resultado;
         if (media >= 7)
        {
            Console.WriteLine ("Aprovado");
        }
        else if (media >= 5)
        {
            Console.WriteLine("Recuperação");
        }
        else
        {
            Console.WriteLine("Reprovado");
        }
    }
}