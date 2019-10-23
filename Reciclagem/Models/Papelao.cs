using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class Papelao : Lixeiras, IPapel
    {
        public string ReciclaPapel()
        {
            return this.GetType().Name;
        }
    }
}