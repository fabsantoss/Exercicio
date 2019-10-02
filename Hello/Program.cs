using System;

namespace Hello
{
    class Program
    { 
        static void Main(string[] args)
        {
        double sala1;
        double novo;
        double aumento = 0.3;

        Console.Write("Digite seu salario:");
        sala1= double.Parse(Console.ReadLine());
    
    novo = (aumento * sala1) +sala1;

    if (sala1 < 500){
        Console.WriteLine("Seu salário atual é" + novo);
    }else if (sala1 > 500) {
        Console.WriteLine("Não houve alteração no salário");
    }
        }
    }
}
