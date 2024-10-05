using System.Text.Json;
using System.Text.Json.Serialization;

namespace API_Musica.Moldelos;
//transformando objetos em json (serialização)
//criação de uma lista de músicas favoritas
internal class MusicasFavoritas
{
    //propriedades
    public string? Nome {  get; set; }
    public List<Musica> ListaDeMusicasFavoritas { get; }

    //construtor
    public MusicasFavoritas(string nome)
    {
        Nome = nome;
        ListaDeMusicasFavoritas = new List<Musica>();
    }

    public void AddMusicasFavoritas(Musica musica)
    {
        ListaDeMusicasFavoritas.Add(musica);
    }

    public void ExibirMusicasFavoritas()
    {
        Console.WriteLine($"Essas são as músicas favoritas de {Nome}");
        foreach (var musica in ListaDeMusicasFavoritas)
        {
            Console.WriteLine($"- {musica.Nome} de {musica.Artista}");
        }
        Console.WriteLine("");
    }

    public void GerarArquivoJson()
    {
        string json = JsonSerializer.Serialize(new //obj anônimo (pq não tem tipo)
        {
            nome = Nome,
            musicas = ListaDeMusicasFavoritas

        });
        string nomeArquivo = $"musicas-favoritas-{Nome}.json";
        File.WriteAllText(nomeArquivo, json);
        Console.WriteLine($"O aquivo json foi criado com sucesso! " +
            $"{Path.GetFullPath(nomeArquivo)}");
    }
}
