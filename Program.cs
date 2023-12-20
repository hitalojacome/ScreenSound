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

        Dictionary<int, Menu> opcoes = new()
        {
            {1, new Menu1()},
            {2, new Menu2()},
            {3, new Menu3()},
            {4, new Menu4()},
            {5, new Menu5()},
            {-1, new MenuSair()}
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
            
            if (opcoes.ContainsKey(opcaoEscolhida))
            {
                Menu exibirMenu = opcoes[opcaoEscolhida];
                exibirMenu.Executar(bandasRegistradas);
                if (opcaoEscolhida > 0) ExibirMenu();
            }
            else
            {
                Console.WriteLine("\nOpção inválida!!");
                Console.WriteLine("Você deve digitar uma opção existente no menu!");
                Thread.Sleep(2000);
                Console.Clear();
                ExibirMenu();
            }
        }
        Console.Clear();
        ExibirMenu();
    }
}