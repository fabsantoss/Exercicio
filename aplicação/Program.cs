using System;

namespace aplicação
{
    class Program
    {
        static void Main(string[] args)
        { int num = 1;
                        
        while (num != 0){
            Console.Write("Digite um número ou zero para parar:");
            num = int.Parse(Console.ReadLine());
            
            if ((num % 2) != 0){
            Console.WriteLine("O número é par.");
            } else {
                Console.WriteLine("O número é impar");
            }
        }
            
        }
    }
}
