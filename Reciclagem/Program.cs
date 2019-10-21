using System;
using System.Collections.Generic;
using Reciclagem.Models;
using Reciclagem.Interfaces;

namespace Reciclagem
{

    enum LixosEnum : int
    {
        CASCADEOVOS,
        COPOSDEVIDRO,
        GARRAFAPET,
        LATINHA,
        PAPELAO,
        PILHAS,
        SACOLAS
    };

    enum CategoriaEnum : int
    {
        DESCARTESESPECIAL,
        METAL,
        ORGANICO,
        PAPEL,
        PLÁSTICO,
        VIDRO
    };
    class Program
    {
        static void Main(string[] args)
        {
            bool querSair = false;
            string[] itensMenuPrincipal = Enum.GetNames(typeof(LixosEnum));
            
        }
    }
}
