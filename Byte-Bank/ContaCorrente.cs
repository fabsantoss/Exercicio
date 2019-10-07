using System;

namespace ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular;
        public int Agencia;
        public int Numero;
        public double Saldo;

        public ContaCorrente(int Agencia,int Numero,Cliente Titular){
            this.Titular = Titular;
            this.Agencia = Agencia;
            this.Numero = Numero;
            this.Saldo = 0.0;
        }

        public double Deposito(double valor){
            return this.Saldo += valor;
        }

        public bool Saque(double valor){
            if(this.Saldo >= valor){
                this.Saldo -= valor;
                return true;
            }else {
                return false;
            }
        }

        public bool Transferencia(ContaCorrente contaDestino, double valor){
            if(this.Saque(valor)){
                contaDestino.Deposito(valor);
                return true;
            }else {
                return false;
            }
        }
    }
        
}

