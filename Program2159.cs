using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Uri_Awnsers
{
    class Program2159
    {
        static void Main(string[] args)
        {
            int numero_natural = Convert.ToInt32(Console.ReadLine());
            double minimo = Math.Round(numero_natural / Math.Log(numero_natural), 1);
            double maximo = Math.Round(1.25506 * numero_natural / Math.Log(numero_natural), 1);
            
            Console.WriteLine("{0} {1}", minimo.ToString("0.0").Replace(",","."), maximo.ToString("0.0").Replace(",", "."));
        }
    }
}
