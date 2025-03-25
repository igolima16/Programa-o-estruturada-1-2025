using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace exercico3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Valor do Produto 1:");
            double p1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Qantidade do produto:");
            double q1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor do Produto 2:");
            double p2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Qantidade do produto:");
            double q2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor do Produto 3:");
            double p3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Qantidade do produto:");
            double q3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor do Produto 4:");
            double p4 = double.Parse(Console.ReadLine());

            Console.WriteLine("Qantidade do produto:");
            double q4 = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor do Produto 5:");
            double p5 = double.Parse(Console.ReadLine());

            Console.WriteLine("Qantidade do produto:");
            double q5 = double.Parse(Console.ReadLine());

            double total = (p1 * q1) + (p2 * q2) + (p3 * q3) + (p4 * q4) + (p5 * q5);

            Console.WriteLine("Digite o valor que o cliente pagou");
            double pag = double.Parse(Console.ReadLine());

            double vf = pag - total;

            if (pag >= total)
               Console.WriteLine("O valor total foi {0} e você pagou {1}, O troco é {2}" ,total, pag, vf);

            else
            Console.WriteLine("O valor total foi {0} e você pagou {1}, esta faltando {2}" ,total, pag, vf);

            Console.ReadKey();

        }
    }
}
