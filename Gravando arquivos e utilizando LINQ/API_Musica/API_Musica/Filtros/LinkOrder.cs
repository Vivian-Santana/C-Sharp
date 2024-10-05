using API_Musica.Moldelos;

namespace API_Musica.Filtros;

internal class LinkOrder
{
    public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas)
    {
        var artistasOrdenados = musicas.OrderBy(musica => musica.Artista)//OrderBy ordena tds as musicas pela propriedade Artista
            .Select(musica => musica.Artista).Distinct().ToList(); //Select seleciona o artista. Distinct tira o artista q estiver em + de uma musica.
        Console.WriteLine("Lista de artistas ordenados:");

        foreach (var artista in artistasOrdenados)
        {
            Console.WriteLine($"- {artista}");
        }
    }
}
