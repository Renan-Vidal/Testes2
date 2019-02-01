using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSoma
{
    class Program
    {
        static void Main(string[] args)
        {
            int A;
            int B;
            Console.WriteLine("valor de A:");
            A = int.Parse(Console.ReadLine());


            Console.WriteLine("valor de B:");
            B = int.Parse(Console.ReadLine());

            A = A * B;

            Console.WriteLine("O valor de A * B é: "+A);
            Console.ReadKey();
        }
    }
}