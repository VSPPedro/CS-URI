using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Uri_Awnsers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfWords;
            string word;

            //To print "." not "," in numeric values
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            numberOfWords = Convert.ToInt16(Console.ReadLine());

            for(int i = 0; i < numberOfWords; i++)
            {
                word = Console.ReadLine();
                //Format to two decimal places after "."
                Console.WriteLine("{0:N2}", word.Length * 0.01);
            }
        }
    }
}
