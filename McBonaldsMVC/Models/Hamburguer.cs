using Microsoft.Extensions.Primitives;

namespace McBonaldsMVC.Models
{
    public class Hamburguer : Produto
    {
        private StringValues stringValues;
        private double v;

        public Hamburguer()
        {
        }

        public Hamburguer(StringValues stringValues, double v)
        {
            this.stringValues = stringValues;
            this.v = v;
        }
    }
}