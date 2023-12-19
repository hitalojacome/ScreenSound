using Menus;
using Modelos;

internal class Program
{
    private static void Main(string[] args)
    {
        Banda LinkinPark = new("Linkin Park");
        LinkinPark.AdicionarNota(new Avaliacao(10));
        LinkinPark.AdicionarNota(new Avaliacao(8));
        LinkinPark.AdicionarNota(new Avaliacao(3));

        Banda Beatles = new("The Beatles");
        Beatles.AdicionarNota(new Avaliacao(10));
        Beatles.AdicionarNota(new Avaliacao(7));
        Beatles.AdicionarNota(new Avaliacao(9));

        Banda Ira = new("Ira");
        Ira.AdicionarNota(new Avaliacao(4));
        Ira.AdicionarNota(new Avaliacao(7));
        Ira.AdicionarNota(new Avaliacao(9));

        Dictionary<string, Banda> bandasRegistradas = new()
        {
            { LinkinPark.Nome, LinkinPark},
            { Beatles.Nome, Beatles},
            { Ira.Nome, Ira}
        };

        void ExibirLogo() // Função para exibir o logo do projeto
        {
            Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
        }

        void ExibirTituloDaOpcao(string titulo) // Responsável por exibir os titulos de cada opção
        {
            int quantidadeLetras = titulo.Length;
            string asteriscos = string.Empty.PadLeft(quantidadeLetras, '*');
            Console.WriteLine(asteriscos);
            Console.WriteLine(titulo);
            Console.WriteLine(asteriscos + "\n");
        }

        void ExibirMenu() // Exibe o menu de interação
        {
            ExibirLogo();
            Console.WriteLine("\nDigite 1 para registrar uma banda;");
            Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
            Console.WriteLine("Digite 3 para exibir as bandas registradas;");
            Console.WriteLine("Digite 4 para avaliar uma banda;");
            Console.WriteLine("Digite 5 para exibir a média de uma banda;");
            Console.WriteLine("Digite -1 para sair do menu.");

            Console.Write("\nDigite uma opção: ");
            int opcaoEscolhida = int.Parse(Console.ReadLine()!);

            switch (opcaoEscolhida)
            {
                case 1:
                    Menu1 menu1 = new();
                    menu1.Executar(bandasRegistradas);
                    ExibirMenu();
                    break;
                case 2:
                    Menu2 menu2 = new();
                    menu2.Executar(bandasRegistradas);
                    ExibirMenu();
                    break;
                case 3:
                    Menu3 menu3 = new();
                    menu3.Executar(bandasRegistradas);
                    ExibirMenu();
                    break;
                case 4:
                    Menu4 menu4 = new();
                    menu4.Executar(bandasRegistradas);
                    ExibirMenu();
                    break;
                case 5:
                    Menu5 menu5 = new();
                    menu5.Executar(bandasRegistradas);
                    ExibirMenu();
                    break;
                case -1:
                    Console.WriteLine("Obrigado por usar o Screen Sound!");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }

        Console.Clear();
        ExibirMenu();
    }
}