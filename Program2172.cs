using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Uri_Awnsers
{
    class Program2172
    {
        static void Main(string[] args)
        {
            Program2172 uri = new Program2172();

            string numbers = Console.ReadLine();

            Int64 aumento = 0;
            Int64 xp = 0;

            uri.converterParaNumeros(numbers, ref aumento, ref xp);

            while(aumento != 0 || xp != 0)
            {
                Console.WriteLine(aumento * xp);

                numbers = Console.ReadLine();
                uri.converterParaNumeros(numbers, ref aumento, ref xp);
            }
        }

        void converterParaNumeros(string input, ref Int64 aumento, ref Int64 xp)
        {
            string[] array_numbers = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            aumento = Convert.ToInt64(array_numbers[0]);
            xp = Convert.ToInt64(array_numbers[1]);
        }
    }
}
