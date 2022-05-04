using ContaBancaria.Models;

DadosConta lstDadosConta = new DadosConta();

int Conta;

string Titular, Deposito, Opcao;

decimal Valor_Deposito, Valor_Saque, Valor_Saldo, Valor_Saldo_Total;

Console.Write("Entre com o número da conta: ");
lstDadosConta.cod_conta = int.Parse(Console.ReadLine());
Conta = lstDadosConta.cod_conta;

Console.Write("Entre com o nome do titular: ");
lstDadosConta.des_titular = Console.ReadLine();
Titular = lstDadosConta.des_titular;

Console.Write("Haverá depósito inicial? (s/n) ");
lstDadosConta.deposito = Console.ReadLine();
Deposito = lstDadosConta.deposito;

if (Deposito == "s")
{
    Console.Write("Qual valor para depósito? ");
    lstDadosConta.vlr_deposito = decimal.Parse(Console.ReadLine());
    Valor_Saldo = lstDadosConta.vlr_deposito;
}
else
{
    Valor_Saldo = 0;
}

Console.WriteLine("Dados da conta: \n" + "Numero da conta: " + Conta + ", Titular da conta: " + Titular + ", Saldo: " + Valor_Saldo);
Console.ReadKey();

Console.WriteLine("Deseja depositar ou sacar? (Sacar/Depositar/Sair)");
lstDadosConta.opcao = Console.ReadLine();
Opcao = lstDadosConta.opcao;

if (Opcao == "Sacar")
{
    Console.WriteLine("Digite o valor para saque: ");
    lstDadosConta.vlr_saque = decimal.Parse(Console.ReadLine());
    Valor_Saque = lstDadosConta.vlr_saque;
    lstDadosConta.vlr_saldo = lstDadosConta.vlr_deposito;
    lstDadosConta.Sacar();
    Valor_Saldo_Total = lstDadosConta.vlr_saldo;
    Console.WriteLine("Dados da conta: \n" + "Saldo atual: " + Valor_Saldo_Total + ", Valor sacado: " + Valor_Saque + ", Valor antes do saque: " + Valor_Saldo);
}
else if (Opcao == "Depositar")
{
    Console.WriteLine("Digite o valor para depósito: ");
    lstDadosConta.vlr_deposito = decimal.Parse(Console.ReadLine());
    Valor_Deposito = lstDadosConta.vlr_deposito;
    lstDadosConta.vlr_saldo = lstDadosConta.vlr_deposito;
    lstDadosConta.Depositar();
    Valor_Saldo_Total = Valor_Saldo + Valor_Deposito;
    Console.WriteLine("Dados da conta: \n" + "Saldo atual: " + Valor_Saldo_Total + ", Valor depositado: " + Valor_Deposito);
}
else
{
    Console.WriteLine("Saldo atual: " + Valor_Saldo);
}
Console.ReadKey();

