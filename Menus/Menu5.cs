using Modelos;

namespace Menus;

internal class Menu5 : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Avaliação de álbuns");

        Console.Write("O álbum pertence a banda: ");
        string nomeBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeBanda))
        {
            Banda banda = bandasRegistradas[nomeBanda];
            Console.Write("Agora, informe o nome do álbum: ");
            string nomeAlbum = Console.ReadLine()!;
            if (banda.Albuns.Any(album => album.Nome.Equals(nomeAlbum)))
            {
                Album album = banda.Albuns.First(album => album.Nome.Equals(nomeAlbum));
                Console.Write($"\n{nomeAlbum} merece nota: ");
                Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
                album.AdicionarNota(nota);
                
                Console.WriteLine($"\nNota {nota.Nota} registrada para o álbum {nomeAlbum} de {nomeBanda}!");
                Thread.Sleep(3000);
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"\nO álbum {nomeAlbum} não foi encontrado em nosso banco de dados.");
                Console.WriteLine("Digite alguma tecla para retornar ao menu.");
                Console.ReadKey();
                Console.Clear();
            }
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeBanda} não foi encontrada em nosso banco de dados.");
            Console.WriteLine("Digite alguma tecla para retornar ao menu.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}