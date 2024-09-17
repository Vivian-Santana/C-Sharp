class Album
{
    private List<Musica> musicas = new List<Musica>(); //campo
    public string Nome { get; set; }
    public double DuracaoTotal => musicas.Sum(musica => musica.Duracao);// somas a aduração das musicas e retorna na propriedade só de leitura.
    public void addMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do album {Nome}:\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Musica: {musica.Titulo}");
        }
        Console.WriteLine($"Para ouvir esse album inteiro você precisa de {DuracaoTotal:F2} minutos.");
    }
}
