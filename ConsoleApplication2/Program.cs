using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction ulamek1 = new Fraction(4, 8);
            var ulamek2 = new Fraction(3, 5);
            var ulamek3 = ulamek1.Add(ulamek2);
            var ulamek4 = ulamek3.Multiply(ulamek2);


            Fraction euklides = new Fraction();

            ulamek3.Show();
            ulamek3.FixEuklides();

            ulamek4.Show();
            ulamek4.FixEuklides();

            Console.WriteLine("===========================");
            Fraction ulamek5 = new Fraction(3, 27);
            ulamek5.Show();
            ulamek5.FixEuklides();

            Fraction ulamek6 = new Fraction(6, 26);
            ulamek6.Show();
            ulamek6.FixEuklides();

            Console.ReadKey();
        }
    }
}
