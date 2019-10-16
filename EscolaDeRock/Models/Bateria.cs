using System;
using EscolaDeRock.Models;

namespace EscolaDeRock.Models
{
    public class Bateria: InstrumentoMusical, IPercussao
    {
        public bool ManterRitmo()
        {
            Console.WriteLine("Mantendo o ritmo da bateria.");
            return true;
        }
        
    }
}