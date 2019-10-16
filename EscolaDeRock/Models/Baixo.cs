using System;
using EscolaDeRock.Models;
using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Interfaces
{
    public class Baixo : InstrumentoMusical, IPercussao, IHarmonia
    {
        public bool ManterORitmo()
        {
            throw new NotImplementedException();
        }

        public bool ManterRitmo()
        {
            Console.WriteLine("Mantendo o ritmo do Baixo");
            return true;
        }

        public bool TrocarAcordes()
        {
            Console.WriteLine("Tocando acordes do Baixo");
            return true;
        }

        bool IHarmonia.TocarAcordes()
        {
            throw new NotImplementedException();
        }
    }
}