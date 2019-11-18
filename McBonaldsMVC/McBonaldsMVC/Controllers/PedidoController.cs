using System;
using McBonaldsMVC.Models;
using McBonaldsMVC.Repositories;
using McBonaldsMVC.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace McBonaldsMVC.Controllers
{
    public class PedidoController : Controller
    {
        PedidoRepository pedidoRepository = new PedidoRepository();

        HamburguerRepository hamburguerRepository = new HamburguerRepository();
        ShakeRepository shakeRepository = new ShakeRepository();
        public IActionResult Index()
        {
            PedidoViewModel pmv = new PedidoViewModel();
            pmv.Hamburgueres = hamburguerRepository.ObterTodos();
            pmv.Shakes = shakeRepository.ObterTodos();
            return View (pmv);
        }

        

        

    
        public IActionResult Registrar(IFormCollection form)
        {
            ViewData["Action"] = "Index";
            Pedido pedido = new Pedido();

            var nomeShake = form["shake"];
            Shake shake = new Shake(nomeShake,shakeRepository.ObterPrecoDe(nomeShake));
            

            pedido.Shake = shake;


            var nomeHamburguer = form["hamburguer"];
            Hamburguer hamburguer= new Hamburguer(nomeHamburguer,hamburguerRepository.ObterPrecoDe(nomeHamburguer));
            

            pedido.Hamburguer = hamburguer;

            Cliente cliente = new Cliente(){
            Nome = form["nome"],
            Endereco = form["endereco"],
            Telefone = form["telefone"],
            Email = form["email"]
            };

            pedido.Cliente = cliente;

            pedido.DataPedido = DateTime.Now;

            pedido.PrecoTotal = hamburguer.Preco + shake.Preco;

            if(pedidoRepository.Inserir(pedido)){
                return View("Sucesso");
            }else {
                return View("Erro");
            }
        }
    }
}