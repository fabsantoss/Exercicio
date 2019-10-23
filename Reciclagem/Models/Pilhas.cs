using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class Pilhas : Lixeiras, IDescarteEspecial
    {
        public string DescarteEspecial()
        {
            return this.GetType().Name;
        }
    }
}