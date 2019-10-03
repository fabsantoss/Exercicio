using System;

namespace Conta
{
    public class ContaCorrente{
        public string Titular;
        public int Agencia;
        public int Numero;
        public double Saldo;

        public ContaCorrente(int Agencia, int Numero, string Titular){
            this.Agencia = Agencia;
            this.Numero = Numero;
            this.Titular = Titular;
            Saldo = 0;
        }
        
    }
}