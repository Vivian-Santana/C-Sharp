
using ScreenSound.Modelos;

namespace Screen_Sound___POO.Menus;

internal class MenuMostrarBandasRegistradas : Menu //forma de extender a classe mãe Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas); //sobrescreve o método executar da classe mãe menu (override) mantendo tbm o comportamento original
        ExibirTitulosOpcoes("Exibindo todas as bandas registradas");

        // pega o valor das chaves do dicionário
        foreach (var banda in bandasRegistradas)
        {
            Banda bandaAtual = banda.Value; //banda.Value acessa o objeto Banda correspondente.

            //Verifica se há notas registradas
            if (bandaAtual.Notas.Count > 0)
            {
                string notasFormatadas = string.Join(", ", bandaAtual.Notas.Select(n => n.Nota.ToString())); // variável local notasFormatadas usa o metodo string.Join para unir os valores da lista de notas.
                Console.WriteLine($"Banda: {bandaAtual.NomeBanda} | Notas:{notasFormatadas}.");
            }
            else
            {
                Console.WriteLine($"Banda: {bandaAtual.NomeBanda} Sem notas registradas");
            }
        }

        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal.");
        Console.ReadKey();
        Console.Clear();
    }
}
