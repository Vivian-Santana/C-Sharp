using System.Text.Json.Serialization;

namespace API_Musica.Moldelos;
//consumindo API de música
internal class Musica
{
    [JsonPropertyName("song")] //a propriendade nome é apontada para o campo song do json (um atributo q representa um metadado específico para a proriedade nome)
    public string? Nome { get; set; } //na API o nome da musica é song.

    [JsonPropertyName("artist")] //isso equivale a anotação no java
    public string? Artista { get; set; }
    
    [JsonPropertyName("duration_ms")]
    public int Duracao {  get; set; }

    [JsonPropertyName("genre")]
    public string? Genero {  get; set; }

    public void ExibirDetalhesMusica()
    {
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Musica: {Nome}");
        Console.WriteLine($"Duração: {Duracao/1000}"); //duração em segundos
        Console.WriteLine($"Gênero musical: {Genero}");
    }

}
