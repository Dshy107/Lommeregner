using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lommeregner
{
    class Lommeregner
    {
        public int input1 { get; set; }
        public string opr { get; set; }
        public int input2 { get; set; }
        public int resultat { get; set; }

        public void PrintResultat()
        {

            Console.WriteLine("Resultatet er:"+resultat);
        }
        public int BestemBeregning()
        {
            //int result = 0;

            if (opr == "+")
            {
                resultat = Plusmetode();

                Console.WriteLine(resultat);
                //result = input1 + input2;
                //return result;
                
            }
            else if (opr == "-")
            {

                resultat = Minusmetode();
                Console.WriteLine(resultat);
            }
            else if (opr == "*")
            {
                resultat = Gangemetode();
                Console.WriteLine(resultat);
            }
            else if (opr == "/")
            {
                resultat = Dividermetode();
                Console.WriteLine(resultat);
            }
            return resultat;
        }
        public int Plusmetode()
        {

            return (input1 + input2);

        }
        public int Minusmetode()
        {
            return (input1 - input2);
        }
        public int Gangemetode()
        {
            return (input1 * input2);
        }
        public int Dividermetode()
        {
            return (input1 / input2);
        }

    }
}
