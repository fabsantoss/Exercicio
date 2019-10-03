using System;

namespace ContaCorrente
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ContaCorrente - Sua Conta");
            Console.Write("Titular:");
            string titular = Console.ReadLine();
            Console.WriteLine("Agencia:");
            int agencia = int.Parse(Console.ReadLine());
            Console.WriteLine("Numero:");
            int numero = int.Parse(Console.ReadLine());
            
        }
    }
}
