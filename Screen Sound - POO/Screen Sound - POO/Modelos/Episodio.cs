namespace ScreenSound.Modelos;
internal class Episodio
{
    //convidados estão na lista de strings
    List<string> convidados = new();
    public Episodio(int ordem, string titulo, double duracao)
    {
        Ordem = ordem;     //episodios já nascem com essas propriedades
        Titulo = titulo;
        Duracao = duracao;
    }

    public int Ordem { get; }
    public string Titulo { get; }
    public double Duracao { get; }
    public int Numero {  get; set; }
    public string Resumo => $"{Ordem}, {Titulo}, ({Duracao} min.) - " +
        $"{string.Join(", ",convidados)}.";  //func Join concatena os valores da lista de convidados
    public string Convidado { get; set; }

    //vai ser chamado quantas vezes for necessário.
    public void AdicionarConvidados(string convidado)
    {
        convidados.Add(convidado);
    }
}
