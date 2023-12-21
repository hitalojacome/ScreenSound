namespace Modelos;

internal class Album : IAvaliavel
{
    public string Nome { get; }
    protected static int Contador = 0;
    private List<Musica> _musicas = new();
    private List<Avaliacao> _notas = new();
    public List<Musica> Musicas => _musicas;
    public int DuracaoTotal => _musicas.Sum(m => m.Duracao);
    public double Media
    {
        get
        {
            if (_notas.Count ==0) return 0;
            else return _notas.Average(a => a.Nota);
        }
    }

    public Album(string nome)
    {
        Nome = nome;
        Contador++;
    }

    public void AdicionarMusica(Musica musica)
    {
        _musicas.Add(musica);
    }

    public void AdicionarNota(Avaliacao nota)
    {
        _notas.Add(nota);
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