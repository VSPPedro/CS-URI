using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Uri_Awnsers
{
    class Program2292
    {
        static void Main(string[] args)
        {
            int repeticoes = int.Parse(Console.ReadLine());

            for (int i = 0; i < repeticoes; i++)
            {
                string[] entrada = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string pisca_pisca = entrada[0];
                Int64 acoes = Int64.Parse(entrada[1]);
                int index = 0;
                StringBuilder sb = new StringBuilder(pisca_pisca);

                while (acoes > 0 && index < sb.Length)
                {
                    if (acoes % 2 == 0)
                    {
                        acoes /= 2;
                        index++;
                    }
                    else {
                        if (sb[index] == 'X')
                        {
                            sb[index] = 'O';
                            acoes /= 2;
                        }
                        else
                        {
                            sb[index] = 'X';
                            acoes = acoes / 2 + 1;
                        }
                        index++;
                    }
                }

                pisca_pisca = sb.ToString();

                Console.WriteLine(pisca_pisca);
            }
        }
    }
}
