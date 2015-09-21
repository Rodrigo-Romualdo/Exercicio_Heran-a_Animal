using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Animal
{
    class Passaro : Animal
    {
        private float VelocidadeVoo;

        // Contrutor do Passaro
        public Passaro(float VelocidadeV, string N, DateTime Dt, float Pe, float Ce) : base(N, Dt, Pe, Ce)
        {

        }

        // Metodos Get e Set
        public float GetVelocidadeVoo()
        {
            return VelocidadeVoo;
        }

        public void SetVelocidadeVoo(float velocidadeV)
        {
            VelocidadeVoo = velocidadeV;
        }


    }
}
