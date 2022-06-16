using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_05_Exercicio
{
    internal class Circulo
    {
        public virtual double Calculo()
        {
            //area * 3.14 * (raio**2)
            const double pi = 3.14;

            Console.WriteLine("Digite o raio: ");
            double y = double.Parse(Console.ReadLine());

            var area = (pi * (y * y));

            Console.WriteLine(area);

            return area;
            
        }

        
    }
}
