/*
 * Com base na lista de super carros fornecida acima, onde a chave é o nome do carro e os valores 
 * são quantas vezes esse carro foi vendido por ano, calcule a média de uma chave específica.
 */

//var mediaCarros = newDictionary<string, Dictionary <string, int>>>;

Dictionary<string, List<int>> vendasCarros = new Dictionary<string, List<int>> {
    { "Bugatti Veyron", new List<int> { 10, 15, 12, 8, 5 } },
    { "Koenigsegg Agera RS", new List<int> { 2, 3, 5, 6, 7 } },
    { "Lamborghini Aventador", new List<int> { 20, 18, 22, 24, 16 } },
    { "Pagani Huayra", new List<int> { 4, 5, 6, 5, 4 } },
    { "Ferrari LaFerrari", new List<int> { 7, 6, 5, 8, 10 } }
};


string Bugatti = "Bugatti Veyron"; //Acessar os valores associados à chave (nome do carro).
List<int> vendas = vendasCarros[Bugatti];
double media = vendas.Average();  //vendas.Average() para calcula a média dos valores na lista.
Console.WriteLine($"A média de vendas para {Bugatti} é {media:F2}"); //Exibe a média formatada com duas casas decimais | saída: 10

//outro jeito
double mediaVendasFerrari = vendasCarros["Ferrari LaFerrari"].Average(); 
Console.WriteLine($"A Média de vendas do Ferrari LaFerrari é {mediaVendasFerrari}"); //saída: 7,2