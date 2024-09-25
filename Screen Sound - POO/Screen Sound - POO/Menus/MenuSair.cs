namespace Screen_Sound___POO.Menus;
using ScreenSound.Modelos;

internal class MenuSair : Menu //forma de extender a classe mãe Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistrdas)
    {
        Console.WriteLine("Tchau tchau :)");
    }
}
