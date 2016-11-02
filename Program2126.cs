using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Uri_Awnsers
{
    class Program2126
    {
        
        static void Main(string[] args)
        {
            int caso = 1;
            string repeticao = Console.ReadLine();

            while(repeticao != null && repeticao != "")
            {
                string msg = Console.ReadLine();
                
                int quantSubSequencias = 0;
                int positionAnt = 0;
                int position = msg.IndexOf(repeticao);
                
                while (position != -1)
                {
                    quantSubSequencias++;
                    int startindex = position + repeticao.Length;
                    positionAnt = position + 1;
                    position = msg.IndexOf(repeticao, startindex);

                }
                
                if (quantSubSequencias != 0)
                {
                    Console.WriteLine("Caso #" + caso + ":");
                    Console.WriteLine("Qtd.Subsequencias: " + quantSubSequencias);
                    Console.WriteLine("Pos: " + positionAnt);
                }
                else
                {
                    Console.WriteLine("Caso #" + caso + ":");
                    Console.WriteLine("Nao existe subsequencia");
                }

                Console.WriteLine();

                repeticao = Console.ReadLine();
                caso++;
            }
        }
    }
}
