using Modelos;

namespace Menus;

internal class Menu
{
    public virtual void Executar(Dictionary<string, Banda> bandasRegistradas) 
    {
        Console.Clear();
    }
    public void ExibirTituloDaOpcao(string titulo)
    {
        int quantidadeLetras = titulo.Length;
        string asteriscos = string.Empty.PadLeft(quantidadeLetras, '*');
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteriscos + "\n");
    }
}