using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class CascaDeOvos : Lixeiras, IOrganico
    {
        public string ReciclaOrganico()
        {
            return this.GetType().Name;
        }
    }
}