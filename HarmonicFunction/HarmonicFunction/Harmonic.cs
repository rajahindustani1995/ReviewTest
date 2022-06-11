using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmonicFunction
{
    internal class Harmonic
    {
        public void Function()
        {
            Console.Write("Enter the value :");
            int Num = Convert.ToInt32(Console.ReadLine());
            double harmonicNumber = 0;

            while (Num < 15 || Num >= 32)
            {
                Console.Write("Enter valid number : ");
                Num = Convert.ToInt32(Console.ReadLine());
            }
            
            
            if (Num > 0)
            {
                for (double i = 1; i <= Num; i++)
                {
                    harmonicNumber += 1 / i;
                }
                Console.WriteLine(Num + "th Harmonic Number is: " + harmonicNumber);
            }
            else
            {
                Console.WriteLine("Enterd Number is not positive");
            }

        } 
    }
}
