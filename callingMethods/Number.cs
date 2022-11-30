using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace callingMethods
{
    public class Number
    {
        public int Value { get; set; }

        public static int Math(int numberOne)
        {
            Number numberTwo = new Number();
            numberTwo.Value = numberOne+10;
            return numberTwo.Value;
        }

        public static int Math2(int numberTwo)
        {
            Number numberThree = new Number();
            numberThree.Value = numberTwo+10;
            return numberThree.Value;
        }

        public static int Math3(int numberThree)
        {
            Number numberTotal = new Number();
            numberTotal.Value = numberThree+10;
            return numberTotal.Value;
        }

    }


}
