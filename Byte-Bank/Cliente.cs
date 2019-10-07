using System;

namespace ByteBank
{
    public class Cliente
    {
        public string Nome;
        public string Cpf;
        public string Email;
        public string Senha;

        public Cliente(string nome,string cpf,string email){
            this.Nome = nome;
            this.Cpf = cpf;
            this.Email = email;
        }

        public bool TrocaSenha(string senha){
            if ((senha.Length > 6) && (senha.Length < 16)){
                this.Senha = senha;
                return true;
            }else {
                return false;
            }
        }
    }
}