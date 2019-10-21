using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class GarrafaPet : IPlastico
    {
        public bool ReciclaPlastico()
        {
            Console.WriteLine("Lixeira: Vermelha");
            Console.WriteLine("GarrafaPet");
            return true;
        }
    }
}