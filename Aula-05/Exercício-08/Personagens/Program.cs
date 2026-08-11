internal class Program
{
    private static void Main(string[] args)
    {
        // Primeiro Personagem
        Personagem personagem1 = new Personagem("Mago", 5, 350, 20, 50, 80);

        // Segundo Personagem
        Personagem personagem2 = new Personagem("Elfo", 5, 350, 45, 30, 100);

        // Terceiro Personagem
        Personagem personagem3 = new Personagem("Cavaleiro", 5, 350, 25, 20, 130);


        Console.WriteLine("PERSONAGENS");

        // Primeiro Personagem (Mago)
        Console.WriteLine("\nPersonagem1");
        Console.WriteLine($"Nome: {personagem1.Nome}");
        Console.WriteLine($"Nível: {personagem1.Nível}");
        Console.WriteLine($"Experiencia: {personagem1.Experiencia}");
        Console.WriteLine($"Agilidade: {personagem1.Agilidade}");
        Console.WriteLine($"Inteligencia: {personagem1.Inteligencia}");
        Console.WriteLine($"Vida: {personagem1.Vida}");

        // Segundo Personagem (Elfo)
        Console.WriteLine("\nPersonagem2");
        Console.WriteLine($"Nome: {personagem2.Nome}");
        Console.WriteLine($"Nível: {personagem2.Nível}");
        Console.WriteLine($"Experiencia: {personagem2.Experiencia}");
        Console.WriteLine($"Agilidade: {personagem2.Agilidade}");
        Console.WriteLine($"Inteligencia: {personagem2.Inteligencia}");
        Console.WriteLine($"Vida: {personagem2.Vida}");

        // Terceiro Personagem (Cavaleiro)
        Console.WriteLine("\nPersonagem3");
        Console.WriteLine($"Nome: {personagem3.Nome}");
        Console.WriteLine($"Nível: {personagem3.Nível}");
        Console.WriteLine($"Experiencia: {personagem3.Experiencia}");
        Console.WriteLine($"Agilidade: {personagem3.Agilidade}");
        Console.WriteLine($"Inteligencia: {personagem3.Inteligencia}");
        Console.WriteLine($"Vida: {personagem3.Vida}");
    }

    public class Personagem
    {
        public string Nome { get; private set; }
        public int Nível { get; private set; }
        public int Experiencia { get; private set; }
        public int Agilidade { get; private set; }
        public int Inteligencia { get; private set; }
        public int Vida { get; private set; }


        public Personagem(string nome, int nivel, int experiencia, int agilidade, int inteligencia, int vida)
        {
            Nome = nome;
            Nível = nivel;
            Experiencia = experiencia;
            Agilidade = agilidade;
            Inteligencia = inteligencia;
            Vida = vida;
        }
    }
}