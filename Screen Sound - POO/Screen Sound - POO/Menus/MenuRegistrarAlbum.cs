using ScreenSound.Modelos;

namespace Screen_Sound___POO.Menus;

internal class MenuRegistrarAlbum : Menu //forma de extender a classe mãe Menu
{
    public void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.Clear();
        ExibirTitulosOpcoes("Registro de álbuns");
        Console.Write("Para qual banda voce deseja registrar um album?  ");
        string nomeBanda = Console.ReadLine()!;

        if (bandasRegistradas.ContainsKey(nomeBanda))
        {
            Console.Write("Agora digite o título do álbum: ");
            string tituloAlbum = Console.ReadLine()!;
            Banda banda = bandasRegistradas[nomeBanda];
            banda.AdicionarAbum(new Album(tituloAlbum));//criar um album pegando o nome da var tituloAlbum


            Console.WriteLine($"O álbum {tituloAlbum} de {nomeBanda} foi registrado com sucesso!");
            Thread.Sleep(4000);
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeBanda} não foi encontrada.");
            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
