using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programm_usin_structural__extensionPartial
{

    public partial class Calc
    {
        public int Multiply(int a, int b)
        {

            Divide(a, b);
            return a * b;
        }

        public void Invoke(int a, int b)
        {
            {
                Divide(a, b);
            }
        }
        void Divide(int a, int b)
        {
            Console.WriteLine(a / b);
        }

    }
}
