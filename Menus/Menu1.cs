using Modelos;

namespace Menus;

internal class Menu1 : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Registro de bandas");

        Console.Write("Nome da banda: ");
        string novaBanda = Console.ReadLine()!;
        Banda banda = new(novaBanda);
        bandasRegistradas.Add(novaBanda, banda);
        Console.WriteLine($"A banda {novaBanda} foi registrada com sucesso!");

        Thread.Sleep(2000);
        Console.Clear();
    }
}