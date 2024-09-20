//Reescrever a classe Conta, criada no ultimo desafio, utilizando properties.
public class ContaBancaria
{
    //atributos e propriedades
       public string titular;
       public int IdConta { get; set; }
       public double saldo = 0;
       public string Senha { get; set; }
    

    public void ExibirInformacoes()
    {
        Console.WriteLine("INFORMAÇÕES DA CONTA:");
        Console.WriteLine($"Titular: {this.titular}");
        Console.WriteLine($"Saldo atual: {this.saldo:F2}");
    }
}
