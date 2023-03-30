namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a frase para contar o numero de palavras:");
            string frase = Console.ReadLine();
            string[] palavras = frase.Split(" ");

            Console.WriteLine($"O numero de palaras é: {palavras.Length}");

            Console.ReadLine();
        }
    }
}