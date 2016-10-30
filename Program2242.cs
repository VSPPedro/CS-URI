using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Uri_Awnsers
{
    class Program2242
    {
        static void Main(string[] args)
        {
            string risada = Console.ReadLine();

            string vogais = "AaEeIiOoUu";

            string normal = "";
            string inverso = "";

            for(int x = 0; x < risada.Length; x++)
            {
                for(int y = 0; y < vogais.Length; y++)
                {
                    if (risada[x] == vogais[y])
                    {
                        normal += risada[x];
                        inverso = risada[x] + inverso;
                    }
                }
            }

            if(normal == inverso)
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
