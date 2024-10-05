using API_Musica.Moldelos;
using System.Text.Json;
using API_Musica.Filtros;

using (HttpClient client = new HttpClient()) //"using" gerencia um recurso, ao fechar da } o recurso é liberado.
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json"); //async indica que o método é assíncrono
        /*
         * O await é usado para indicar que a operação assíncrona deve ser aguardada.
         * Ela permite que a execução do código seja pausada até que a operação seja concluída, 
         * sem bloquear a thread principal.
         */
        //Console.WriteLine(resposta); //traz tudo em formato json
        //Desserialização dos dados
        // variável pega a resposta em json e cria uma lista baseada no objeto. - converte o jason em um obj manipulavel no C# - isso é desserialização dos dados.
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!; //a desserialização é uma lista de musicas guardadas em resposta
        //Console.WriteLine("Filtrando generos musicais:");
        /*
         * Link é uma bilbioteca do .NET usada pra separar os dadose separar 
         * de onde pega os dados e separa em métodos para poder coloca-los em listas
         */

        LinqFilter.FiltrarGenerosMusicais(musicas);
        LinkOrder.ExibirListaDeArtistasOrdenados(musicas);
        LinqFilter.FiltrarArtistaPorGeneroMusical(musicas, "pop");
        LinqFilter.FiltrarMusicasDeArtista(musicas, "Michael Jackson" + "\n");
        LinqFilter.FiltrarMusicasPeloAno(musicas, 2012);
        LinqFilter.FiltrarMusicasPelaTonalidade(musicas, "C#");

        var musicasFavoritas = new MusicasFavoritas("Vivian");
        musicasFavoritas.AddMusicasFavoritas(musicas[1]);
        musicasFavoritas.AddMusicasFavoritas(musicas[377]);
        musicasFavoritas.AddMusicasFavoritas(musicas[4]);
        musicasFavoritas.AddMusicasFavoritas(musicas[6]);
        musicasFavoritas.AddMusicasFavoritas(musicas[1467]);
        
        musicasFavoritas.ExibirMusicasFavoritas();

        musicasFavoritas.GerarArquivoJson(); //invoca metodo para criar o arquivo e serializar os dados.

        Console.WriteLine($"Quantidade de musicas: " + musicas.Count + "\n"); //mostra a quantidade de musicas da API
        
        musicas[1].ExibirDetalhesMusica(); //1 musica
        Console.WriteLine("\n");
        musicas[1998].ExibirDetalhesMusica(); //ultima musica
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Página Não encontrada!{ex.Message}");
    }
}
