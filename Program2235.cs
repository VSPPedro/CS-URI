using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Uri_Awnsers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbera, numberb, numberc;

            string input = Console.ReadLine();

            string[] numbers = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            numbera = Convert.ToInt16(numbers[0]);

            numberb = Convert.ToInt16(numbers[1]);

            numberc = Convert.ToInt16(numbers[2]);

            if (numbera == numberb || numbera == numberc || numberb == numberc || (numbera + numberb) == numberc 
                || (numbera + numberc) == numberb || (numberb + numberc) == numbera)
            {
                Console.WriteLine("S");
            }
            else
            {
                Console.WriteLine("N");
            }
        }
    }
}
