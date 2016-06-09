using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestToggleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We test toggle dll here! Ant it will work nice with jenkins");

            // TODO dyn load a C .dll 

            // TODO dyn load a c++ mfc dll

            // TODO dyn load a COM dll (interface to the 2 before ?)
            
            Console.Write("\nPress any key to continue... ");
            Console.ReadLine();
        }
    }
}
