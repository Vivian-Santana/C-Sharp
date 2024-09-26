//com convenção toda interface em C# tem I maiúsculo no no incio do nome
using ScreenSound.Modelos;

namespace Screen_Sound___POO.Modelos;

internal interface IAvaliavel
{
    void AdicionarNota(Avaliacao nota); //metodo recebe avaliação e não retorna nada
    double Media { get; } // metodo de leitura que entrega um double
}
