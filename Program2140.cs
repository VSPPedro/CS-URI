using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Uri_Awnsers
{
    class Program2140
    {
        static void Main(string[] args)
        {
            Program2140 uri = new Program2140();

            string input = Console.ReadLine();
            int pagamento = 0;
            int troco = 0;
            int conta = uri.receberValores(input, ref pagamento, ref troco);

            while(conta != 0 || troco != 0)
            {
                int quantNotas = uri.retirarNotas(ref troco);
                
                if (troco == 0 && quantNotas == 2)
                {
                    Console.WriteLine("possible");
                }
                else
                {
                    Console.WriteLine("impossible");
                }

                input = Console.ReadLine();

                conta = uri.receberValores(input, ref pagamento, ref troco);
            }
        }

        int receberValores(string input, ref int pagamento, ref int troco)
        {
            string[] numbers = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int conta = Convert.ToInt16(numbers[0]);
            pagamento = Convert.ToInt16(numbers[1]);
            troco = pagamento - conta;

            return conta;
        }

        int retirarNotas(ref int troco)
        {
            int quantNotas = 0;
            retirarNota(ref troco, ref quantNotas);
            retirarNota(ref troco, ref quantNotas);

            return quantNotas;
        }

        void retirarNota(ref int troco, ref int quantNotas)
        {
            int[] notas = { 2, 5, 10, 20, 50, 100 };

            if (troco > 100)
            {
                troco -= 100;
                quantNotas++;
            }
            else if (troco > 1)
            {
                for (int i = 0; i < notas.Length; i++)
                {
                    if (troco < notas[i])
                    {
                        troco -= notas[i - 1];
                        quantNotas++;
                        break;
                    }
                }
            }
        }
    }
}
