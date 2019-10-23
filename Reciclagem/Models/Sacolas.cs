using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class Sacolas : Lixeiras, IPlastico
    {
        public string ReciclaPlastico()
        {
            return this.GetType().Name;
        }
    }
}