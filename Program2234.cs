using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Uri_Awnsers
{
    class Program2234
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] numbers = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            double numberOfHotDogs = Convert.ToDouble(numbers[0]);
            double numberOfPeoples = Convert.ToDouble(numbers[1]);

            Console.WriteLine(Math.Round((numberOfHotDogs / numberOfPeoples),2).ToString("0.00").Replace(",","."));
        }
    }
}
