﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestToggleApp
{
    class Program
    {
        // Purpose of this app is to show how simple it can be
        // to load dynamicly a dll to call a function, even mixing c#, c and c++
        // the goal is to isolate specific features for a specific client
        static void Main(string[] args)
        {
            Console.WriteLine("We test toggle dll here! And it will work nice with jenkins deploy");

            LoadModule();
            
            // TODO dyn load a C .dll 

            // TODO dyn load a c++ mfc dll

            // TODO dyn load a COM dll (interface to the 2 before ?)
            
            Console.Write("\nPress any key to continue... ");
            Console.ReadLine();
        }

        static void LoadModule()
        { 
            // We should have a generic say hello 
            // and a specific client hello loaded
            // dynamicly. Independent of how jenkins 
            // deploy.
        }
    }
}
