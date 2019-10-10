using System;

namespace Senaizinho
{
    public class Sala
    {
        public int CapacidadeAtual;
        public int CapacidadeTotal;
        public int numeroSala;
        public string[] Alunos ;
        public Sala(int numeroSala, int CapacidadeTotal)
        {
            this.numeroSala = numeroSala;
            this.CapacidadeTotal = CapacidadeTotal;
            this.CapacidadeAtual = this.CapacidadeTotal;
            this.Alunos = new string[CapacidadeTotal];
            
        }
            public string AlocarAluno(string NomeAluno)
            {
            
                int index = 0;
                if(CapacidadeAtual > 0)
                {  
                foreach(string aluno in this.Alunos)
                    {
                    if (aluno == "")
                    {
                        this.Alunos[index] = NomeAluno;
                        break;
                    }
                        index++;
                    }
                    this.CapacidadeAtual--;
                    return "Ok";
                } else
                {
                    return "Lotado";
                }
            }

            public string RemoverAluno(string nomeAluno)
            {
                int index = 0;

                if(this.CapacidadeAtual == this.CapacidadeTotal )
                {
                    return "Sala vazia";
                }

                foreach(string aluno in this.Alunos)
                {
                    if(nomeAluno == aluno)
                    {
                        this.Alunos[index] = "" ;
                        return "Ok";
                    }
                    index++;
                }
                return "Não encontrado";
            }

            public string MostraAlunos() 
            {
                string listaAlunos="";
                foreach(string aluno in this.Alunos)
                {

                    if( aluno != "")
                    {
                        listaAlunos = listaAlunos + aluno + " ";
                    }
                }
                listaAlunos.TrimEnd();
                return listaAlunos;
            }
    }
}