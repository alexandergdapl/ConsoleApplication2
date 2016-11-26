using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Fraction
    {
        private int numerator;
        private int denominator;

        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        // hm.......???
        public Fraction()
        {
            //numerator = this.numerator;
        }

        public int getNumerator()
        {
            return numerator;
        }

        public int getDenominator()
        {
            return denominator;
        }


        public Fraction Add(Fraction input)
        {
            int denominator = input.getDenominator();
            var numerator = input.getNumerator();
            return new Fraction(this.numerator * denominator +
                numerator * this.denominator, this.denominator * denominator);
        }

        public Fraction Multiply(Fraction input)
        {
            int denominator = input.getDenominator();
            var numerator = input.getNumerator();

            return new Fraction(this.numerator * numerator,
                this.denominator * denominator);
        }

        public void Show()
        {
            Console.WriteLine($"{this.numerator}/{this.denominator}");
        }
       
        public int FixEuklides()
        {
            if (denominator == 0)
            {
                Console.WriteLine("pamiętaj cho***o nie dziel przez zero");
                return 0;
            }
            
            {
                int result = 0;
                while (numerator != denominator)
                {
                    if (numerator > denominator)
                    {
                        numerator = numerator - denominator;
                    }
                    else
                    {
                        denominator = denominator - numerator;
                    }
                }
                int euklides = denominator;
                Console.WriteLine($"Euklides = {euklides}");
                return result;
            }
        }
    }
}