using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite o 1º numero");
            double numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o 2º numero");
            double numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o 3º numero");
            double numero3 = int.Parse(Console.ReadLine());

            if (numero2 == numero3 && numero3 == numero1)

                Console.WriteLine(" Os numeros são iguais");
            else
                if (numero1 > numero2 && numero1 > numero3)
            {
                Console.WriteLine("O 1º numero é o maior");
            }
            else

            if (numero2 > numero3 && numero2 > numero1)

                Console.WriteLine("O 2º numero é maior");


            else
                Console.WriteLine(" O 3º numero é maior");

            Console.ReadKey();
        }
    }
}
