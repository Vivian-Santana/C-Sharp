using Screen_Sound___POO.Modelos;

namespace ScreenSound.Modelos;
internal class Album : IAvaliavel //album impleneta IAvaliavel
{
    private List<Musica> musicas = new List<Musica>(); //campo
    private List<Avaliacao> notas = new();

    //construtor
    public Album(string nomeAlbum)
    {
        NomeAlbum = nomeAlbum;
    }

    public string NomeAlbum { get; }

    public double DuracaoTotal => musicas.Sum(musica => musica.Duracao);// soma a aduração das musicas e retorna na propriedade só de leitura.

    //metodo da interface
    public double Media // retornando a media
    {
        get
        {
            if (notas.Count == 0) return 0;
            else return notas.Average(a => a.Nota);
        }
    }

    public void addMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    //metodo da interface para setar as notas
    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }

   /*
    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do album {NomeAlbum}:\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Musica: {musica.Titulo}");
        }
        Console.WriteLine($"\nPara ouvir esse album inteiro você precisa de {DuracaoTotal:F2} minutos.\n");
    }
   */
}

