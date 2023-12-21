namespace Modelos;

internal class Musica : IAvaliavel
{
    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    private List<Avaliacao> _notas = new();
    public string DescricaoResumida => $"A música {Nome} pertence à banda {Artista}";
    public double Media
    {
        get
        {
            if (_notas.Count ==0) return 0;
            else return _notas.Average(a => a.Nota);
        }
    }

    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public void AdicionarNota(Avaliacao nota)
    {
        _notas.Add(nota);
    }
    
    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano.");
        } else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
    }
}