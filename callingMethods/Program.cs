﻿using System;
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
            Console.WriteLine("Write a number to pass along the methods");
            int a = Convert.ToInt32(Console.ReadLine());

            Number A = new Number();
            a = A.Math3(c);
            Console.WriteLine("total is ", a);

                
            
        }



    }
}
