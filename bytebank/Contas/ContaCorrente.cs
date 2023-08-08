using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bytebank.Titular;
namespace bytebank.Contas
{
    public class ContaCorrente
    {
        private int numero_agencia;
        public int Numero_Agencia
        { 
            get {return this.numero_agencia;}
            internal set {
                    if(value > 0)
                        {
                            this.numero_agencia = value;
    }
}
}



        public string nome_agencia;
        //public string conta;
        //private string conta;
         public string Conta { get; set; }
        //public string titular;
        private double saldo = 100;

        public Cliente titular { get; set; }



        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            else
            {
                Sacar(valor);
                destino.Depositar(valor);
                return true;
            }
        }
        public void SetSaldo (double valor)
        {
            if(valor < 0)
            {
                return;
            }
            else
            {
                this.saldo = valor;
            }
        }

        public double GetSaldo()
        {
            return this.saldo;
        }
        //public void ExibirDadosDaConta()
        //{
        //    Console.WriteLine("Titular :" + titular);
        //    Console.WriteLine("Conta :" + conta);
        //    Console.WriteLine("Número Agência :" + numero_agencia);
        //    Console.WriteLine("Nome Agência :" + nome_agencia);
        //    Console.WriteLine("Saldo: " + saldo);
        //}

        public Cliente(int numero_agencia, string numero_conta)
        {
            this.Numero_Agencia= numero_agencia;
            this.Conta = numero_conta;
            }

    }
}



