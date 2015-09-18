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
            Animal Teste = new Animal("Fargield", new DateTime(2010, 09, 02), 25, 30);

        //    Console.WriteLine("A Idade");
            Console.WriteLine(" A idade é : " + Teste.RetornaIdade());


            Console.ReadKey();

        }
    }
}
