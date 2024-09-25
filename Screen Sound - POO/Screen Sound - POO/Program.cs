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

Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new MenuRegistrarBanda());
opcoes.Add(2, new MenuRegistrarAlbum());
opcoes.Add(3, new MenuMostrarBandasRegistradas());
opcoes.Add(4, new MenuAvaliarBanda());
opcoes.Add(5, new MenuExibirDetalhes());
opcoes.Add(6, new MenuCalcularMedia());
opcoes.Add(-1, new MenuSair());


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
    int opcaoNumericaEscolhida = int.Parse(opcaoEscolhida);

    if (opcoes.ContainsKey(opcaoNumericaEscolhida))
    {
        //pega o obj opcoes no dicionario e atribui a variável menu do tipo Menu
        Menu ExibirMenu = opcoes[opcaoNumericaEscolhida];
        ExibirMenu.Executar(bandasRegistradas);
        if(opcaoNumericaEscolhida > 0) ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine("Opção inválida");
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