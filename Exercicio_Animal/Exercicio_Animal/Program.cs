using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Animal
{
    class Program
    {
        static void Main(string[] args)
        {

            // Teste
            Animal Teste = new Animal("Fargield", new DateTime(2010, 10, 02), 25, 30);

            // chamar o gaviao
            Gaviao Gav = new Gaviao(10.5f ,"Coritians", new DateTime(2013, 10, 02), 10, 30);

            if (Gav.Comer(5))
            {
                Console.WriteLine(" {0} Comeu: ", Gav.GetNome());
            }
            else
            {
                Console.WriteLine(" {0} tem capacidade de : {1} ", Teste.GetNome(), Teste.GetCapacidade_Estomago());
            }

            Console.WriteLine("A idade do Gav é " + Gav.RetornaIdade());
            


            /*
            

        //    Console.WriteLine("A Idade");
            Console.WriteLine(" A idade é : " + Teste.RetornaIdade());

            if (Teste.Comer(10))
            {
                Console.WriteLine(" {0} Comeu ", Teste.GetNome());
            }
            else
            {
                Console.WriteLine(" {0} tem capacidade de : {1} " , Teste.GetNome() , Teste.GetCapacidade_Estomago());
            }
            */

            Console.ReadKey();

        }
    }
}
