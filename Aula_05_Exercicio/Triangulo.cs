using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_05_Exercicio
{
    internal class Triangulo : Forma
    {
        public virtual double Calculo()
        {
            Console.WriteLine("Digite a base: ");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura: ");
            double y = double.Parse(Console.ReadLine());

            var area = (x * y)/2;

            Console.WriteLine(area);
            
            return area;
            //area = (base*altura) / 2;
        }
    }
}
