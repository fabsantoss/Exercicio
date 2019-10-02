using System;

namespace media
{
    class Program
    {
        static void Main(string[] args)
        {
        double nota1, nota2, nota3, nota4, media;

            Console.Write("Digite a 1º nota: ");
            nota1 = double.Parse(Console.ReadLine());
            Console.Write("Digite a 2º nota: ");
            nota2 = double.Parse(Console.ReadLine());
            Console.Write("Digite a 3º nota: ");
            nota3 = double.Parse(Console.ReadLine());
            Console.Write("Digite a 4º nota: ");
            nota4 = double.Parse(Console.ReadLine());
            
            media = (nota1 + nota2 + nota3 + nota4) / 4;

            Console.WriteLine("Sua média é " + media);

            if (media >= 7.0 ){
                Console.WriteLine("aprovado");
            }  else if (media < 7) {
                Console.WriteLine("Reprovado");
            }
        }
    }
}
