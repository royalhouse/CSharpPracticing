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
            Console.WriteLine("Function 01 is in main Slicing class."); 
        }
    }
 
    // Derived class
    class B : SlicingClass
    {
        public void funB()
        {
            Console.WriteLine("Function 02 is in B class.");
        }
    }
    class C: B
    {
        public void funC()
        {
            Console.WriteLine("Function 03 is in C class.");
        }
    }
}
