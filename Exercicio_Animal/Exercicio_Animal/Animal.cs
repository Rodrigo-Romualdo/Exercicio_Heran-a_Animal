using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Animal
{
    class Animal
    {
        // Criano Uma lista
        List<Animal> Lista_Animal = new List<Animal>();


        // Atributo   
        private string Nome;
        private DateTime DataNascimento;
        private float Peso;
        private float Capacidade_Estomago;
        
        // get e Set
        public string GetNome()
        {
            return Nome;
        }

        public void SetNome(string N)
        {
            Nome = N;
        }
        
        public DateTime GetDataNascimento()
        {
            return DataNascimento;
        }

        public void SetDataNascimento(DateTime Dt)
        {
            DataNascimento = Dt;
        }

        public float GetPeso()
        {
            return Peso;
        }
        
        public void SetPeso(float Pe)
        {
            Peso = Pe;
        }

        public float GetCapacidade_Estomago()
        {
            return Capacidade_Estomago;
        }

        public void SetCapacidade_Estomago(float Ce)
        {
            Capacidade_Estomago = Ce;
        }
        // Contrutor
        public Animal(string N, DateTime Dt, float Pe, float Ce)
        {
            Nome = N;
            DataNascimento = Dt;
            Peso = Pe;
            Capacidade_Estomago = Ce;
        }
        // Construtor Vazio
        public Animal()
        {

        }

        /*
        
        public int GetData_Ano()
        {
            return Data_Ano;
        }
        
        public void SetData_Ano(int Data_Ano)
        {
            this.Data_Ano = Data_Ano;
        }

        /*/

        // Retorna Idade
        public int RetornaIdade()
        {
            int Ano_Nasc;
            int Ano_Atual;
            int Idade;

            DateTime Hoje = new DateTime();
            Hoje = DateTime.Today;
            Ano_Nasc = this.DataNascimento.Year;
            Ano_Atual = Hoje.Year;

            Idade = Ano_Atual - Ano_Nasc;
            
            return Idade;

            
        }

        public bool  Comer(float qtd)
        {
            
            if (qtd <= Capacidade_Estomago)
            {
                Capacidade_Estomago -= qtd;
                return true;
            }
            else
            {
                Console.WriteLine(" Animal cheio");
                    return false;
                }
            }
            

           




    }
}
