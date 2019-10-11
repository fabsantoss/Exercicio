using System;

namespace ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular;
        public int Agencia;
        public int Numero;
        private double _Saldo;

        public ContaCorrente(int Agencia, int Numero, Cliente Titular)
        {
            this.Titular = Titular;
            this.Agencia = Agencia;
            this.Numero = Numero;
            this._Saldo = 0.0;
        }

        public double Saldo
        {
            get { return _Saldo; }
        }

        public bool Deposito(double valor){
            if (valor >= 0)
            {
                this._Saldo += valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Saque(double valor){
            if (valor >= 0) {
                if (this._Saldo >= valor){
                    this._Saldo -= valor;
                    return true;
                } else {
                    return false;
                }
            }
            return false;
        } 

        public bool Transferencia(ContaCorrente contaDestino, double valor)
        {
            if (this.Saque(valor))
            {
                contaDestino.Deposito(valor);
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}

