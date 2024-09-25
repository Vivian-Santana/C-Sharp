using ScreenSound.Modelos;

namespace Screen_Sound___POO.Menus;

internal class MenuCalcularMedia : Menu  //forma de extender a classe mãe Menu
{
    public void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        /*
         * calcula e mostra a média das notas de uma banda 
         * limpar o terminal
         * perguntar para qual banda quer ver a media
         * verificar se a banda digitada esta presente no dicionario
         * e se existe notas para a banda,
         * se tiver fazer o calculo da media
         */
        Console.Clear();
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
