using Modelos;

namespace Menus;

internal class Menu3 : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("*Bandas Registradas*");

        foreach (string banda in bandasRegistradas.Keys)
        {
            Console.WriteLine($"Banda: {banda}");
        }

        Console.WriteLine("\nDigite alguma tecla para retornar ao menu.");
        Console.ReadKey();
        Console.Clear();
    }
}