using System.Globalization;
using System.Net.Mail;
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
        sintaxe: Enquanto uma condição for verdadeira 

        execute um conjunto de comandos

        for -> Quando sabemos a quantidade de repetições.
        while -> Quando a repetição depende de uma condição.
        do ... while -> Quando precisa executar ao menos uma vez o bloco de codigo
        */


        /* Laço for: imprimir numeros de 1 até 10*/

        Console.WriteLine("Imprimir numeros de 1 até 10, utilizando for.");
        for(int numero = 1; numero <= 10; numero++ )
        {
            Console.WriteLine(numero);
        }

          /* Laço for: Contagem Regressiva de 10 até 0*/

        Console.WriteLine("Imprimir Contagem Regressiva.");
        for(int numero = 10; numero >= 0; numero-- )
        {
            Console.WriteLine(numero);
        }

        /* ********************************************** */
        /* Laço whilw: imprimir numeros de 1 até 10*/
        
        Console.WriteLine("Imprimir numeros de 1 até 10, utilizando o laço while.");

        int contador = 1;
        while (contador <= 10)
        {
             Console.WriteLine(contador);
            contador ++;
        }

          /* Solicitar a senha até acertar */
        string senha = "";
        while(senha != "")
        {
            Console.Write("Digite a Senha: ");
            senha = Console.ReadLine();
        }
        Console.WriteLine("Acesso permitido!");
        
        /* ******************************************** */

        int num;
        do
        {
            Console.WriteLine("Digite um Numero Positivo: ");
            num = int.Parse(Console.ReadLine());
        }while(num <=0);


    }
}