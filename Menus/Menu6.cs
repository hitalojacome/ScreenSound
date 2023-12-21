using Modelos;

namespace Menus;

internal class Menu6 : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Detalhes da Bandas");

        Console.Write("Banda: ");
        string nomeBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeBanda))
        {
            Banda banda = bandasRegistradas[nomeBanda];
            Console.WriteLine(banda.Resumo);
            Console.WriteLine($"\n{nomeBanda} tem média {banda.Media:F1}.");

            Console.WriteLine("\nDiscografia:");
            foreach (Album album in banda.Albuns)
            {
                Console.WriteLine($"{album.Nome} média {album.Media:F1}.");
            }
            
            Console.WriteLine("\nDigite alguma tecla para retornar ao menu.");
            Console.ReadKey();
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