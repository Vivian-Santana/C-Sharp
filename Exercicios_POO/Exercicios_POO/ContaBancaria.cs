
public class ContaBancaria
{
    //atributos
       public string titular;
       public int idConta = 0;
       public double saldo = 0;
       public string senha;
    

    public void ExibirInformacoes()
    {
        Console.WriteLine("INFORMAÇÕES DA CONTA:");
        Console.WriteLine($"Titular: {this.titular}");
        Console.WriteLine($"Saldo atual: {this.saldo}");
    }
}
