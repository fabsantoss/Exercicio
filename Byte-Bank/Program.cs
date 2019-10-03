using System;

namespace Byte_Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ByteBank - Cadastro do Cliente:");
            Console.Write("Nome:");
            string nome = Console.ReadLine();
            Console.Write("CPF:");
            string cpf = Console.ReadLine();
            Console.Write("Email:");
            string email = Console.ReadLine();

            cliente cliente1 = new cliente (nome,cpf,email);

            bool trocouSenha = false;
            do{
                Console.Write("Senha:");
                string senha = Console.ReadLine();
                trocouSenha = cliente1.TrocaSenha(senha);
                if (trocouSenha) {
                    Console.WriteLine("Senha alterada com sucesso!");
                } else {
                    Console.WriteLine("Senha invalida");
                }
            } while(!trocouSenha);
        }   
    }
}
