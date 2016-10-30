using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Uri_Awnsers
{
    class Program2164
    {
        static void Main(string[] args)
        {
            int entrada = Convert.ToInt16(Console.ReadLine());
          
            double fibonnaci = (Math.Pow((1 + Math.Sqrt(5)) / 2, entrada) - Math.Pow((1 - Math.Sqrt(5)) / 2, entrada)) / Math.Sqrt(5);

            Console.WriteLine((fibonnaci).ToString("0.0").Replace(",","."));
        }
    }
}
