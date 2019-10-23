using System;
using Reciclagem.Models;
using Reciclagem.Interfaces;
using Reciclagem.Enums;
using System.Linq;
using Reciclagem.View;

namespace Reciclagem
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool querSair = false;
            do
            {
                System.Console.WriteLine("São lixos descartados:");
                int codigo = MenuUtils<LixosEnum>.ExibirMenuPadrao();
                Reciclar(Deposito.Lixos[codigo]);
            
            } while(!querSair);
            
        }

        public static void Reciclar(Lixeiras lixo)
        {

            Type tipoLixo = lixo.GetType().GetInterfaces().FirstOrDefault();

            if (tipoLixo.Equals(typeof(IPapel)))
            {
                IPapel lixoConvertido = (IPapel)lixo;
                Console.BackgroundColor = ConsoleColor.Blue;
                System.Console.WriteLine($"{lixoConvertido.ReciclaPapel()} Este deve ir para a lixeira Azul ");
                Console.ResetColor();

            }
            else if (tipoLixo.Equals(typeof(IMetal)))
            {
                IMetal lixoConvertido = (IMetal) lixo;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
                System.Console.WriteLine($"{lixoConvertido.ReciclaMetal()} Este lixo deve ir para a lixeira Amarela ");
                Console.ResetColor();
            }
            else if (tipoLixo.Equals(typeof(IPlastico)))
            {
                IPlastico lixoConvertido = (IPlastico) lixo;
                Console.BackgroundColor = ConsoleColor.Red;
                System.Console.WriteLine($"{lixoConvertido.ReciclaPlastico()} Este lixo deve ir para a lixeira Vermelha");
                Console.ResetColor();
            }
            else if (tipoLixo.Equals(typeof(IVidro)))
            {
                IVidro lixoConvertido = (IVidro) lixo;
                Console.BackgroundColor = ConsoleColor.Green;
                System.Console.WriteLine($"{lixoConvertido.ReciclaVidro()} Este lixo deve ir para a lixeira Verde");
                Console.ResetColor();
            }
            else if (tipoLixo.Equals(typeof(IOrganico)))
            {
                IOrganico lixoConvertido = (IOrganico) lixo;
                Console.ForegroundColor =ConsoleColor.Green;
                Console.BackgroundColor = ConsoleColor.Black;
                System.Console.WriteLine($"{lixoConvertido.ReciclaOrganico()} Este lixo deve ir para a composteira ");
                Console.ResetColor();
            }
            else if (tipoLixo.Equals(typeof(IDescarteEspecial)))
            {
                IDescarteEspecial lixoConvertido =(IDescarteEspecial) lixo;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Gray;
                System.Console.WriteLine($"{lixoConvertido.DescarteEspecial()} Este lixo deve ir para o descarte especial");
                Console.ResetColor();
            }
            else
            {
                System.Console.WriteLine("Não identificado!");
            }
            System.Console.WriteLine("Aperte ENTER para voltar ao menu");
            Console.ReadLine();
        }
    }
}
