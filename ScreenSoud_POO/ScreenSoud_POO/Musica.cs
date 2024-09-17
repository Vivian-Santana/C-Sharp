//atributos (fields) e propriedades (properties)
class Musica
{
    // atributos
    public string Titulo { get; set; }
    public string Artista { get; set; }
    public double Duracao { get; set; }
    public bool Disponivel { get; set; }

    /* atributos com letra maiúscula são PROPRIEDADES (são escritas em PascalCase), uma forma sucinta de
     * escrever operações de leitura e escrita propriedade é uma abstração que fornece um meio de acessar e modificar
     * os valores dos atributos de uma classe, encapsulando a lógica de leitura e escrita. Através delas chamamos de 
     * forma simples os metodos de acesso (getter e setters) de um atributo.
     */

    /*
    public  string DescricaoResumida //juntar duas propriedades
    { 
        get
        {
            return $"A música {Titulo} pertence a banda {Artista}\n";
        }
    }
    */

    public string DescricaoResumida => $"A música {Titulo} pertence a banda {Artista}\n"; //mesmo que o codigo acima comentado mas com lambda (só o metodo get) tipo arrow function
    /* lambdas são funções anônimas que podem ser usadas para criar expressões ou blocos 
     * de código compactos e concisos. Eles são especialmente úteis quando se trata de trabalhar 
     * com coleções de dados, realizar operações em uma sequência de elementos ou lidar com delegados.
     */

    public int MyProperty { get; set; }

    //método para exibição das informações de musicas
    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Titulo:{Titulo}");
        Console.WriteLine($"Artista:{Artista}");
        Console.WriteLine($"Duração {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano.\n");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus.\n");
        }
    }
}
