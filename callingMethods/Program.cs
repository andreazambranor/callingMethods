using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace callingMethods
{
    public class Program
    {
        static void Main(string[] args)
        {

            //askED the user what number they want to do the math operations on
            Console.WriteLine("How old are you?");


            Number numberOne = new Number();
            numberOne.Value = Convert.ToInt32(Console.ReadLine());
            numberTotal = Number (numberTotal.value);
            Console.WriteLine("in 30 years you will be ", numberTotal.Value);

            
 
        }



    }
}
