using System;
using EscolaDeRock.Models;


namespace EscolaDeRock.Models
{
    public class Violao : InstrumentoMusical, IHarmonia
    {
        public bool ManterRitmo()
        {
            Console.WriteLine("Mantendo ritmo do violão.");
            return true;
        }

        public bool TocarAcordes()
        {
            Console.WriteLine("Tocar acordes de violão.");
            return true;
        }

        public bool TocarSolo()
        {
            Console.WriteLine("Tocando solo de violão.");
            return true;
        }
    }
}