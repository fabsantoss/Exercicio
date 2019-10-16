using System;
using EscolaDeRock.Models;

namespace EscolaDeRock.Models
{
    public class Tambores : InstrumentoMusical, IPercussao
    {
        public bool ManterORitmo()
        {
            Console.WriteLine("Mantendo o ritmo do tambores.");
            return true;
        } 
    }
}