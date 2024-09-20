public class Podcast
{
    //Lista de episódios
    private List<Episodio> episodios = new List<Episodio>();
    public Podcast(string nomePodcast, string host)
    {
        NomePodcast = nomePodcast;
        Host = host;
    }

    public string NomePodcast { get;}
    public string Host { get; }
    public int TotalEpisodios => episodios.Count;
    public Episodio Episodios { get; set; }

    //métodos
    public void addEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }
    

    public void exibirDetalhes()
    {
        //mostrar lista de episódios ordenandos por sequencia e o total de episodios.
        Console.WriteLine($"Padcast {NomePodcast}, apresentado por {Host}.\n");
        foreach(Episodio episodio in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(episodio.Resumo);
        }
        Console.WriteLine($"\nEste podcast possui {TotalEpisodios} episódios.");
    }
}
