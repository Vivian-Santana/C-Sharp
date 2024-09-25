using ScreenSound.Modelos;

namespace Screen_Sound___POO.Menus;
//classe mãe
internal class Menu
{
    //método que organiza o cabeçalho das opções do menu
    public void ExibirTitulosOpcoes(string titulo)
    {
        int qtdLetras = titulo.Length;
        string simbolo = string.Empty.PadLeft(qtdLetras, '※'); //add ※ às saídas de exibição dos titulos no console.
        Console.WriteLine(simbolo);
        Console.WriteLine(titulo);
        Console.WriteLine(simbolo);
    }

    //sobrescrita de método (override e virtual)
    public virtual void Executar(Dictionary<string, Banda> bandasRegistrdas)
    {
        Console.Clear();
    }
}
