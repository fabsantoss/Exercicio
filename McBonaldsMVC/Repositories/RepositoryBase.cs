namespace McBonaldsMVC.Repositories
{
    public class RepositoryBase
    {
        protected string ExtrairValorDoCampo(string nomeCampo, string linha)
        {
            var Chave = nomeCampo;
            var indiceChave = linha.IndexOf(Chave);

            var indiceTerminal = linha.IndexOf(",", indiceChave);

            var valor = "";

            if(indiceTerminal != -1)
            {
                valor = linha.Substring(indiceChave, indiceTerminal - indiceChave);
            }
            else
            {
                valor = linha.Substring(indiceChave);
            }
            System.Console.WriteLine($"Campo: {nomeCampo} e valor {valor}");
            return valor.Replace(nomeCampo +"=", "");
        }
    }
}