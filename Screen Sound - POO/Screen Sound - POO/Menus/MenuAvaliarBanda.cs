using ScreenSound.Modelos;

namespace Screen_Sound___POO.Menus;

internal class MenuAvaliarBanda : Menu
{
    public void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        /*
         * escolher qual banda avaliar
         * se a banda existir no dicionário atribuir 
         * uma nota se a banda não existir volta ao menu
         */

        Console.Clear();

        ExibirTitulosOpcoes("Avaliar Banda");
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeBanda = Console.ReadLine()!;

        if (bandasRegistradas.ContainsKey(nomeBanda))// verificando se a banda escolhida (se a key existe)
        {
            Banda banda = bandasRegistradas[nomeBanda];//pega o obj do tipo Banda (do dicionario)
            Console.Write($"Qual nota voce deseja dar a banda {nomeBanda}? ");
            Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!); //atribuindo a nota (valor) a chave (var nomeBanda)
            banda.AdicionarNota(nota);
            Console.WriteLine($"A nota {nota.Nota} foi registrada com sucesso! para a banda {nomeBanda}");
            Thread.Sleep(3000); //espera 0,003seg pra voltar ao menu
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeBanda} não foi encontrada.");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
