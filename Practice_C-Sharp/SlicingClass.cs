using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_C_Sharp
{
    // Parent class
    class SlicingClass
     {
        public void funA() 
        { 
            Console.WriteLine("Function 01 is in main class"); 
        }
    }
 
    // Derived class
    class B : SlicingClass
    {
        public void funB()
        {
            Console.WriteLine("Function 02 is in slicing class");
        }
    }
}
