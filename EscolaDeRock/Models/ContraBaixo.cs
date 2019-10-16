using System;
using EscolaDeRock.Models;

namespace EscolaDeRock.Models
{
    public class ContraBaixo : InstrumentoMusical, IPercussao, IHarmonia
    {
        public bool ManterRitmo()
        {
            Console.WriteLine("Manter o ritmo do Contrabaixo.");
            return true;
        }

        public bool TrocarAcorde()
        {
            Console.WriteLine("Tocar acorde do Contrabaixo");
            return true;
        }
    }
}