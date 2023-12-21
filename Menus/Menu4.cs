using Modelos;

namespace Menus;

internal class Menu4 : Menu
{     
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Avaliação de bandas");

        Console.Write("Banda que deseja avaliar: ");
        string nomeBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeBanda))
        {
            Banda banda = bandasRegistradas[nomeBanda];
            Console.Write($"{nomeBanda} merece nota: ");
            Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
            banda.AdicionarNota(nota);

            Console.WriteLine($"\nNota {nota.Nota} registrada para a banda {nomeBanda}!");
            Thread.Sleep(3000);
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeBanda} não foi encontrada em nosso banco de dados.");
            Console.WriteLine("Digite alguma tecla para retornar ao menu.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}