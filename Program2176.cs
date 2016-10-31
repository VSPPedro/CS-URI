using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Uri_Awnsers
{
    class Program2176
    {
        static void Main(string[] args)
        {
            string bits = Console.ReadLine();
            int quantiBits = 0;

            for(int i = 0; i < bits.Length; i++)
            {
                if(bits[i] == '1')
                {
                    quantiBits++;
                }
            }

            if(quantiBits % 2 != 0)
            {
                Console.WriteLine(bits + "1");
            }
            else
            {
                Console.WriteLine(bits + "0");
            }

            Console.ReadLine();
        } 
    }
}
