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

        public int Plusmetode(string opr)
        {

            return (input1 + input2);

        }
        public int Minusmetode(string opr)
        {
            return (input1 - input2);
        }
        public int Gangemetode(string opr)
        {
            return (input1 * input2);
        }
        public int Dividermetode(string opr)
        {
            return (input1 / input2);
        }
        
    }
}
