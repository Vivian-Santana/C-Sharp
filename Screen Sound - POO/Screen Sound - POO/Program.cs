using ScreenSound.Modelos;

// Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";

Banda LinkinPark = new Banda("Linkin Park");
LinkinPark.AdicionarNota(10);
LinkinPark.AdicionarNota(8);
LinkinPark.AdicionarNota(6);

Banda Beatles = new Banda("The Beatles");
Beatles.AdicionarNota(10);
Beatles.AdicionarNota(8);
Beatles.AdicionarNota(9);

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

    Console.Write("\nDigite a sua opção: "); //write equivale ao print do java
    string opcaoEscolhida = Console.ReadLine()!; //ReadLine pega o input | ! impede input de valor null
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);


    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            RegistrarAlbum();
            break;
        case 3:
            MostrarBandasRegistradas();
            break;
        case 4:
            avaliarBanda();
            break;
        case 5:
            ExibirDetalhes();
            break;
        case 6:
            calcularMedia();
            break;
        case -1:
            Console.WriteLine("Tchau tchau :)");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }

}

void RegistrarBanda()
{
    Console.Clear();

    ExibirTitulosOpcoes("Registro de bandas");

    Console.WriteLine("Digite o nome da banda que deseja registrar: ");
    string nomeBanda = Console.ReadLine()!;
    Banda banda = new Banda(nomeBanda);
    bandasRegistradas.Add(nomeBanda, banda);//colocando o conteudo de de listas no dicionário.
    // listaDasBandas.Add(nomeBanda);
    Console.WriteLine($"A banda {nomeBanda} registrada com sucesso!"); //intepolação de variável
    Thread.Sleep(2000);


    Console.Clear();
    //volta a exibir o menu
    ExibirOpcoesDoMenu();
}

void RegistrarAlbum()
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


    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTitulosOpcoes("Exibindo todas as bandas registradas");

    // pega o valor das chaves do dicionário
    foreach (var banda in bandasRegistradas)
    {
        Banda bandaAtual = banda.Value; //banda.Value acessa o objeto Banda correspondente.

        //Verifica se há notas registradas
        if (bandaAtual.Notas.Count > 0)
        {
            string notasFormatadas = string.Join(", ", bandaAtual.Notas); // variável local notasFormatadas usa o metodo string.Join para unir os valores da lista de notas.
            Console.WriteLine($"Banda: {bandaAtual.NomeBanda} | Notas:{notasFormatadas}.");

        }
        else
        {
            Console.WriteLine($"Banda: {bandaAtual.NomeBanda} Sem notas registradas");
        }
    }

    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal.");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}


void ExibirTitulosOpcoes(string titulo)
{
    int qtdLetras = titulo.Length;
    string ifen = string.Empty.PadLeft(qtdLetras, '-'); //add os ifens às saídas de exibição dos titulos no console.
    Console.WriteLine(ifen);
    Console.WriteLine(titulo);
    Console.WriteLine(ifen);
}


void avaliarBanda()
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
        int nota = int.Parse(Console.ReadLine()!); //atribuindo a nota (valor) a chave (var nomeBanda)
        banda.AdicionarNota(nota);
        Console.WriteLine($"A nota {nota} foi registrada com sucesso! para a banda {nomeBanda}");
        Thread.Sleep(3000); //espera 0,003seg pra voltar ao menu
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeBanda} não foi encontrada.");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();

    }
}

void calcularMedia()
{
    /*
     * calcula e mostra a média das notas de uma banda 
     * limpar o terminal
     * perguntar para qual banda quer ver a media
     * verificar se a banda digitada esta presente no dicionario
     * e se existe notas para a banda,
     * se tiver fazer o calculo da media
     */
    Console.Clear();
    ExibirTitulosOpcoes("Ver média da Banda");
    Console.Write("Digite a banda que deseja ver a média de notas: ");
    string nomeBanda = Console.ReadLine()!;

    //verifica se a banda tem notas registradas
    if (bandasRegistradas.ContainsKey(nomeBanda))
    {
        Banda banda = bandasRegistradas[nomeBanda];

        // Verifica se a banda tem notas registradas
        if (banda.Notas.Count > 0)
        {
            Console.WriteLine($"\nA média da banda {nomeBanda} é {banda.Media:F2}.");// método média na classe banda usa o Average() p calcular media.

        }
        else
        {
            Console.WriteLine($"\nA banda {nomeBanda} ainda não tem nenhuma nota.");
        }
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeBanda} não foi encontrada.");
    }

    Console.WriteLine("Digite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}


void ExibirDetalhes()
{
    Console.Clear();
    ExibirTitulosOpcoes("Exibir detalhes da banda");
    Console.Write("Digite o nome da banda que deseja conhecer melhor: ");
    string nomeBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeBanda))
    {
        Banda banda = bandasRegistradas[nomeBanda]; //Pega o objeto Banda do dicionário
        List<int> notasBanda = banda.Notas; // notasBanda é uma lista de inteiros (List<int>) que está sendo obtida
                                            // diretamente da instância Banda, utilizando a propriedade Notas.

        if (notasBanda.Count > 0)
        {
            Console.WriteLine($"\nA média da banda {nomeBanda} é {banda.Media:F2}.");
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeBanda} ainda não possui notas.");
        }

        Console.WriteLine("Digite uma tecla para votar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();

    }
    else
    {
        Console.WriteLine($"\nA banda {nomeBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

ExibirOpcoesDoMenu();

Console.WriteLine("Pressione qualquer tecla para voltar ao menu principal.");
Console.ReadKey();
Console.Clear();
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