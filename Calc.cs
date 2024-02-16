using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcExample
{
 public  class Calc
    {
        public void Add(double n1,double n2)
        {
            Console.WriteLine("Result after Addition: \t"+(n1+n2));
        }

        public void Sub(double n1, double n2)
        {
            Console.WriteLine("Result after Substraction: \t" + (n1 - n2));
        }

        public void Multi(double n1, double n2)
        {
            Console.WriteLine("Result after Multiplication: \t" + (n1 * n2));
        }

        public void Div(double n1, double n2)
        {
            Console.WriteLine("Result after Division: \t" + (n1 / n2));
        }

        public void Avg(double n1, double n2)
        {
            Console.WriteLine($"Average of {n1} and {n2}: \t" + (n1 +n2)/2);
        }



    }
}
