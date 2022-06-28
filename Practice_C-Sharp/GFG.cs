using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_C_Sharp
{
    class GFG
    {

        public delegate void Myrect(double len, double widtht);


        public void  PrintMe(string message, string result)
        {
             Console.WriteLine($"{ message} {result}");
        }

        public void Area(double len, double width)
        {
            double result1 = len * width;
            PrintMe("Area is", Convert.ToString(result1));
        }

        public void Perimeter(double len, double width)
        {
            double result2= 2 * (len + width);
            PrintMe("Perimeter is", Convert.ToString(result2));
        }

        public void Diagonal(double len, double width)
        {
            double result3 = Math.Sqrt(len * len + width * width);
            PrintMe("Diagonal is", Convert.ToString(result3));
        }

    }
}
