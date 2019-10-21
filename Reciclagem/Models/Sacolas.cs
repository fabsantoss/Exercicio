using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class Sacolas : IPlastico
    {
        public bool ReciclaPlastico()
        {
            Console.WriteLine("Lixeira: Vermelha");
            Console.WriteLine("Lixo: Sacola Plastica");
            return true;
        }
    }
}