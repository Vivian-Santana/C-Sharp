using ScreenSound.Modelos;

namespace Screen_Sound___POO.Menus
{
    internal class MenuExibirDetalhes : Menu //forma de extender a classe mãe Menu
    {
        public void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            Console.Clear();
            ExibirTitulosOpcoes("Exibir detalhes da banda");
            Console.Write("Digite o nome da banda que deseja conhecer melhor: ");
            string nomeBanda = Console.ReadLine()!;
            if (bandasRegistradas.ContainsKey(nomeBanda))
            {
                Banda banda = bandasRegistradas[nomeBanda]; //Pega o objeto Banda do dicionário
                List<Avaliacao> notasBanda = banda.Notas; // notasBanda é uma lista de inteiros (List<int>) que está sendo obtida
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
            }
            else
            {
                Console.WriteLine($"\nA banda {nomeBanda} não foi encontrada!");
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
