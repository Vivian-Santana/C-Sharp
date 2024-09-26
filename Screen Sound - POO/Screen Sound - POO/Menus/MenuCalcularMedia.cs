using ScreenSound.Modelos;

namespace Screen_Sound___POO.Menus;

internal class MenuCalcularMedia : Menu  //forma de extender a classe mãe Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);  //sobrescreve o método executar da classe mãe menu (override)
        ExibirTitulosOpcoes("Ver média da Banda");
        Console.Write("Digite a banda que deseja ver a média de notas: ");
        string nomeBanda = Console.ReadLine()!;

        //verifica se a banda tem notas registradas
        if (bandasRegistradas.ContainsKey(nomeBanda))
        {
            Banda banda = bandasRegistradas[nomeBanda];

            // Verifica se a banda tem notas registradas
            if (banda.Notas.Count > 0)
            {
                Console.WriteLine($"\nA média da banda {nomeBanda} é {banda.Media:F2}.");// método média na classe banda usa o Average() p calcular media.(encapsulada na propriedade media)

            }
            else
            {
                Console.WriteLine($"\nA banda {nomeBanda} ainda não tem nenhuma nota.");
            }
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeBanda} não foi encontrada.");
        }

        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
}
