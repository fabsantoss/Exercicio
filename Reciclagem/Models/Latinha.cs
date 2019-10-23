using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class Latinha : Lixeiras, IMetal
    {
        public string ReciclaMetal()
        {
            return this.GetType().Name;
        }
    }
}