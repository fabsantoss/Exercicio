namespace Senaizinho
{
    public class Sala
    {
        public int CapacidadeAtual;
        public int CapacidadeTotal;
        public int numeroSala;
        public string[] Alunos = new string [10];
        public Sala(int CapacidadeAtual, int CapacidadeTotal)
        {
            this.CapacidadeAtual = CapacidadeAtual;
            this.CapacidadeTotal = CapacidadeTotal;
            
        }
            public string AlocarAluno(string Nome){
                if(CapacidadeAtual <= CapacidadeAtual){  
                    return  System.Console.WriteLine("Sua matricula foi realizada");
                } else{
                    return System.Console.WriteLine("Não foi possivel realizar sua matricula");
                }
            }

            public string RemoverAluno(string Nome){
                

            }

            public string MostraAlunos(string Alunos){
                
            }
    }
}