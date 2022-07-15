using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_MultiPart_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringies = { "flib", "bilf", "lifb" };
            Console.WriteLine("Enter some text");
            string inputText = Console.ReadLine();

            for(int i=0; i<stringies.Length; i++)
            {
                stringies[i] = stringies[i] + " " + inputText;
            }

            foreach (string i in stringies)
            {
                Console.WriteLine(i);
            }


            Console.ReadLine();

        }
    }
}
