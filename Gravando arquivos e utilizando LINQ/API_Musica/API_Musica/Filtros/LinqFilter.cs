using API_Musica.Moldelos;
namespace API_Musica.Filtros;

internal class LinqFilter
{
    public static void FiltrarGenerosMusicais(List<Musica> musicas)
    {
        var GenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach (var genero in GenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistaPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistasPorGenMusical = musicas.Where(musica => musica.Genero!.Contains(genero))
            .Select(musica => musica.Artista).Distinct().ToList();

        Console.WriteLine($"Exibindo os artistas por gênero musical >>> {genero}");
        foreach (var artista in artistasPorGenMusical)
        {
            Console.WriteLine($"- {artista}");
        }
    }

    public static void FiltrarMusicasDeArtista(List<Musica> musicas, string nomeArtista)
    {
        var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(nomeArtista)).ToList();
        Console.WriteLine($"Artista: {nomeArtista}");
        foreach (var musica in musicasDoArtista)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }

    public static void FiltrarMusicasPeloAno(List<Musica> musicas, int ano)
    {
        var musicasDoAno = musicas.Where(musica => musica.Ano == ano)
            .OrderBy(musicas => musicas.Nome) // ordena as músicas pelo nome
            .Select(musicas => musicas.Nome) // seleciona apenas o nome das músicas
            .Distinct() // remove as duplicidades
            .ToList(); // converte o resultado em uma lista

        Console.WriteLine($"Músicas de {"AnoString"}");
        foreach (var musica in musicasDoAno)
        {
            Console.WriteLine($"- {musica}");
        }
    }

    public static void FiltrarMusicasPelaTonalidade(List<Musica> musicas, string tonalidade)
    {
        //var é uma lista de strings
        var musicasComATonalidade = musicas.Where(musica => musica.Tonalidade!.Equals("C#"))
        .Select(musicas => musicas.Nome)
        .ToList();

        Console.WriteLine($"Musicas com a tonalidade C#:");
        foreach (var musica in musicasComATonalidade)
        {
            Console.WriteLine($"- {musica}");
        }
    }
}
