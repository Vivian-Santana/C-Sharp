using API_Musica.Moldelos;

namespace API_Musica.Filtros;

internal class LinkOrder
{
    public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas)
    {
        var artistasOrdenados = musicas.OrderBy(musica => musica.Artista)//OrderBy ordena tds as musicas pela propriedade Artista
            .Select(musica => musica.Artista) //Select seleciona o artista.
            .Distinct()//Distinct tira o artista q estiver em + de uma musica.
            .ToList();  //coloca tudo em uma lista
        Console.WriteLine("Lista de artistas ordenados:");

        foreach (var artista in artistasOrdenados)
        {
            Console.WriteLine($"- {artista}");
        }
    }
}
