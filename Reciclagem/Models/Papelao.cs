using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class Papelao : IPapel
    {
        public bool ReciclaPapel()
        {
            Console.WriteLine("Lixeira: Azul");
            Console.WriteLine("Lixo: Papelão");
            return true;
        }
    }
}