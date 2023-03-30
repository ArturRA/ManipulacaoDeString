namespace Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Leitura do arquivo de municipios
            
            string csv = File.ReadAllText(@"C:\Users\fenis\source\repos\Academia\ManipulacaoDeString\Exercicio06\Cidades.csv");
            string[] lista = csv.Split("\n");

            // tem que pular a primeira linha do arquivo porque ela é os tipos 
            string[] posicao = new string[lista.Length - 1];
            string[] codigo = new string[lista.Length - 1];
            string[] municipio = new string[lista.Length - 1];
            string[] unidadeFederativa = new string[lista.Length - 1];
            string[] populacao = new string[lista.Length - 1];

            for (int i = 1; i < lista.Length; i++)
            {
                string[] temp = lista[i].Split(";");

                posicao[i - 1] = temp[0];
                codigo[i - 1] = temp[1];
                municipio[i - 1]  = temp[2];
                unidadeFederativa[i - 1]  = temp[3];
                populacao[i - 1]  = temp[4];
            }

            Console.WriteLine("O que voce deseja fazer:\n"
                            + "1. Apresentar as cidades agrupadas pela primeira letra.\n"
                            + "2. Apresentar as cidades agrupadas pelo estado.");
            string opcao = Console.ReadLine();
            if(opcao == "1")
            {
                for(int letraDoGrupo = 65; letraDoGrupo <= 90; letraDoGrupo++)
                {
                    int quantidadeDeElementosDoGrupo = 0;

                    foreach (string cidade in municipio)
                    {
                        if (Convert.ToChar(letraDoGrupo) == cidade[0])
                            quantidadeDeElementosDoGrupo++;
                    }
                    string[] cidadesDoGrupo = new string[quantidadeDeElementosDoGrupo];

                    int contador = 0;
                    for (int i = 0; i < municipio.Length; i++)
                    {
                        if (Convert.ToChar(letraDoGrupo) == municipio[i][0])
                        {
                            cidadesDoGrupo[contador] = $"{posicao[i]}; {codigo[i]}; {municipio[i]}; {unidadeFederativa[i]}; {populacao[i]}";
                            contador++;
                        }
                    }

                    string cidadesDoGrupoParaImprimir = string.Join("\n", cidadesDoGrupo);
                    Console.WriteLine($"As cidades que começam com {Convert.ToChar(letraDoGrupo)} são:\n"
                                    + $"{cidadesDoGrupoParaImprimir}");
                }
            }
            else if(opcao == "2")
            {
                string[] estados = new string[] { "Acre", "Alagoas", "Amapá", "Amazonas", "Bahia",
                                                  "Ceará", "Espírito Santo", "Goiás", "Maranhão", "Mato Grosso",
                                                  "Mato Grosso do Sul", "Minas Gerais", "Pará", "Paraíba",
                                                  "Paraná", "Pernambuco", "Piauí", "Rio de Janeiro",
                                                  "Rio Grande do Norte", "Rio Grande do Sul", "Rondônia",
                                                  "Roraima", "Santa Catarina", "São Paulo", "Sergipe",
                                                  "Tocantins", "Distrito Federal"};
                
                foreach(string estadoParaComparar in estados)
                {
                    int quantidadeDeElementosDoGrupo = 0;
                    foreach (string elemento in unidadeFederativa)
                    {
                        if (String.Equals(estadoParaComparar.ToLower().Trim(), elemento.ToLower().Trim(), StringComparison.OrdinalIgnoreCase))
                        {
                            quantidadeDeElementosDoGrupo++;
                        }
                    }
                    string[] cidadesDoGrupo = new string[quantidadeDeElementosDoGrupo];

                    int contador = 0;
                    for (int j = 0; j < municipio.Length; j++)
                    {
                        if (String.Equals(estadoParaComparar.ToLower().Trim(), unidadeFederativa[j].ToLower().Trim(), StringComparison.OrdinalIgnoreCase))
                        {
                            cidadesDoGrupo[contador] = $"{posicao[j]}; {codigo[j]}; {municipio[j]}; {unidadeFederativa[j]}; {populacao[j]}";
                            contador++;
                        }
                    }
                    string cidadesDoGrupoParaImprimir = string.Join("\n", cidadesDoGrupo);
                    Console.WriteLine($"\nAs cidades que são do estado {estadoParaComparar} são:\n"
                                    + $"{cidadesDoGrupoParaImprimir}");
                }
            }

            Console.ReadKey();
        }
    }
}