using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class CoposDeVidro : Lixeiras, IVidro
    {
        public string ReciclaVidro()
        {
            return this.GetType().Name;
        }
    }
}