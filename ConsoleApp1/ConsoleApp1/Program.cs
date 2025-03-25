using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        { 
           
            double base1, altura, area;

            Console.WriteLine("Qual o tamanho da base?");
            base1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual a altura?");
            altura = double.Parse(Console.ReadLine());

            area = base1 * altura;

            Console.WriteLine(" A base deste retangulo é: {0}",area);

            Console.ReadKey();
            

        }
    }
}
