using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Uri_Awnsers
{
    class Program2162
    {
        static void Main(string[] args)
        {
            int rep = Convert.ToInt16(Console.ReadLine());
            string picos = Console.ReadLine();

            string[] picos_array = picos.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //Quando true significa q o proxima entrada tem q ser maior
            //Quando false significa q a proxima entrada tem q ser menor
            //Para seguir o padrao
            bool motanha = true;
            int padrao = 1;

            if(picos_array.Length > 1)
            {
                int relevo1 = Convert.ToInt16(picos_array[0]);
                int relevo2 = Convert.ToInt16(picos_array[1]);

                if (relevo1 > relevo2)
                {
                    motanha = true;
                }
                else if (relevo1 < relevo2)
                {
                    motanha = false;
                }
                else
                {
                    padrao = 0;
                }

                int temp = relevo2;

                for (int i = 2; i < picos_array.Length; i++)
                {
                    int altura = Convert.ToInt16(picos_array[i]);

                    if (temp < altura && motanha == true)
                    {
                        motanha = false;
                        temp = altura;
                    }
                    else if (temp > altura && motanha == false)
                    {
                        motanha = true;
                        temp = altura;
                    }
                    else
                    {
                        padrao = 0;
                        break;
                    }
                }

                Console.WriteLine(padrao);

            }
            else
            {
                Console.WriteLine(padrao);
            }
            
        }
    }
}
