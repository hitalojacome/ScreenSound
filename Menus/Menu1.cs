using OpenAI_API;
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

        var client = new OpenAIAPI("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"); // Cria a variável com a chave de api da openAI

        var chat = client.Chat.CreateConversation(); // Cria a interação de conversa

        chat.AppendSystemMessage($"Resuma a banda {novaBanda} em 1 parágrafo. Adote um estilo informal.");
        string resposta = chat.GetResponseFromChatbotAsync().GetAwaiter().GetResult();
        banda.Resumo = resposta;

        Console.WriteLine($"A banda {novaBanda} foi registrada com sucesso!");
        Console.WriteLine("Digite alguma tecla para retornar ao menu.");
        Console.ReadKey();
        Console.Clear();
    }
}