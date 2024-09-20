//atributos (fields) e propriedades (properties)
public class Musica
{
    //construtor com 2 parâmetros
    public Musica(Banda artista, string titulo)
    {
        Artista = artista;
        Titulo = titulo;
    }

    // atributos
    public string Titulo { get; }
    public Banda Artista { get; } //composição de classes
    public double Duracao { get; set; }
    public bool Disponivel { get; set; }
    public Genero Genero { get; set; } //composição de classes

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

    //método para exibição das informações de musicas
    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Titulo:{Titulo}");
        Console.WriteLine($"Artista:{Artista.NomeBanda}");
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

    //metodo para reproduzir uma musica
    public void Reproduzir()
    {
        Console.WriteLine($"Tocando a música {Titulo} de {Artista}");
    }
}
