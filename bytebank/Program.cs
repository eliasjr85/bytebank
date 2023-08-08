using bytebank.Contas;
using bytebank.Titular;
//using System;

//ContaCorrente conta = new ContaCorrente();
//Console.WriteLine($"Titular da conta: {conta.titular}");
//Console.WriteLine($"Número da conta: {conta.conta}");
////Console.WriteLine($"Agência: {conta.numero_agencia}");
//Console.WriteLine($"Saldo R$ {String.Format("{0:0.00}", conta.saldo)}");

//Console.ReadKey();
//
//ContaCorrente contaDoAndre = new ContaCorrente();
//contaDoAndre.titular = "André Silva";
//contaDoAndre.numero_agencia = 15;
//contaDoAndre.conta = "1010-X";
//contaDoAndre.saldo = 100;

//Console.WriteLine("Saldo da conta do André = " + contaDoAndre.saldo);

//ContaCorrente contaDoAndre2 = new ContaCorrente();
//contaDoAndre2.titular = "André Silva";
//contaDoAndre2.numero_agencia = 15;
//contaDoAndre2.conta = "1010-X";
//contaDoAndre2.saldo = 100;
//Console.WriteLine("Saldo da conta do André 2 = " + contaDoAndre2.saldo);

//contaDoAndre = contaDoAndre2;

//Console.WriteLine(contaDoAndre == contaDoAndre2);
//
//contaDoAndre.Depositar(100);


//Console.WriteLine("Saldo da conta do André pós-depósito =" + contaDoAndre.saldo);

//if (contaDoAndre.Sacar(300) == true)
//{
//    Console.WriteLine("Saldo da conta do André pós-saque =" + contaDoAndre.saldo);
//}
//else
//{
//    Console.WriteLine("Saldo insufuciente para saque.");
//}
//

//ContaCorrente contaDaMaria = new ContaCorrente();
//contaDaMaria.titular = "Maria Souza";
//contaDaMaria.numero_agencia = 17;
//contaDaMaria.conta = "1010-5";
//contaDaMaria.saldo = 350;

//Console.WriteLine("Saldo da conta d Maria = " + contaDaMaria.saldo);

//contaDoAndre.Transferir(50, contaDaMaria);
//Console.WriteLine("Saldo do André =" + contaDoAndre.saldo);
//Console.WriteLine("Saldo da Maria =" + contaDaMaria.saldo);

//ContaCorrente contaDoPedro = new ContaCorrente();
//contaDoPedro.titular = "Pedro Silva";
//Console.WriteLine(contaDoPedro.titular);
//Console.WriteLine(contaDoPedro.conta);
//Console.WriteLine(contaDoPedro.numero_agencia);
//Console.WriteLine(contaDoPedro.saldo);

//double valor = 300;
//double valor2 = valor;
//Console.WriteLine(valor == valor2);

//new ContaCorrente();

//ContaCorrente conta = new ContaCorrente();

//Cliente cliente= new Cliente();
//cliente.nome = "Andre Silva";
//cliente.Cpf = "123456789";
//cliente.profissao = "Analista";

//ContaCorrente conta = new ContaCorrente();
//conta.titular = cliente;
//conta.conta = "1010-x";
//conta.numero_agencia = 15;
//conta.saldo = 100;

//Console.WriteLine("Titular = " + conta.titular.nome);
//Console.WriteLine("Cpf = " + conta.titular.Cpf);
//Console.WriteLine("Profissao = " + conta.titular.profissao);
//Console.WriteLine("Nº Conta = " + conta.conta);
//Console.WriteLine("Saldo = " + conta.saldo);
//Console.WriteLine("Nº Agência = " + conta.numero_agencia);

//ContaCorrente conta2 = new ContaCorrente();
//conta2.titular = new Cliente();
//conta2.titular.nome = "José Souza";
//conta2.titular.profissao = "Tester";
//conta2.titular.Cpf = "987654321";
//conta2.conta = "9999-X";
//conta2.numero_agencia = 18;
//conta2.saldo = 500;

//Console.WriteLine(conta2.titular.nome);

//ContaCorrente conta3 = new ContaCorrente();
//conta3.Numero_Agencia = 18;
//conta3.Conta = "1011-H";
//conta3.SetSaldo(200);
//Console.WriteLine(conta3.GetSaldo());
//Console.WriteLine(conta3.Numero_Agencia);
//Console.WriteLine(conta3.Conta);

ContaCorrente conta4 = new ContaCorrente(18, "1010-x");
conta4.SetSaldo(500);
conta4.Numero_Agencia = 18;
conta4.titular = new Cliente();



Console.WriteLine(conta4.GetSaldo());
Console.WriteLine(conta4.Numero_Agencia);