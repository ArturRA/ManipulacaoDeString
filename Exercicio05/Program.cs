namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a frase para realizar as operações:");
            string frase = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Frase em letras maiúsculas:");
            Console.WriteLine(frase.ToUpper() + "\n");

            Console.WriteLine("Frase em letras minuscula:");
            Console.WriteLine(frase.ToLower() + "\n");

            Console.WriteLine("Quantidade de palavras:");
            Console.WriteLine(frase.ToCharArray().Length + "\n");

            Console.WriteLine("Primeira palavra:");
            string[] palavras = frase.Split(" ");
            Console.WriteLine(palavras[0] + "\n");

            Console.WriteLine("Ultima palavra:");
            Console.WriteLine(palavras[palavras.Length - 1] + "\n");

            Console.ReadKey();
        }
    }
}