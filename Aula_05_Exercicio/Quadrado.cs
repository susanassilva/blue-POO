using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_05_Exercicio
{
    internal class Quadrado : Forma
    {
        public virtual double Calculo()
        {
            Console.WriteLine("Digite: ");
            double x = double.Parse(Console.ReadLine());

            var area = x * 2;

            Console.WriteLine(area);
            return area;
        }

        //l²

    }
}
