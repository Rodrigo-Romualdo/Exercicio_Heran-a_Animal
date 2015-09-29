using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Navio
{
    class NavioDeGuerra : Navio
    {

        protected float Blindagem;
        protected float Ataque;


        public float GetBlindagem()
        {
            return Blindagem;
        }
        public void SetBlindagem(float Blind)
        {
            Blindagem = Blind;
        }
        public float GetAtaque()
        {
            return Ataque;
        }
        public void SetAtaque(float Ataq)
        {
            Ataque = Ataq;
        }

        public NavioDeGuerra(float Blind,float Ataq,string N, int Qtd) : base(N, Qtd)
        {
            Blindagem = Blind;
            Ataque = Ataq;
        }



    }
}
