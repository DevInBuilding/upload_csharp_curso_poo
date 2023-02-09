using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bytebank;


Console.WriteLine("Boas Vindas ao seu banco, ByteBank!\n");
//ContaCorrente conta1 = new ContaCorrente();
//conta1.titular = "André Silva";
//conta1.conta = "110123-X";
//conta1.numero_agencia = 123;
//conta1.nome_agencia = "Agência Central";
//conta1.saldo = 100;

//ContaCorrente conta2 = new ContaCorrente();
//conta2.titular = "Amanda Nogueira";
//conta2.conta = "10106-X";
//conta2.numero_agencia = 321;
//conta2.nome_agencia = "Agência Central";
//conta2.saldo = 100;

//Console.WriteLine("Saldo da Amanda pré-transferência: " + conta2.saldo);
//Console.WriteLine("Saldo do André  pré- Transferência: " + conta1.saldo);
//bool transferencia = conta1.Transferir(50, conta2);
//Console.WriteLine("Transferência realizada com sucesso? " + transferencia);
//Console.WriteLine("Saldo da Amanda pós-transferência: " + conta2.saldo);
//Console.WriteLine("Saldo do André  pós- Transferência: " + conta1.saldo);

bytebank.Titular.Cliente cliente = new bytebank.Titular.Cliente();
cliente.nome = "André Silva";
cliente.cpf = "546.321.789-33";
cliente.profissao = "Gerente de Vendas";

Console.WriteLine();