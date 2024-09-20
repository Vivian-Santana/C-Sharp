
public class Banda
{
    //instancia de album
    private List<Album> albums = new List<Album>();

    //construtor
    public Banda(string nomeBanda)
    {
        NomeBanda = nomeBanda;
    }


    public string NomeBanda { get; }

    public void AdicionarAbum(Album album)
    {
        albums.Add(album);
    }

    public void ExibirDiscografia()
    {
        Console.Write($"Discografia da banda {NomeBanda}: ");
        foreach (Album album in albums)
        {
            Console.WriteLine($"Album {album.NomeAlbum} ({album.DuracaoTotal:F2})\n");
        }
    }
}

