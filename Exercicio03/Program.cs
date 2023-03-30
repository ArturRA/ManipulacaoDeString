namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fraseEncriptada = "";

            Console.WriteLine("Digite a frase para transformar com a cifra de César:");
            string frase = Console.ReadLine().ToLower();

            for (int i = 0; i < frase.Length; i++)
            {
                int ASCII = (int)frase[i];
                int ASCIIC = ASCII + 2;
                fraseEncriptada += Char.ConvertFromUtf32(ASCIIC);

            }

            Console.Write("Resultado: " + fraseEncriptada);

            Console.ReadLine();
        }
    }
}