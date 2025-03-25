using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double diametro, area, raio;

            Console.WriteLine("Digite o diametro: ");
            diametro = double.Parse(Console.ReadLine());

            raio = diametro / 2;

            area = Math.PI * Math.Pow (raio,2);

            Console.WriteLine(" A area deste circulo é {0}", area.ToString("N2"));

            Console.ReadKey();
        }
    }
}
