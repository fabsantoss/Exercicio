using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class CoposDeVidro : IVidro
    {
        public bool ReciclaVidro()
        {
            Console.WriteLine("Lixeira: Verde");
            Console.WriteLine("Lixo: Copo de Vidro");
            return true;
        }
    }
}