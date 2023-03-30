namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a frase para transformar no formato Title Case:");
            string frase = Console.ReadLine();
            frase = frase.ToLower();

            string[] palavras = frase.Split(" ");

            for(int i = 0; i < palavras.Length; i++)
            {
                palavras[i] = char.ToUpper(palavras[i][0]) + palavras[i].Substring(1);
            }

            string fraseTitleCase = string.Join(" ", palavras);

            Console.WriteLine(fraseTitleCase);

            Console.ReadLine();

        }
    }
}