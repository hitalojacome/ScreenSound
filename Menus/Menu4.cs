using Modelos;

namespace Menus;

internal class Menu4 : Menu
{     
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("*Avaliação de bandas*");

        Console.Write("Informe a banda que deseja avaliar: ");
        string bandaDesejada = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(bandaDesejada))
        {
            Banda banda = bandasRegistradas[bandaDesejada];
            Console.Write($"{bandaDesejada} merece nota: ");
            Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
            banda.AdicionarNota(nota);

            Console.WriteLine($"\nNota {nota.Nota} registrada com sucesso para a banda {bandaDesejada}!");
            Thread.Sleep(3000);
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"\nA banda {bandaDesejada} não foi encontrada em nossa lista.");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}