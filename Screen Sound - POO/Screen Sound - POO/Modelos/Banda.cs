namespace ScreenSound.Modelos;
internal class Banda
{
    //instancia de album
    private List<Album> albuns = new List<Album>();
    private List<Avaliacao> notas = new List<Avaliacao>(); //notas das bandas mudei de tipo int para Avaliação apos criar a classe

    //Propriedade apenas para leitura (não permite modificação direta)
    public List<Avaliacao> Notas
    {
        get { return notas; }
    }

    //construtor
    public Banda(string nomeBanda)
    {
        NomeBanda = nomeBanda;
    }

    public string NomeBanda { get; }
    public double Media
    {
        get  //tratamento caso as notas forem menores ou = a 0
        {
            if (notas.Count <= 0)return 0;
            else return notas.Average(a => a.Nota); //lambda: para cada avaliação "a" usa a propriedade nota
        }
    }

    public List<Album> Albuns => albuns;

    public void AdicionarAbum(Album album)
    {
        albuns.Add(album);
    }

    public void AdicionarNota(Avaliacao nota)
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

