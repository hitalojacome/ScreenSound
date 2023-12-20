using Modelos;

namespace Menus;

internal class Menu5 : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
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
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeBanda} não foi encontrada em nossa lista.");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}