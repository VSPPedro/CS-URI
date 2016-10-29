using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Uri_Awnsers
{
    class Program2152
    {
        static void Main(string[] args)
        {
            int numberOfRepetitions = Convert.ToInt16(Console.ReadLine());

            for(int i = 0; i < numberOfRepetitions; i++)
            {
                string inputEnter = Console.ReadLine();
                string[] pieces = inputEnter.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string hour = pieces[0];
                string minutes = pieces[1];
                string door = pieces[2];

                if(Convert.ToInt16(hour) < 10)
                {
                    hour = "0" + hour;
                }

                if(Convert.ToInt16(minutes) < 10)
                {
                    minutes = "0" + minutes;
                }

                if (Convert.ToInt16(door) == 1)
                {
                    Console.WriteLine(hour + ":" + minutes + " - A porta abriu!");
                }
                else
                {
                    Console.WriteLine(hour + ":" + minutes + " - A porta fechou!");
                }
            }
        }
    }
}
