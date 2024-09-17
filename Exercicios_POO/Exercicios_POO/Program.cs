/*

- Criar uma classe que representa uma conta bancária, com um número indicador, titular, saldo e senha.
- Criar um objeto do tipo Conta, adicionar dados e mostrar as informações titular e saldo no console,
- utilizando interpolação de strings.Desenvolver um método da classe Conta que exibe suas informações.
- Desenvolver uma classe que modele um carro, e que contenha os métodos acelerar, frear e buzinar
*/

ContaBancaria conta = new ContaBancaria();
conta.titular = "Vivian Santana";
conta.idConta = 1;
conta.saldo = 20.00;
conta.senha = "1234";

/*
Console.WriteLine("INFORMAÇÕES DA CONTA:");
Console.WriteLine($"Titular: {conta.titular}");
Console.WriteLine($"Saldo atual: {conta.saldo:F2}");
*/

conta.ExibirInformacoes();