string msgBoasVindas = "Boas Vindas!";

string nome = "Vivian";
string sobrenome = "Santana";

void ExibirMsgBoasVindas()
{
    Console.WriteLine(msgBoasVindas + " " + nome + " " + sobrenome);
}

//método para pular linha estilizado
void pularLinha(string titulo)
{
    int qtdLetras = titulo.Length;
    string ifen = string.Empty.PadLeft(qtdLetras, '-'); //add os ifens às saídas de exibição dos titulos no console.
    Console.WriteLine(ifen);
    Console.WriteLine(titulo);
    Console.WriteLine(ifen);
}

pularLinha("1 - Criar uma variável chamada notaMedia e atribua um valor inteiro a ela. " +
    "Caso seu valor seja maior ou igual a 5, escreva na tela 'Nota suficiente para aprovação'.");
//chamando a função
ExibirMsgBoasVindas();

int notaMedia = 8;

if (notaMedia >= 5)
{
    Console.WriteLine("Nota suficiente para aprovação! 💯");
}
else
{
    Console.WriteLine("Nota insuficiente para aprovação 🥺");
}

pularLinha("2 Criar uma lista de linguagens de programação, com as linguagens C#, Java e JavaScript." +
    "Exibir o valor C# no console, utilizando a lista criada.");


List<string> linguagensProgramacao = new List<string> { "C#", "Java", "JS" };

Console.WriteLine(linguagensProgramacao[0]);


pularLinha("3 - Escrever uma função que a partir de dois números de ponto flutuante a e b exiba no console, " +
    "o resultado de suas quatro operações básicas (adição, subtração, divisão e multiplicação) utilizando interpolação de strings.");


float a = 10;
float b = 2;
void operacoesAritmeticas()
{
    float somar = a + b;
    float subtrair = a - b;
    float dividir = a / b;
    float multiplicar = a * b;

    Console.WriteLine($"A -> {a}" );
    Console.WriteLine($"B -> {b}");
    Console.WriteLine($"a + b = {somar}");
    Console.WriteLine($"a - b = {subtrair}");
    Console.WriteLine($"a / b = {dividir}");
    Console.WriteLine($"a * b = {multiplicar}");
}

operacoesAritmeticas();

pularLinha("4 - Criar uma lista de bandas vazia e adicionar suas bandas prediletas em seguida. " +
    "Utilizar a estrutura 'for' para mostrar todas as suas bandas preferidas, listadas na lista do exercício anterior, no console.");

List<string> bandas = new List<string>();

bandas.Add("Skank");
bandas.Add("Cranberries");
bandas.Add("U2");
bandas.Add("Paralamas do Sucesso");


for (int i = 0; i < bandas.Count; i++)
{
    Console.WriteLine($"Bandas favoritas: {bandas[i]}");
}

//   OU
Console.WriteLine("\n");

// Concatena todas as bandas em uma única string separada por vírgulas
string bandasFavoritas = String.Join(", ", bandas);

// Imprimir a saída em uma única linha
Console.WriteLine($"Bandas favoritas: {bandasFavoritas}"); // Skank, Cranberries, U2, Paralamas do Sucesso

pularLinha("5 - Criar um dicionário que represente um aluno, com uma lista de notas, e mostre a média de suas notas na tela.");
// 5
Console.WriteLine("Criar um programa que calcula a soma de todos os elementos inteiros em uma lista.");

List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };
int soma2 = 0;

foreach (int numero in numeros)
{
    soma2 += numero;
}

Console.WriteLine($"A soma dos elementos da lista é: {soma2}");

pularLinha("6 - Criar um dicionário que represente um aluno, com uma lista de notas, e mostre a média de suas notas na tela.");

Dictionary<string, List<double>> notasAlunos = new Dictionary<string, List<double>>();

// chave - nome do aluno, o valor - lista de notas (do tipo List<double>).
notasAlunos["Bruna"] = new List<double> { 8.5, 9.0, 7.5 };
notasAlunos["Bruno"] = new List<double> { 7.0, 8.0, 6.5 };
double soma = 0;

foreach (var aluno in notasAlunos)
{
    //O aluno.Value é lista de notas de um aluno específico.
    for (int i = 0; i < aluno.Value.Count; i++)
    {
        soma += aluno.Value[i];
    }
    double media = soma / aluno.Value.Count; //O Value.Count é usado para obter a quantidade de itens em uma coleção (a lista de notas do aluno)
    Console.WriteLine($"Média de {aluno.Key}: {media:F1}");
}

pularLinha("7 - Lista de supercarros");
/*
 * Com base na lista de super carros fornecida acima, onde a chave é o nome do carro e os valores 
 * são quantas vezes esse carro foi vendido por ano, calcule a média de uma chave específica.
 */

Dictionary<string, List<int>> vendasCarros = new Dictionary<string, List<int>> {
    { "Bugatti Veyron",new List<int> { 10, 15, 12, 8, 5 } },
    { "Koenigsegg Agera RS",new List<int> { 2, 3, 5, 6, 7 } },
    { "Lamborghini Aventador",new List<int> { 20, 18, 22, 24, 16 } },
    { "Pagani Huayra",new List<int> { 4, 5, 6, 5, 4 } },
    { "Ferrari LaFerrari",new List<int> { 7, 6, 5, 8, 10 } }
};
double mediaVendasBugatti = vendasCarros["Bugatti Veyron"].Average();// Average calcula a média
Console.WriteLine("Média de vendas do Bugatti Veyron: " + mediaVendasBugatti);



pularLinha("8 - Estoque de Loja de roupas");

/* 8
 * Criar um programa que gerencie o estoque de uma loja. Utilize um dicionário para armazenar 
 * produtos e suas quantidades em estoque e mostre, a partir do nome de um produto, sua 
 * quantidade em estoque.
 */
Dictionary<string, int> estoque = new Dictionary<string, int>
{
    { "Vestidos", 50 },
    { "calças", 30 },
    { "Blusas", 20 },
};

string produto = "Vestidos";

if (estoque.ContainsKey(produto))
{
    Console.WriteLine($"Quantidade em estoque de {produto}: {estoque[produto]} unidades.");
}
else
{
    Console.WriteLine("Produto não encontrado no estoque.");
}

pularLinha("9 - Quiz");
/* 9
 * Crie um programa que implemente um quiz simples de perguntas e respostas. Utilize um dicionário 
 * para armazenar as perguntas e as respostas corretas.
 */

// chave e valor do mesmo tipo
Dictionary<string, string> perguntasERespostas = new Dictionary<string, string>
{
    { "Qual é a capital do Brasil?", "Brasília" },
    { "Quanto é 7 vezes 8?", "56" },
    { "Quem é o pai da computação?", "Alan Turing" },
    { "Qual é o nome do primeiro computador?", "Eniac" },
    { "Qual era o nome da primeira rede de computadores?","ARPANET" }
    // Adicione mais perguntas e respostas conforme necessário
};

int pontuacao = 0;

foreach (var pergunta in perguntasERespostas)
{
    Console.WriteLine(pergunta.Key);//mostra a pergunta (chave)
    Console.Write("Sua resposta: ");
    string respostaUsuario = Console.ReadLine();//armazena a resposta na variável respostaUsuario

    if (respostaUsuario.ToLower() == pergunta.Value.ToLower())//converte tudo para minúscula
    {
        Console.WriteLine("Correto! 🎉🥳\n");// Se a resposta for correta, exibe "Correto!" e pula para a próxima linha.
        pontuacao++; //Incrementa a pontuação em 1 se a resposta estiver correta.
    }
    else
    {
        Console.WriteLine($"Incorreto. A resposta correta é: {pergunta.Value}\n"); //mostra a resposta correta
    }
}

//A variável pontuacao contém o número de respostas corretas, e perguntasERespostas.Count retorna o número total de perguntas feitas.
Console.WriteLine($"Pontuação final: {pontuacao} corretas de {perguntasERespostas.Count}");


pularLinha("10 - Sistema de login");
/* 10
 * Criar um programa que simule um sistema de login utilizando um dicionário para armazenar nomes 
 * de usuário e senhas.
 */
Dictionary<string, string> usuarios = new Dictionary<string, string>
{
    { "user1", "senha123" },
    { "user2", "abc456" },
    // Adicione mais usuários conforme necessário
};


//string nomeUsuario = "user1";
//string senha = "senha123";

//inputs de nome e senha
Console.Write("Digite seu login: ");
string nomeUsuario = Console.ReadLine();

Console.Write("Digite sua senha: ");
string senha = Console.ReadLine();

//Verifica se o nome de usuário existe como uma chave no dicionário usuários.
if (usuarios.ContainsKey(nomeUsuario) && usuarios[nomeUsuario] == senha)
    Console.WriteLine("\nLogin bem-sucedido!");
else
    Console.WriteLine("\nNome de usuário ou senha incorretos.");

