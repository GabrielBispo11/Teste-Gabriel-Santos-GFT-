using System;
using Desafio_GABSANTOS_START_.Conta;

namespace Conta
{
    class Program
    {
        static void Main(string[] args)
        {
            double ContaCorrente = 3000;
            ContaCorrente contaCorrente = new ContaCorrente;
            contaCorrente.rendimento(ContaCorrente);
            System.Console.WriteLine($"O saldo na Conta Corrente é de {contaCorrente.rendimento(ContaCorrente)}");

            double ContaPoupanca = 2000;
            ContaPoupanca contaPoupanca = new ContaPoupanca;
            contaPoupanca.rendimento(ContaPoupanca);
            System.Console.WriteLine($"O saldo na Conta Corrente é de {contaPoupanca.rendimento(ContaPoupanca)}");

        }
    }
}
