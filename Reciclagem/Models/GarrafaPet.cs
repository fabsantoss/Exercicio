using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class GarrafaPet : Lixeiras, IPlastico
    {
        public string ReciclaPlastico()
        {
            return this.GetType().Name;
        }
    }
}