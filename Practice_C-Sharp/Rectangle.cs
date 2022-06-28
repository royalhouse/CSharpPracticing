using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_C_Sharp
{
    class Rectangle
    {
        //declaring delegate

        public delegate void rectDelegate(double height, double width);


        public void Area(double height, double width)
        {
            Console.WriteLine($"Area is : {height * width}");
        }

        public void Perimeter(double height, double width)
        {
            Console.WriteLine($"Perimiter is : {height + width}");
        }

    }
}
