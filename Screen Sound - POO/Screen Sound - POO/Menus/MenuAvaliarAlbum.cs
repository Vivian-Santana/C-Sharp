using ScreenSound.Modelos;

namespace Screen_Sound___POO.Menus;

internal class MenuAvaliarAlbum : Menu //herança de Menu
{
    //sobrescrita do método da superclasse
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTitulosOpcoes("Avaliar Album");
        Console.Write("O album de qual banda voce deseja avaliar? ");
        //Console.Write("Digite o nome Album que deseja avaliar: ");
        string nomeBanda = Console.ReadLine()!;

        if (bandasRegistradas.ContainsKey(nomeBanda))
        {
            Banda banda = bandasRegistradas[nomeBanda];
            Console.Write("Agora digite o título do álbum: ");
            string tituloAlbum = Console.ReadLine()!;

            if (banda.Albuns.Any(a => a.NomeAlbum.Equals(tituloAlbum))) //verifica se tiver um titulo de album na classe algum
            {
                Album album = banda.Albuns.First(a => a.NomeAlbum.Equals(tituloAlbum));
                Console.Write($"Qual nota voce deseja dar ao album {tituloAlbum}? ");
                Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
                album.AdicionarNota(nota);
                Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso! para o album {tituloAlbum}");
                Thread.Sleep(3000); //espera 0,003seg pra voltar ao menu
                Console.Clear();

            }
            else
            {
                Console.WriteLine($"\nO album {tituloAlbum} não foi encontrado.");
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
