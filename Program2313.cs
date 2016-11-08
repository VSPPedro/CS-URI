using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Uri_Awnsers
{
    class Program2313
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] lados = Array.ConvertAll(numbers, int.Parse);

            lados = lados.OrderBy(i => i).ToArray();

            if (lados[0] == 0 || (lados[2] > lados[1] + lados[0]))
            {
                Console.WriteLine("Invalido");
            }
            else
            {
                if (lados[0] == lados[1] && lados[1] == lados[2])
                {
                    Console.WriteLine("Valido-Equilatero");
                }
                else if (lados[0] == lados[1] && lados[1] != lados[2] || lados[0] != lados[1] && lados[1] == lados[2])
                {
                    Console.WriteLine("Valido-Isoceles");
                }
                else
                {
                    Console.WriteLine("Valido-Escaleno");
                }

                if (Math.Pow(lados[2], 2) == Math.Pow(lados[1], 2) + Math.Pow(lados[0], 2))
                {
                    Console.WriteLine("Retangulo: S");
                }
                else
                {
                    Console.WriteLine("Retangulo: N");
                }
            }

            Console.ReadLine();
        }
    }
}
