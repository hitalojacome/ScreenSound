using Modelos;

namespace Menus;

internal class MenuSair : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.WriteLine("\nObrigado por usar o Screen Sound!");
    }
}