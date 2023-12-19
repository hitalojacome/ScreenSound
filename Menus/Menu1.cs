using Modelos;

namespace Menus
{
    internal class Menu1 : Menu
    {
        public void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            Console.Clear();
            ExibirTituloDaOpcao("*Registro de bandas*");

            Console.Write("Informe o nome da banda: ");
            string novaBanda = Console.ReadLine()!;
            Banda banda = new(novaBanda);
            bandasRegistradas.Add(novaBanda, banda);
            Console.WriteLine($"A banda {novaBanda} foi registrada com sucesso!");

            Thread.Sleep(2000);
            Console.Clear();
        }
    }
}