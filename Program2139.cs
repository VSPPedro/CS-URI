using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Uri_Awnsers
{
    class Program2139
    {
        static void Main(string[] args)
        {
            int[] meses = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            int[] dias = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            string entrada = Console.ReadLine();

            while(entrada != null && entrada != "")
            {
                string[] data = entrada.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                int mes = Convert.ToInt16(data[0]);
                int dia = Convert.ToInt16(data[1]);

                int total = 0;

                for (int i = 0; i < mes - 1; i++)
                {
                    total += dias[i];
                }

                total += dia;

                if (total == 360)
                {
                    Console.WriteLine("E natal!");
                }
                else if (total > 360)
                {
                    Console.WriteLine("Ja passou!");
                }
                else if (total == 359)
                {
                    Console.WriteLine("E vespera de natal!");
                }
                else
                {
                    total = 360 - total;
                    Console.WriteLine("Faltam " + total + " dias para o natal!");
                }

                entrada = Console.ReadLine();
            }
        }
    }
}
