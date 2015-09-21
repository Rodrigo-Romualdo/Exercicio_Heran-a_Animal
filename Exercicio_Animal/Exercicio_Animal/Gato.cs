using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Animal
{
    class Gato : Mamifero
    {

        private string NomeRaca;
        private bool castrado;


        public Gato(string NR, bool Cast, string NA, DateTime DT, float Pe, float Ce) : base(NA,DT,Pe,Ce)
        {

        }



        public string GetNomeRaca()
        {
            return NomeRaca;
        }

        public void SetNomeraca(string N)
        {
            NomeRaca = N;
        }

        public bool GetCastrado()
        {
            return castrado;
        }

        public void SetCastrado(bool Cast)
        {
            castrado = Cast;
        }


    }
}
