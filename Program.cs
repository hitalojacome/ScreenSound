using Modelos;

Banda LinkinPark = new("Linkin Park");
LinkinPark.AdicionarNota(10);
LinkinPark.AdicionarNota(8);
LinkinPark.AdicionarNota(3);

Banda Beatles = new("The Beatles");
Beatles.AdicionarNota(10);
Beatles.AdicionarNota(7);
Beatles.AdicionarNota(9);

Banda Ira = new("Ira");
Ira.AdicionarNota(4);
Ira.AdicionarNota(7);
Ira.AdicionarNota(9);

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
        case 1: RegistrarBanda();
            break;
        case 2: RegistrarAlbum();
            break;
        case 3: BandasRegistradas();
            break;
        case 4: AvaliarBanda();
            break;
        case 5: ExibirAvaliacao();
            break;
        case -1: Console.WriteLine("Obrigado por usar o Screen Sound!");
            break;
        default: Console.WriteLine("Opção inválida");
            break;
    }
}

void RegistrarAlbum()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro de álbuns");
    Console.Write("Digite a banda cujo álbum deseja registrar: ");
    string nomeBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeBanda))
    {    
        Console.Write("Agora informe o título do álbum: ");
        string tituloAlbum = Console.ReadLine()!;
        Banda banda = bandasRegistradas[nomeBanda];
        banda.AdicionarAlbum(new Album(tituloAlbum));

        Console.WriteLine($"O álbum {tituloAlbum} de {nomeBanda} foi registrado com sucesso!");
        Thread.Sleep(2000);
        Console.Clear();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeBanda} não foi encontrada em nossa lista.");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
    ExibirMenu();
}

void RegistrarBanda() // Registra uma banda (opção 1)
{
    Console.Clear();
    ExibirTituloDaOpcao("*Registro de bandas*");

    Console.Write("Informe o nome da banda: ");
    string novaBanda = Console.ReadLine()!;
    Banda banda = new(novaBanda);
    bandasRegistradas.Add(novaBanda, banda);
    Console.WriteLine($"A banda {novaBanda} foi registrada com sucesso!");

    Thread.Sleep(2000); // Delay de 1,5 milissegundos
    Console.Clear();

    ExibirMenu();
}

void BandasRegistradas() // Exibe as bandas registradas (opção 2)
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

void AvaliarBanda() // Avalia uma banda (opção 3)
{
    Console.Clear();
    ExibirTituloDaOpcao("*Avaliação de bandas*");

    Console.Write("Informe a banda que deseja avaliar: ");
    string bandaDesejada = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(bandaDesejada))
    {
        Banda banda = bandasRegistradas[bandaDesejada];
        Console.Write($"{bandaDesejada} merece nota: ");
        int nota = int.Parse(Console.ReadLine()!);
        banda.AdicionarNota(nota);

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

void ExibirAvaliacao() // Mostra a nota da banda (opção 4)
{
    Console.Clear();
    ExibirTituloDaOpcao("*Nota das Bandas*");

    Console.Write("Qual banda deseja saber a nota? ");
    string nomeBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeBanda))
    {
        Banda banda = bandasRegistradas[nomeBanda];
        Console.WriteLine($"\n{nomeBanda} tem média {banda.Media:F2}.");
        /*
        ESPAÇO RESERVADO PARA COMPLETAR A FUNÇÃO
        */
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeBanda} não foi encontrada em nossa lista.");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();
    }
}

Console.Clear();
ExibirMenu();