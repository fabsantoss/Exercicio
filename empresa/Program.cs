using System;

namespace empresa
{
    class Program
    {
        static void Main(string[] args)
        {
        double salario;
        double novo;
        double aumento = 0.3;

        Console.Write("Digite seu salario: ");
        salario = double.Parse(Console.ReadLine());

        novo = (salario * aumento) + salario;
        
        if (salario < 500 ){
                Console.WriteLine("Seu novo salário é " + novo);
        }  else if (salario > 500) {
                Console.WriteLine("Não houve um reajuste no seu salario" );
        }
        
        }
    }
}
