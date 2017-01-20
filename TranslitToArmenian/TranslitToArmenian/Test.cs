using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslitToArmenian
{
    class Test
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Enter text in translit:");
                string input = Console.ReadLine();
                Console.WriteLine(input.Translate());
                Console.ReadKey();
            }

        }
    }
}
