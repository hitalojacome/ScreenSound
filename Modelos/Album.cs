namespace Modelos;

internal class Album : IAvaliavel
{
    public string Nome { get; }
    public int DuracaoTotal => _musicas.Sum(m => m.Duracao);
    public List<Musica> Musicas => _musicas;
    private List<Musica> _musicas = new();
    protected static int Contador = 0;

    public Album(string nome)
    {
        Nome = nome;
        Contador++;
    }
    public void AdicionarMusica(Musica musica)
    {
        _musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum {Nome}:\n");
        foreach (var musica in _musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }
        Console.WriteLine($"\nPara ouvir este álbum inteiro você precisa de {DuracaoTotal}");
    }
}