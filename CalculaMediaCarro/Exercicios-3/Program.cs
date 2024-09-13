string msgBoasVindas = "Boas Vindas!";

string nome = "Vivian";
string sobrenome = "Santana";

void ExibirMsgBoasVindas()
{
    Console.WriteLine(msgBoasVindas + " " + nome + " " + sobrenome);
}

//chamando a função
ExibirMsgBoasVindas();

/* 1
 * Criar uma variável chamada notaMedia e atribua um valor inteiro a ela. 
 * Caso seu valor seja maior ou igual a 5, escreva na tela "Nota suficiente para aprovação".
 */

int notaMedia = 8;

if (notaMedia >= 5)
{
    Console.WriteLine("Nota suficiente para aprovação! 💯");
}
else
{
    Console.WriteLine("Nota insuficiente para aprovação 🥺");
}

Console.WriteLine("--------------------------------------------------------------------------------------------------");

/* 2
 * Criar uma lista de linguagens de programação, com as linguagens C#, Java e JavaScript.
 * Exibir o valor "C#" no console, utilizando a lista criada.
*/

List<string> linguagensProgramacao = new List<string> { "C#", "Java", "JS" };

Console.WriteLine(linguagensProgramacao[0]);

Console.WriteLine("\nDicionário de notas:");


Console.WriteLine("--------------------------------------------------------------------------------------------------");
/* 3
* Escrever uma função que a partir de dois números de ponto flutuante a e b exiba no console 
 * o resultado de suas quatro operações básicas (adição, subtração, divisão e multiplicação), 
 * utilizando interpolação de strings.
 */

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

Console.WriteLine("--------------------------------------------------------------------------------------------------");

/* 4
 * Criar uma lista de bandas vazia e adicionar suas bandas prediletas em seguida.
 * Utilizar a estrutura 'for' para mostrar todas as suas bandas preferidas, listadas
 * na lista do exercício anterior, no console.
*/

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

Console.WriteLine("--------------------------------------------------------------------------------------------------");
// 5
Console.WriteLine("Criar um programa que calcula a soma de todos os elementos inteiros em uma lista.");

List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };
int soma2 = 0;

foreach (int numero in numeros)
{
    soma2 += numero;
}

Console.WriteLine($"A soma dos elementos da lista é: {soma2}");

Console.WriteLine("--------------------------------------------------------------------------------------------------");

//5 Criar um dicionário que represente um aluno, com uma lista de notas, e mostre a média de suas notas na tela.
Dictionary<string, List<double>> notasAlunos = new Dictionary<string, List<double>>();

// Adicione notas para alguns alunos
notasAlunos["Bruna"] = new List<double> { 8.5, 9.0, 7.5 };
notasAlunos["Bruno"] = new List<double> { 7.0, 8.0, 6.5 };
double soma = 0;

foreach (var aluno in notasAlunos)
{

    for (int i = 0; i < aluno.Value.Count; i++)
    {
        soma += aluno.Value[i];
    }
    double media = soma / aluno.Value.Count;
    Console.WriteLine($"Média de {aluno.Key}: {media:F1}");
}

Console.WriteLine("--------------------------------------------------------------------------------------------------");
/* 6
 * Criar um programa que gerencie o estoque de uma loja. Utilize um dicionário para armazenar 
 * produtos e suas quantidades em estoque e mostre, a partir do nome de um produto, sua 
 * quantidade em estoque.
 */


/* 7
 * Crie um programa que implemente um quiz simples de perguntas e respostas. Utilize um dicionário 
 * para armazenar as perguntas e as respostas corretas.
 */

/* 8
 * Criar um programa que simule um sistema de login utilizando um dicionário para armazenar nomes 
 * de usuário e senhas.
 */


