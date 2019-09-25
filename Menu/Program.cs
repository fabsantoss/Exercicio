using System;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string opção;

        Console.WriteLine("Calcule a area");
        Console.WriteLine("1- para Quadrado");
        Console.WriteLine("2- para Triângulo");  
        Console.WriteLine("3- para Circulo");     
        Console.WriteLine("4 -para Trapézio");       
        Console.WriteLine("5- para Retângulo");      
        Console.WriteLine("6 -para Losango");  
        opção = Console.ReadLine();

        switch (opção){
        case "1":
            Console.WriteLine("Área do Triangulo");
            Console.Write("Entre com a base:");
            double baseTri =double.Parse(Console.ReadLine());
            Console.Write("Entre com a Altura: ");
            double altTri = double.Parse(Console.ReadLine());
            double areaTri = (baseTri * altTri) / 2;
            Console.WriteLine("A área do triangulo é: " + areaTri);
            break;

        case "2":
            Console.WriteLine("Área do Quadrado");
            Console.Write("Qual o lado do Quadrado? ");
            double ladoQuad = double.Parse(Console.ReadLine());
            double areQuad = ladoQuad * ladoQuad;
            Console.WriteLine("A área do quadrado é: " + areQuad);
            break;

        case "3":
        Console.WriteLine("Área do circulo");
        Console.Write("Qual o valor do pi ?");
        double pi = double.Parse(Console.ReadLine());
        Console.Write("Qual o valor do raio ?");
        double raio = double.Parse(Console.ReadLine());
        double areacir = pi * raio * raio;
        Console.WriteLine("A área do quadrado é: " + areacir);
        break;

        case "4":
        Console.WriteLine("Área do Trapézio");
        Console.Write("Entre com o valor da base menor:");
        double basemenor = double.Parse(Console.ReadLine());
        Console.Write("Entre com o valor da base maior:");
        double basemaior = double.Parse(Console.ReadLine());
        Console.Write("Entre com o valor da altura:");
        double altura = double.Parse(Console.ReadLine());
        double areatrap = (basemenor + basemaior) *  altura / 2;
        Console.WriteLine("A area do trapezio é: " + areatrap);
        break;

        case "5":
        Console.WriteLine("Área do retângulo");
        Console.Write("Entre com o valor da base:");
        double base = double.Parse(Console.ReadLine());
        Console.Write("Entre com o valor da altura");
        double altura = double.Parse(Console.ReadLine());
        double area = double.Parse(Console.ReadLine());
        double area = base * altura;
        Console.WriteLine("A area do retângulo é: " + areatr);

        }
        
    }
  }
}