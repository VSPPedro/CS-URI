using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Uri_Awnsers
{
    class Program2161
    {
        static void Main(string[] args)
        {
            double temp = 6;
            int repeticoes = Convert.ToInt16(Console.ReadLine());

            if (repeticoes == 0)
            {
                Console.WriteLine("3.0000000000");
            }
            else
            {
                for(int i = 1; i < repeticoes; i++)
                {
                    temp = 6 + 1 / temp;
                }
                temp = 3 + 1 / temp;

                string resultado = temp.ToString("0.0000000000").Replace(",", ".");

                Console.WriteLine(resultado);
            }
        }
    }
}
