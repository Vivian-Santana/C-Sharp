namespace Screen_Sound___POO.Menus;
//classe mãe
internal class Menu
{
    //método que organiza o cabeçalho das opções do menu
    public void ExibirTitulosOpcoes(string titulo)
    {
        int qtdLetras = titulo.Length;
        string ifen = string.Empty.PadLeft(qtdLetras, '※'); //add ※ às saídas de exibição dos titulos no console.
        Console.WriteLine(ifen);
        Console.WriteLine(titulo);
        Console.WriteLine(ifen);
    }
}
