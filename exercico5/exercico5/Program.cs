using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercico5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o lado 1 do triangulo");
            double l1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o lado 2 do triangulo");
            double l2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o lado 1 do triangulo");
            double l3 = double.Parse(Console.ReadLine());

            double s1 = l1 + l2;
            double s2 = l1 + l3;
            double s3 = l2 + l3;

            if (l1 + l2 < l3 || l1 + l3 < l2 || l2 + l3 < l1)
                Console.WriteLine("Não é um triângulo");

            else
                Console.WriteLine("é um triangulo");
            
                


        }
    }
}
