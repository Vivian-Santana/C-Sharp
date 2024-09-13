// Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";

//Dicionário
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> { 10, 8, 6 });
bandasRegistradas.Add("The Beatles", new List<int>());

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
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: "); //write equivale ao print do java
    string opcaoEscolhida = Console.ReadLine()!; //ReadLine pega o input | ! impede input de valor null
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);


    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            MostrarBandasRegistradas();
            break;
        case 3:
            avaliarBanda();
            break;
        case 4:
            Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
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
    bandasRegistradas.Add(nomeBanda, new List<int>());//colocando o conteudo de de listas no dicionário.
    // listaDasBandas.Add(nomeBanda);
    Console.WriteLine($"A banda {nomeBanda} com sucesso!"); //intepolação de variável
    Thread.Sleep(2000);

    Console.Clear();
    //volta a exibir o menu
    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTitulosOpcoes("Exibindo todas as bandas registradas");

    // pega o valor em das chaves do dicionário
    foreach (KeyValuePair<string, List<int>> banda in bandasRegistradas) // substituição (string banda in bandasRegistradas.Keys) | mudança para exibir o nome da banda e as notas associadas
    {
        /*
         * linha 92: verifica se há notas registradas para a banda. Se houver, 
         * ele converte a lista de notas (banda.Value) em uma string 
         * com notas separadas por vírgulas.
         */
        string notas = banda.Value.Count > 0 ? string.Join(", ", banda.Value): "Nenhuma nota registrada"; // Concatena as notas separadas por vírgulas
        Console.WriteLine($"Banda: {banda.Key} | Notas: {notas}");
    }
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
        Console.Write($"Qual nota voce deseja dar a banda {nomeBanda}?"); 
        int nota = int.Parse(Console.ReadLine()!); //atribuindo a nota (valor) a chave (var nomeBanda)
        bandasRegistradas[nomeBanda].Add(nota);// [] indexa o dicionario usando a chave, acessa os valores das chaves que é uma lista de inteiros | .Add coloca a nota
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

ExibirOpcoesDoMenu();

Console.WriteLine("Pressione qualquer tecla para voltar ao menu principal.");
Console.ReadKey();
Console.Clear();

RegistrarBanda();


