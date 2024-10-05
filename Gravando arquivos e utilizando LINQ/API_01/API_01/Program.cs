/*
using(HttpClient client = new HttpClient()) //using gerência um recurso ao fechar da } o recurso é liberado.
{
    try
    {
        //API de musicas
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json"); //async indica que´o métodoé asíncrono
        Console.WriteLine(resposta);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Página Não encontrada!{ex.Message}");
    }
}
*/

using API_01.Models;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string json = await client.GetStringAsync("https://anapioficeandfire.com/api/characters/16");
        //Console.WriteLine(json);
        Personagem margaery = JsonSerializer.Deserialize<Personagem>(json)!; //desserialização usando a classe personagem

        margaery.ExibirApelidosPersonagem();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Not found! {ex.Message}");
    }

}
