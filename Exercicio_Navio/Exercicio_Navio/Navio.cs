using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Navio
{
    enum EstadoNavio { Inoperante, MuitoDanificado, Danificado, Perfeito };
    // CLass PAI
    class Navio
    {
        private string Nome;
        protected int QtdTripulantes;
        protected Enum Estado;
        
        
        public string GetNome()
        {
            return Nome;
        }

        public void SetNome(string N)
        {
            Nome = N;
        }

        public int GetQtdTripulantes()
        {
            return QtdTripulantes;
        }

        public void SetQtdTripulantes(int QtdT)
        {
            QtdTripulantes = QtdT;
        }

        public Enum GetEstado()
        {
            return Estado;
        }

        public void SetEstado(Enum Est)
        {
            Estado = Est;
        }

        // Construtor 
        public Navio(string N)
        {
            Nome = N;
        }

        // Construtor 2
        public Navio(string N, int Qtd)
        {
            Nome = N;
            QtdTripulantes = Qtd;
        }







    }
}
