namespace API_01.Models;

//classe usa as informações da API: personagem e apelidos
internal class Personagem
{
    public string name { get; set; }//desserialização
    public List<string>? aliases { get; set; }//desserialização

    public void ExibirApelidosPersonagem()
    {
        Console.WriteLine($"Nome: {name}");
        Console.WriteLine($"Apelidos: ");
        foreach (string apelido in aliases)
        {
            Console.WriteLine($"- {apelido}");
        }
    }
}
