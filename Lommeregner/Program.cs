using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lommeregner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("indtast første tal");
            string input1 = Console.ReadLine();
            Console.WriteLine("indsæt operator");
            string opr = Console.ReadLine();
            Console.WriteLine("indtast andet tal");
            string input2 = Console.ReadLine();
            //int tal1 = Int32.Parse(input1);
            
            Lommeregner lr = new Lommeregner();

            lr.input1 = Int32.Parse(input1);
            lr.opr = opr;
            lr.input2 = Int32.Parse(input2);
            lr.BestemBeregning();

            lr.PrintResultat();


            Console.WriteLine();
            Console.WriteLine("Press any key to close the program...");

            Console.ReadKey();
        }
    }
}
