using System;

namespace ByteBank
{

    /*Classe declarada */
    public class Cliente
    {

        /*Propriedade da classe */
        public string _Nome;
        public string _Cpf;
        public string _Email;
        private string _Senha;


        /*mostra a senha mas nao deixa trocar a senha */
        public string Senha 
        {
            get {return _Senha;}
        }
        /******************************************* */

        /*mostra e deixa o usuario trocar */
        public string Cpf
        {
            get{ return _Cpf;}
            set{ _Cpf = value;}
        }

        public string Email
        {
            get{return _Email;}
            set{ _Email = value;}
        }
        /******************************************** */


        /*Construtor */
        public Cliente(string nome,string cpf,string email){
            this._Nome = nome;
            this._Cpf = cpf;
            this._Email = email;
        }


        /*Metodo de Acesso */
        public bool TrocaSenha(string senha){
            if ((senha.Length > 6) && (senha.Length < 16)){
                this._Senha = senha;
                return true;
            }else {
                return false;
            }
        }
    }
}