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
            Console.WriteLine("Function A"); 
        }
    }
 
    // Derived class
    class B : SlicingClass
    {
        public void funB()
        {
            Console.WriteLine("Function B");
        }
    }
}
