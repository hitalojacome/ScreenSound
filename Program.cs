List<string> listaBandas = new() {"U2", "The Beatles", "Recayd Mob"}; // Cria a lista de bandas

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
    Console.WriteLine("Digite 2 para mostrar as bandas registradas;");
    Console.WriteLine("Digite 3 para avaliar uma banda;");
    Console.WriteLine("Digite 4 para exibir a média de uma banda;");
    Console.WriteLine("Digite -1 para sair do menu.");

    Console.Write("\nDigite uma opção: ");
    int opcaoEscolhida = int.Parse(Console.ReadLine()!);

    switch (opcaoEscolhida)
    {
        case 1: RegistrarBandas();
            break;
        case 2: BandasRegistradas();
            break;
        case 3:
            Console.WriteLine("Avaliação de bandas");
            Console.Write("Digite uma nota: ");
            int nota = int.Parse(Console.ReadLine()!);
            break;
        case 4:
            Console.WriteLine("Média de avaliações");
            Console.WriteLine("5 ESTRELAS!!!!");
            break;
        case -1:
            Console.WriteLine("Falouuuu!");
            break;
        default: Console.WriteLine("Opção inválida");
            break;
    }
}

void RegistrarBandas() // Registra uma banda (opção 1 do menu)
{
    Console.Clear();
    Console.WriteLine("********************");
    Console.WriteLine("*Registro de bandas*");
    Console.WriteLine("********************");

    Console.Write("\nInforme o nome da banda: ");
    string novaBanda = Console.ReadLine()!;
    listaBandas.Add(novaBanda); // Adiciona uma banda a lista
    Console.WriteLine($"A banda {novaBanda} foi registrada com sucesso!");

    Thread.Sleep(1500); // Delay de 1,5 milissegundos
    Console.Clear();

    ExibirMenu();
}

void BandasRegistradas()
{
    Console.Clear();
    Console.WriteLine("********************");
    Console.WriteLine("*Bandas registradas*");
    Console.WriteLine("********************\n");

    foreach(string banda in listaBandas)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nDigite alguma tecla para retornar ao menu.");
    Console.ReadKey();
    Console.Clear();

    ExibirMenu();
}

Console.Clear();
ExibirMenu();