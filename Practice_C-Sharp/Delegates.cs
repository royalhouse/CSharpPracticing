using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_C_Sharp
{
    public class Delegates
    {

        //Declaring the delegates. Here return Type and parameter type should be same
        //as the return Type and parameter type of the two methods 
        //"addnum" and "subnum" are two delegate name.
        public delegate void addnum(int a, int b);
        public delegate void subnum (int a, int b);

        //method- sum and add

        public void sum(int a, int b)
        {
            Console.WriteLine($"Sum of {a} and {b} is: {a + b}");
        }

        public void subtract(int a, int b)
        {
            Console.WriteLine($"Subtraction of {a} and {b} is: {a - b}");
        }


    }
}
