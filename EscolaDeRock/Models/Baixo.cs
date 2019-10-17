using System;
using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    public class Baixo : InstrumentoMusical, IPercussao, IHarmonia
    {
        public bool ManterORitmo()
        {
            Console.WriteLine("Mantendo o ritmo do Baixo");
            return true;
        }

        public bool TocarAcordes()
        {
            Console.WriteLine("Tocando acordes do Baixo");
            return true;
        }

    }
}