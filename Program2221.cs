using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Uri_Awnsers
{
    class Program2221
    {
        static void Main(string[] args)
        {

            int repeticoes = Convert.ToInt16(Console.ReadLine());

            for(int i = 0; i < repeticoes; i++)
            {
                int bonus = Convert.ToInt16(Console.ReadLine());
                string dadosA = Console.ReadLine();
                string[] dadosArrayA = dadosA.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                int atakA = Convert.ToInt16(dadosArrayA[0]);
                int defA = Convert.ToInt16(dadosArrayA[1]);
                int levelA = Convert.ToInt16(dadosArrayA[2]);

                string dadosB = Console.ReadLine();
                string[] dadosArrayB = dadosB.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                int atakB = Convert.ToInt16(dadosArrayB[0]);
                int defB = Convert.ToInt16(dadosArrayB[1]);
                int levelB = Convert.ToInt16(dadosArrayB[2]);

                double powerA = (atakA + defA) / 2;
                double powerB = (atakB + defB) / 2;

                if(levelA % 2 == 0 && levelB % 2 != 0)
                {
                    powerA += bonus;
                }
                else if (levelA % 2 != 0 && levelB % 2 == 0)
                {
                    powerB += bonus;
                }

                if(powerA > powerB)
                {
                    Console.WriteLine("Dabriel");
                }else if(powerA < powerB)
                {
                    Console.WriteLine("Guarte");
                }
                else
                {
                    Console.WriteLine("Empate");
                }
            }

        }
    }
}
