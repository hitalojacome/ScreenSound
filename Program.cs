//List<string> listaBandas = new() {"U2", "The Beatles", "Recayd Mob"}; // Cria a lista de bandas com 3 bandas já inclusas
Dictionary<string, List<int>> bandasRegistradas = new();
bandasRegistradas.Add("Linkin Park", new List<int> {10, 8, 3});
bandasRegistradas.Add("The Beatles", new List<int>());

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
        case 3: AvaliarBanda();
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
    ExibirTituloDaOpcao("*Registro de bandas*");

    Console.Write("Informe o nome da banda: ");
    string novaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(novaBanda, new List<int>()); // Adiciona a banda como uma nova chave e cria uma lista vazia
    Console.WriteLine($"A banda {novaBanda} foi registrada com sucesso!");

    Thread.Sleep(1500); // Delay de 1,5 milissegundos
    Console.Clear();

    ExibirMenu();
}

void BandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("*Bandas Registradas*");

    foreach(string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nDigite alguma tecla para retornar ao menu.");
    Console.ReadKey();
    Console.Clear();

    ExibirMenu();
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void AvaliarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("*Avaliação de bandas*");

    Console.Write("Informe a banda que deseja avaliar: ");
    string bandaDesejada = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(bandaDesejada))
    {
        Console.Write($"{bandaDesejada} merece nota: ");
        int nota = int.Parse(Console.ReadLine()!);

        bandasRegistradas[bandaDesejada].Add(nota); // Adiciona um valor para a lista da chave
        Console.WriteLine($"\nNota {nota} registrada com sucesso para a banda {bandaDesejada}!");
        Thread.Sleep(3000);
        Console.Clear();
        ExibirMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {bandaDesejada} não foi encontrada em nossa lista.");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();
    }
}

Console.Clear();
ExibirMenu();