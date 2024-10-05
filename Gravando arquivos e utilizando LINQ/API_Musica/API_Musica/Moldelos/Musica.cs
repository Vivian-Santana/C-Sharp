using System.Text.Json.Serialization;

namespace API_Musica.Moldelos;
//consumindo API de música
internal class Musica
{
    private string[] tonalidades = {"C", "C#", "D", "Eb", "E","F", "F#", "G", "Ab", "A", "Bb", "B"};
    //propriedades
    [JsonPropertyName("song")] //a propriendade nome é apontada para o campo song do json (um atributo q representa um metadado específico para a proriedade nome)
    public string? Nome { get; set; } //na API o nome da musica é song.

    [JsonPropertyName("artist")] //isso equivale a anotação no java
    public string? Artista { get; set; }
    
    [JsonPropertyName("duration_ms")]
    public int Duracao {  get; set; }

    [JsonPropertyName("genre")]
    public string? Genero {  get; set; }

    [JsonPropertyName("year")] //na API ano é uma string
    public string? AnoString {  get; set; }

    //prop para pegar a tonalidade musical
    [JsonPropertyName("key")]
    public int Key { get; set; }

    //prop para converter a key do tipo inteiro em uma tonalidade tipo string
    public string Tonalidade {
        get
        {
            return tonalidades[Key];
        }
    }

    //converção de AnoString para o tipo int
    public int Ano
    {
        get
        {
            return int.Parse(AnoString!);
        }
    }
    /*
     *  é comum receber os dados de uma API em um tipo específico e, durante a manipulação desses dados, 
     *  realizar conversões para outros tipos, conforme necessário, para atender às necessidades da aplicação.
     */

    public void ExibirDetalhesMusica()
    {
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Musica: {Nome}");
        Console.WriteLine($"Duração: {Duracao/1000}"); //duração em segundos
        Console.WriteLine($"Gênero musical: {Genero}");
        Console.WriteLine($"Tonalidade musical: {Tonalidade}");//tirei a key entre chaves para mostrar a tonalidade ao invés do numero.
    }

}
