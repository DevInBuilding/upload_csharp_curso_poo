using bytebank;
using bytebank.Titular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank
{
    public class ContaCorrente
    {
        // Attributes
        public Cliente Titular { get; set; }

        public string _conta;
        public string Conta {
            get { return _conta; }
            set
            {
                if(value != null)
                {
                    _conta= value;
                }
            }
        }
        public int _numero_agencia;
        public int Numero_Agencia {
            get 
            {
                return _numero_agencia;
            }
            set 
            {
                if(value > 0)
                {
                    _numero_agencia= value;
                }
            }
        }
        public string Nome_Agencia { get; set; }

        private double saldo;
        public double Saldo
        {
            get 
            { 
                return saldo; 
            }
            set 
            {
                if(value < 0)
                {
                    return;
                }
                saldo = value;
            }
        }

        // Constructor
        public ContaCorrente(int numero_agencia, string conta)
        {
            Numero_Agencia = numero_agencia;
            Conta = conta;
        }

        // Methods
        public bool Sacar(double valor)
        {
            if (saldo < valor)
            {
                return false;
            }
            if (valor < 0)
            {
                return false;
            }
            else
            {
                saldo = saldo - valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            if (valor < 0)
            {
                return;
            }
            saldo = saldo + valor;
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            if (valor < 0)
            {
                return false;
            }
            else
            {
                saldo = saldo - valor;
                destino.saldo = destino.saldo + valor;
                return true;
            }
        }
                
    }
}