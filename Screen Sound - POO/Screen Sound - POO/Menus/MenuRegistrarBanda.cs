
using ScreenSound.Modelos;

namespace Screen_Sound___POO.Menus;

internal class MenuRegistrarBanda : Menu //forma de extender a classe mãe Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);

        ExibirTitulosOpcoes("Registro de bandas");

        Console.WriteLine("Digite o nome da banda que deseja registrar: ");
        string nomeBanda = Console.ReadLine()!;
        Banda banda = new Banda(nomeBanda);
        bandasRegistradas.Add(nomeBanda, banda);//colocando o conteudo de de listas no dicionário.
                                                // listaDasBandas.Add(nomeBanda);
        Console.WriteLine($"A banda {nomeBanda} registrada com sucesso!"); //intepolação de variável
        Thread.Sleep(2000);
        Console.Clear();
    }

}
