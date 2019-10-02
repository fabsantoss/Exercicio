using System;

namespace Usuario
{
    class Program
    {
        static void Main(string[] args)
        {
            string admLogin = "admin";
            string admPasswd  = "admin";
            Console.Write("Nome de usuario: ");
            string Login = Console.ReadLine();
            Console.WriteLine("Senha: ");
            string passwd =Console.ReadLine();

            if (Login == admLogin && passwd == admPasswd){
                Console.WriteLine("Bem vindo Admin.");
            }else {
                Console.WriteLine("Olá usuário");
            }
        }
    }
}

