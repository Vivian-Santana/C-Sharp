namespace ScreenSound.Modelos;
public class Banda
{
    //instancia de album
    private List<Album> albuns = new List<Album>();
    private List<int> notas = new List<int>(); //notas das bandas

    public List<int> Notas
    {
        get { return notas; }
    }

    //construtor
    public Banda(string nomeBanda)
    {
        NomeBanda = nomeBanda;
    }

    public string NomeBanda { get; }
    public double Media => notas.Average();

    public List<Album> Albuns => albuns;

    public void AdicionarAbum(Album album)
    {
        albuns.Add(album);
    }

    public void AdicionarNota(int nota)
    {
        notas.Add(nota);
    }

    public void ExibirDiscografia()
    {
        Console.Write($"Discografia da banda {NomeBanda}: ");
        foreach (Album album in albuns)
        {
            Console.WriteLine($"Album {album.NomeAlbum} ({album.DuracaoTotal:F2})\n");
        }
    }
}

