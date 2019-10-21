using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class Pilhas : IDescarteEspecial
    {
        public bool DescarteEspecial()
        {
            Console.WriteLine("Lixeira: Cinza");
            Console.WriteLine("Lixo: Pilhas");
            return true;
        }
    }
}