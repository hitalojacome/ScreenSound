namespace Modelos;

internal class Banda : IAvaliavel
{
    public string Nome { get; }
    private List<Album> _albuns = new();
    private List<Avaliacao> _notas = new();
    public double Media
    {
        get
        {
            if (_notas.Count ==0) return 0;
            else return _notas.Average(a => a.Nota);
        }
    }
    public IEnumerable<Album> Albuns => _albuns;
    
    public Banda(string nome)
    {
        Nome = nome;
    }

    public void AdicionarAlbum(Album album) 
    { 
        _albuns.Add(album);
    }

    public void AdicionarNota(Avaliacao nota)
    {
        _notas.Add(nota);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach (Album album in _albuns)
        {
            Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})");
        }
    }
}