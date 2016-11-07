using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Uri_Awnsers
{
    class Program2311
    {
        static void Main(string[] args)
        {
            int quant_comp = Convert.ToInt16(Console.ReadLine());

            List<string> nomes = new List<string>();
            List<string> notas_formatadas = new List<string>();

            for(int i = 0; i < quant_comp; i++)
            {
                nomes.Add(Console.ReadLine());
                
                double dificuldade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                List <double> notas = new List<double>();
                string notas_string = Console.ReadLine();
                string[] notas_array = notas_string.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);  

                for(int x = 0; x < notas_array.Length; x++)     {notas.Add(double.Parse(notas_array[x], CultureInfo.InvariantCulture));}

                notas.Sort();

                double soma_notas = 0;

                for(int x = 1; x < notas_array.Length - 1; x++)         {soma_notas += notas[x];}

                double nota_total = soma_notas * dificuldade;

                notas_formatadas.Add(nota_total.ToString("0.00").Replace(",", "."));
     
            }

            for (int i = 0; i < notas_formatadas.Count; i++)    {Console.WriteLine("{0} {1}", nomes[i], notas_formatadas[i]);}

        }
    }
}
