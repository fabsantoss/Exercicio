using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class CascaDeOvos : IOrganico
    {
        public bool ReciclaOrganico()
        {
            Console.WriteLine("Lixeira: Preta");
            Console.WriteLine("Lixo: Casca de ovo");
            return true;
        }
    }
}