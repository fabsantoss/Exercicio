using System.Collections.Generic;


namespace Reciclagem.Models
{
    public class Deposito
    {
        public static Dictionary<int,Lixeiras> Lixos = new Dictionary<int, Lixeiras>()
        {
            { 1, new CascaDeOvos() },
            { 2, new CoposDeVidro() },
            { 3, new GarrafaPet() },
            { 4, new Latinha() },
            { 5, new Papelao()},
            { 6, new Pilhas()},
            { 7, new Sacolas()}
        };
    }
}