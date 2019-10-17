using System;
using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    public class ContraBaixo : InstrumentoMusical, IPercussao, IHarmonia
    {
        public bool ManterORitmo()
        {
            Console.WriteLine("Manter o ritmo do Contrabaixo.");
            return true;
        }

        public bool TocarAcordes()
        {
            Console.WriteLine("Tocar acorde do Contrabaixo");
            return true;
        }
    }
}