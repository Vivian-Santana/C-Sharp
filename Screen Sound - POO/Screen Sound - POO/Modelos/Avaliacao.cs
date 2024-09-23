
namespace ScreenSound.Modelos;

internal class Avaliacao //internal visibilidade da classe (fica visivel só para o projeto)
{
    //constutor
    public Avaliacao(int nota) 
    {
        if (nota <= 0) nota = 0;
        if (nota >= 10) nota = 10;
        Nota = nota;
        /* O if no construtor, está garantindo que a validação das notas seja feita logo no momento em que a classe Avaliacao é instanciada.
         * Isso significa que, ao criar um objeto do tipo Avaliacao, tem se a garantia de que a nota estará dentro do intervalo válido (de 0 a 10). 
         * Se alguém tentar criar uma avaliação com uma nota menor que zero, por exemplo, o construtor irá automaticamente ajustar essa nota para zero. 
         * Da mesma forma, se alguém tentar criar uma avaliação com uma nota maior que dez, o construtor irá ajustar essa nota para dez.
         * Esse é o poder do encapsulamento: isolamos uma regra de validação pertinente somente a avaliações. Quando houver necessidade de mudar esta regra 
         * (seja porque os limites mudaram ou por qualquer outro motivo), a mudança será realizada em um local único.
         */
    }

    public int Nota { get; } //encapsulamento das notas

    //metodo Parse(para converter um int para um obj do tipo avaliacao) retorna um obj do tipo avaliação
    public static Avaliacao Parse(string texto) // static significa q podemos chamar o metodo direto pelo titulo (sem precisar do "new")
    {
        int nota = int.Parse(texto); //o q esta aqui dentro não usa nenhuma info da instancia da classe
        return new Avaliacao(nota);
    }
}
