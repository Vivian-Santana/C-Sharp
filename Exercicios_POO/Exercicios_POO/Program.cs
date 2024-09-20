/*

- Criar uma classe que representa uma conta bancária, com um número indicador, titular, saldo e senha.
- Criar um objeto do tipo Conta, adicionar dados e mostrar as informações titular e saldo no console,
- utilizando interpolação de strings.Desenvolver um método da classe Conta que exibe suas informações.
- Desenvolver uma classe que modele um carro, e que contenha os métodos acelerar, frear e buzinar
*/

//instancia do obj ContaBancaria
ContaBancaria conta = new ContaBancaria();
conta.titular = "Vivian Santana";
//conta.IdConta = 1;
conta.saldo = 20.00;
conta.Senha = "1234";

/*
Console.WriteLine("INFORMAÇÕES DA CONTA:");
Console.WriteLine($"Titular: {conta.titular}");
Console.WriteLine($"Saldo atual: {conta.saldo:F2}");
*/

conta.ExibirInformacoes();

Console.WriteLine("\n");

// Instancia da classe Carro

Carro carro1 = new Carro();
carro1.modelo = "jeep renegade";
carro1.montadora = "Jeep";
carro1.anoLancamento = "2014";
carro1.velocidade = 95;
carro1.NumeroDePortas = 4;

carro1.exibirInformacoes();
carro1.acelerar();

//verifica a velocidade depois de acelerar
Console.WriteLine($"velocidade atual: {carro1.velocidade}");

carro1.buzinar();

carro1.frear();
//verifica a velocidade depois de frear
Console.WriteLine($"velocidade atual: {carro1.velocidade}");

//a cada chamada do metodo frear diminui 5km
carro1.frear();
Console.WriteLine($"velocidade atual: {carro1.velocidade}");

carro1.frear();
Console.WriteLine($"velocidade atual: {carro1.velocidade}");