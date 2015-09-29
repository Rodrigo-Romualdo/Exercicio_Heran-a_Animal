using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Navio
{
    class NavioMercante : Navio
    {

        private float Carga;
        private float CapacidadeCarga;

        public float GetCarga()
        {
            return Carga;
        }
        public void SetCarga(float Car)
        {
            Carga = Car;
        }
        public float GetCapacidadeCarga()
        {
            return CapacidadeCarga;
        }
        public void SetCapacidadeCarga(float CapCarga)
        {
            CapacidadeCarga = CapCarga;
        }

        public NavioMercante(float Car, float CapCarga, string N, int Qtd) : base(N, Qtd)
        {
            Carga = Car;
            CapacidadeCarga = CapCarga;
        }


        
        public void Carregamento()
        {
            float VolumeNavio = 0;
            VolumeNavio = (GetCarga() / GetCapacidadeCarga());


            Console.WriteLine("Nome: " + GetNome() + "Quantidade Tripulantes: " + GetQtdTripulantes() + "Volume do Navio: " + VolumeNavio);

        }




    }
}
