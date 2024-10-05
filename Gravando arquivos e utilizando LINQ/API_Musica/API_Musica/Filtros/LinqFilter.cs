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
}
