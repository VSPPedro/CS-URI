using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Uri_Awnsers
{
    class Program2310
    {
        static void Main(string[] args)
        {
            int quant_jogadores = Convert.ToInt16(Console.ReadLine());

            int total_saques = 0;
            int total_bloqueios = 0;
            int total_ataques = 0;

            int saques_acertados = 0;
            int bloqueios_acertados = 0;
            int ataques_acertatos = 0;

            for(int i = 0; i < quant_jogadores; i++)
            {
                string nome = Console.ReadLine();

                string tentativas = Console.ReadLine();

                string[] array_tentativas = tentativas.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                total_saques += Convert.ToInt16(array_tentativas[0]);

                total_bloqueios += Convert.ToInt16(array_tentativas[1]);

                total_ataques += Convert.ToInt16(array_tentativas[2]);

                string acertos = Console.ReadLine();

                string[] array_acertos = acertos.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                saques_acertados += Convert.ToInt16(array_acertos[0]);

                bloqueios_acertados += Convert.ToInt16(array_acertos[1]);

                ataques_acertatos += Convert.ToInt16(array_acertos[2]);

            }

            double aproveitamento_saques = ((double)saques_acertados / total_saques)*100;

            double aproveitamento_bloqueios = ((double)bloqueios_acertados / total_bloqueios)*100;

            double aproveitamento_ataques = ((double)ataques_acertatos / total_ataques)*100;

            Console.WriteLine("Pontos de Saque: " + aproveitamento_saques.ToString("F").Replace(",", ".") + " %.");

            Console.WriteLine("Pontos de Bloqueio: " + aproveitamento_bloqueios.ToString("F").Replace(",", ".") + " %.");

            Console.WriteLine("Pontos de Ataque: " + aproveitamento_ataques.ToString("F").Replace(",",".") +" %.");
        }
    }
}
