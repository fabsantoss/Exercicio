using System;

namespace Byte_Bank
{
    public class cliente 
    {
            /*Atribudos d classe*/
            public string Cpf;
            public string Nome;
            public string Email;
            public string Senha;
            
            /*Construtor */
            public cliente(string Nome, string Cpf, string Email){
                this.Nome = Nome;
                this.Cpf = Cpf;
                this.Email = Email;
            }
        
        public bool TrocaSenha(string Senha){
            if ((Senha.Length > 6) && (Senha.Length < 16)){
                this.Senha = Senha;
                return true;
            } else {
                return false;
            }
        }
    }   
}