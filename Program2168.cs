using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Uri_Awnsers
{
    class Program2168
    {
        static void Main(string[] args)
        {
            int dimensao_matriz = Convert.ToInt16(Console.ReadLine()) + 1;

            List<string> matriz_cameras = new List<string>();
            List<string> matriz_seguranca = new List<string>();

            for (int i = 0; i < dimensao_matriz; i++)
            {
                matriz_cameras.Add(Console.ReadLine().Replace(" ", ""));
            }

            for (int dim = 0; dim < matriz_cameras.Count - 1; dim++)
            {
                string seguranca = "";
                for (int coluna = 0; coluna < matriz_cameras.Count - 1; coluna++)
                {
                    int quant_cameras = 0;

                    for (int quadra = 0; quadra < 2; quadra++)
                    {
                        if(matriz_cameras[dim][coluna+quadra] == '1')
                        {
                            quant_cameras++;
                        }

                        if(matriz_cameras[dim+1][coluna+quadra] == '1')
                        {
                            quant_cameras++;
                        }
                    }

                    if (quant_cameras >= 2)
                    {
                        seguranca += "S";
                    }
                    else
                    {
                        seguranca += "U";
                    }
                }
                matriz_seguranca.Add(seguranca);
            }

            for(int i = 0; i < matriz_seguranca.Count; i++)
            {
                Console.WriteLine(matriz_seguranca[i]);
            }

        }
    }
}
