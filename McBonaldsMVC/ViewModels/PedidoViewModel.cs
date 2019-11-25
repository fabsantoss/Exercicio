using System.Collections.Generic;
using McBonaldsMVC.Models;
using McBonaldsMVC.ViewModels;

namespace McBonaldsMVC.ViewModel
{
    public class PedidoViewModel : BaseViewModel 
    {
        public List<Hamburguer> Hamburgueres {get;set;}
        public List<Shake> Shakes {get;set;}

        public Cliente cliente {get;set;}

        public string NomeCliente{get;set;}

        public PedidoViewModel()
        {
            this.Hamburgueres = new List<Hamburguer>();
            this.Shakes = new List<Shake>();
            this.cliente = new Cliente();
            this.NomeCliente = "Jovem";
        }

        
    }
}