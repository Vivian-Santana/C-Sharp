using Screen_Sound___POO.Menus;
using ScreenSound.Modelos;

// Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";

Banda LinkinPark = new Banda("Linkin Park");
LinkinPark.AdicionarNota(new Avaliacao (10));
LinkinPark.AdicionarNota(new Avaliacao (8));
LinkinPark.AdicionarNota(new Avaliacao (6));

Banda Beatles = new Banda("The Beatles");
Beatles.AdicionarNota(new Avaliacao (10));
Beatles.AdicionarNota(new Avaliacao (8));
Beatles.AdicionarNota(new Avaliacao (9));

//Dicionário
Dictionary<string, Banda > bandasRegistradas = new();
bandasRegistradas.Add(LinkinPark.NomeBanda, LinkinPark);
bandasRegistradas.Add(Beatles.NomeBanda, Beatles);

void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");//writeLine equivale ao println do java
    Console.WriteLine("Digite 2 para registrar um album");
    Console.WriteLine("Digite 3 para mostrar todas as bandas");
    Console.WriteLine("Digite 4 para avaliar uma banda");
    Console.WriteLine("Digite 5 para exibir detalhes de uma banda");
    Console.WriteLine("Digite 6 para exibir a média de notas uma banda"); //não esta mostrando as notas
    Console.WriteLine("Digite -1 para sair.");

    Console.Write("\nDigite a sua opção: "); //write equivale ao print do java
    string opcaoEscolhida = Console.ReadLine()!; //ReadLine pega o input | ! impede input de valor null
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);


    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            MenuRegistrarBanda menu_1 = new(); //instancia a classe
            menu_1.Executar(bandasRegistradas); //chama o metodo de execução com o dic de Banda como parâmetro
            ExibirOpcoesDoMenu(); //chama as opções do menu para serem mostradas
            break;
        case 2:
            MenuRegistrarAlbum menu_2 = new();
            menu_2.Executar(bandasRegistradas);
            ExibirOpcoesDoMenu();
            break;
        case 3:
            MenuMostrarBandasRegistradas menu_3 = new();
            menu_3.Executar(bandasRegistradas);
            ExibirOpcoesDoMenu();
            break;
        case 4:
            MenuAvaliarBanda menu_4 = new ();
            menu_4.Executar(bandasRegistradas);
            ExibirOpcoesDoMenu();
            break;
        case 5:
            MenuExibirDetalhes menu_5 = new ();
            menu_5.Executar(bandasRegistradas);
            ExibirOpcoesDoMenu();
            break;
        case 6:
            MenuCalcularMedia menu_6 = new();
            menu_6.Executar(bandasRegistradas);
            ExibirOpcoesDoMenu();
            break;
        case -1:
            Console.WriteLine("Tchau tchau :)");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }

}

ExibirOpcoesDoMenu();


/*
//Trabalhando com as outras classes

//instanciando uma banda
Banda Skank = new Banda("Skank");

//instanciando album
Album albumSkank = new Album("maquinarama");

Musica musica1 = new Musica(Skank, "Canção noturna");
musica1.Duracao = 3.58; //em minutos
musica1.Disponivel = true;

Musica musica2 = new Musica(Skank, "Três lados")
{
    Duracao = 3.53,     //outra forma de incializar propriedades opcionais no obj.
    Disponivel = true
};

Musica musica3 = new Musica(Skank, "Ali");
musica3.Duracao = 5.6;
musica3.Disponivel = false;

//add musicas ao album
albumSkank.addMusica(musica1);
albumSkank.addMusica(musica2);
albumSkank.addMusica(musica3);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
musica3.ExibirFichaTecnica();

albumSkank.ExibirMusicasDoAlbum();

musica1.Genero = new Genero { GeneroMusical = "Rock nacional" }; //composição de classes
Console.WriteLine($"A música {musica1.Titulo} é do gênero {musica1.Genero.GeneroMusical}\n");

Skank.AdicionarAbum(albumSkank);
Skank.ExibirDiscografia();

//Podcast
Console.WriteLine("\n\nPodcast");

Episodio ep1 = new(2, "Técnicas de facilitação", 45);
ep1.AdicionarConvidados("Bruna");
ep1.AdicionarConvidados("Erica");
ep1.AdicionarConvidados("Vivian");
ep1.AdicionarConvidados("José");
ep1.AdicionarConvidados("Mariana");
//Console.WriteLine(ep1.Resumo);

Episodio ep2 = new(1, "Técnicas de aprensizado", 67);
ep2.AdicionarConvidados("Ana");
ep2.AdicionarConvidados("Laura");
ep2.AdicionarConvidados("Fernando");
ep2.AdicionarConvidados("Samuel");

Podcast podcast = new("Inteligência LTDA", "Rogério Vilela");
podcast.addEpisodio(ep1);
podcast.addEpisodio(ep2);
podcast.exibirDetalhes();

*/