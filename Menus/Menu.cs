namespace Menus
{
    public class Menu
    {
        public void ExibirTituloDaOpcao(string titulo)
        {
            int quantidadeLetras = titulo.Length;
            string asteriscos = string.Empty.PadLeft(quantidadeLetras, '*');
            Console.WriteLine(asteriscos);
            Console.WriteLine(titulo);
            Console.WriteLine(asteriscos + "\n");
        }
    }
}