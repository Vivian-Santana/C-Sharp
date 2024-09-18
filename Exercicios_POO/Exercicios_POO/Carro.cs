// Desenvolver uma classe que modele um carro, e que contenha os métodos acelerar, frear e buzinar

internal class Carro
{
    public string montadora;
    public string modelo;
    public string anoLancamento;
    public int NumeroDePortas;
    public int velocidade = 0;

    public void exibirInformacoes()
    {
        Console.WriteLine($"Informações do carro: {this.modelo}, fabricado por {this.montadora}, lançado em " +
            $"{this.anoLancamento}, com {this.NumeroDePortas} portas, esta a {this.velocidade} km/h. ");
    }

    public void acelerar()
    {
        Console.WriteLine("Acelerando...");
        if (velocidade < 100)
        {
            velocidade = velocidade + 5;
        }
    }

    public void frear()
    {
        Console.WriteLine("Freando...");
        if (velocidade > 0)
        {
            velocidade = velocidade - 5;
        }
    }

    public void buzinar()
    {
        Console.WriteLine("Bi, bi ...");    }
}
