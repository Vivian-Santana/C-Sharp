using ScreenSound.Modelos;

namespace Screen_Sound___POO.Menus;

internal class MenuAvaliarBanda : Menu //forma de extender a classe mãe Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas) //Dic bandasRegistradas | chave é o nome da banda (string), e o valor é um objeto Banda.
    {
        /*
         * base é utilizado para acessar o comportamento original do método da classe mãe, 
         * garantindo que a implementação base do método seja executada antes (ou depois) 
         * da implementação na subclasse.
         * Se não usar base.Executar(...) e tiver sobrescrito o método na subclasse, a implementação 
         * original na classe base não será executada, e apenas o código na subclasse será considerado.
         * Quando você deseja manter parte do comportamento da classe base e, 
         * ao mesmo tempo, adicionar ou modificar o comportamento na classe derivada.
         * Útil para reutilizar código da classe mãe sem precisar duplicá-lo.
         */

        base.Executar(bandasRegistradas);  //sobrescreve o método executar da classe mãe menu (override)

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
