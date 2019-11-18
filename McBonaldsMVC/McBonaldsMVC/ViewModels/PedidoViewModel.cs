using System.Collections.Generic;
using McBonaldsMVC.Models;

namespace McBonaldsMVC.ViewModel
{
    public class PedidoViewModel
    {
        public List<Hamburguer> Hamburgueres {get;set;}
        public List<Shake> Shakes {get;set;}

        public PedidoViewModel()
        {
            this.Hamburgueres = new List<Hamburguer>();
            this.Shakes = new List<Shake>();
        }

        
    }
}