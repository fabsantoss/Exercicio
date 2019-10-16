using System;
using EscolaDeRock.Models;

namespace EscolaDeRock.Models
{
    public class Teclado : IMelodia, IHarmonia
    {
        public bool TocarAcordes()
        {
            Console.WriteLine("Tocando acordes do Teclado");
            return true;
        } 

        public bool TocarSolo()
        {
            Console.WriteLine("Tocando solo  do teclado");
            return true;
        }
    }
}