using Modelos;

namespace Menus
{
    internal class Menu3 : Menu
    {
        public void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            Console.Clear();
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
}