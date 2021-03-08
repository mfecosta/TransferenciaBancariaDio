using System;
using System.Collections.Generic;
using System.Text;

namespace Conta_Bancaria.Classes
{
    class Conta
    {
        private string Nome { get; set; }
        private double Saldo { get; set; }
        private double Credito { get; set; }
        private TipoConta TipoConta { get; set; }

        public Conta(string nome, double saldo, double credito, TipoConta tipoConta)
        {
            this.Nome = nome;
            this.Saldo = saldo;
            this.Credito = credito;
            this.TipoConta = tipoConta;
        }

        public bool Sacar(double ValorSaque)
        {
            if (Saldo - ValorSaque < Credito * -1)
            {
                Console.WriteLine("Saldo insufuciente");
                return false;
            }
            Saldo -= ValorSaque;

            Console.WriteLine("Saldo atual da conta de " + Nome + " é " + Saldo );
            return true;
        }

        public void Depositar(double deposito)
        {
            Saldo += deposito;

            Console.WriteLine("Saldo atual da conta de " + Nome + " é " + Saldo);

        }

        public void Transferir(double valorTransferencia,Conta contaDestino)
        {
            if (this.Sacar(valorTransferencia))
            {
                contaDestino.Depositar(valorTransferencia);
            }
            
        }
        public override string ToString()
        {
            return "Dados da sua conta " + Nome + " saldo " + Saldo + " credito " + Credito ;
        }
    }

    public enum TipoConta
    {
        PessoaFisica =1,
        PessoaJuridica =2
    }

    
}
