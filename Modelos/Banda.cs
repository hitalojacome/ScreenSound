namespace Modelos;

internal class Banda
{
    public string Nome { get; }
    public double Media => _notas.Average();
    public List<Album> Albuns => _albuns;
    private List<Album> _albuns = new();
    private List<int> _notas = new();
    
    public Banda(string nome)
    {
        Nome = nome;
    }

    public void AdicionarAlbum(Album album) 
    { 
        _albuns.Add(album);
    }

    public void AdicionarNota(int nota)
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