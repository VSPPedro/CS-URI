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
            double number;

            //To print "." not "," in numeric values
            //System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            //customCulture.NumberFormat.NumberDecimalSeparator = ".";
            //System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            numberOfWords = Convert.ToInt16(Console.ReadLine());

            for(int i = 0; i < numberOfWords; i++)
            {
                word = Console.ReadLine();
                number = word.Length * 0.01;
                word = number.ToString("####0.00").Replace(",",".");
                Console.WriteLine(word);
            }
        }
    }
}
