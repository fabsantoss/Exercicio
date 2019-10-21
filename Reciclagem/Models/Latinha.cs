using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class Latinha : IMetal
    {
        public bool ReciclaMetal()
        {
            Console.WriteLine("Lixeira: Amarelo");
            Console.WriteLine("Lixo: Latinha");
            return true;
        }
    }
}