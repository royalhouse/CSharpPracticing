using System;
using static Practice_C_Sharp.Delegates;
using static Practice_C_Sharp.Rectangle;
using static Practice_C_Sharp.GFG;


namespace Practice_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double v1 = 4, v2 = 5;


            //Triangle tri1 = new Triangle();

            //tri1.side = 4;
            //tri1.altitude = 5;

            //Console.WriteLine($"Area of tri1 is: {tri1.Area()}");

            //Triangle tri2;

            //tri2 = tri1;

            //tri2.altitude = 6;

            //Console.WriteLine($"Area of tri1 is: {tri2.Area()}");




            B fullObjectB = new B();
            testA(fullObjectB);

            C fullObjectC = new C();
            testC(fullObjectC);

        }
        public static void testA(SlicingClass notSlicedObject)
        {
            notSlicedObject.funA();

            ((B)notSlicedObject).funB();


        }

        public static void testC(C toSlicedObject)
        {
            toSlicedObject.funA();
            toSlicedObject.funB();
            toSlicedObject.funC();
        }


        /*
        GFG gfg = new GFG();
        Myrect[] rect = new Myrect[3];
        rect[0] = gfg.Area;
        rect[1] = gfg.Perimeter;
        rect[2] = gfg.Diagonal;

        for (int i =0; i<3; i++)
        {
            rect[i](v1,v2);
        }
        */

        /*
        Console.WriteLine("Class object calling");

        //Rectangle class

        Rectangle rect = new Rectangle();
        rect.Area(v1, v1);
        rect.Perimeter(v1, v1);


        Console.WriteLine("Delegates method reference invoking");
        rectDelegate rectDele = new rectDelegate(rect.Area);

        rectDelegate rectdele = rect.Perimeter;

       // rectDele += rect.Perimeter;

        rectDele.Invoke(v1, v2);
        */

        /* Delegates class
        // creating object "obj" of class "Delegates"
        Delegates obj = new Delegates();

        int val1 = 50;
        int val2 = 20;


        Console.WriteLine("Class object");
        obj.sum(val1, val2);
        obj.subtract(val1, val2);


        // creating object of delegate, name as "del_obj1"
        // for method "sum" and "del_obj2" for method "subtract" &
        // pass the parameter as the two methods by class object "obj"
        // instantiating the delegates
        addnum del_obj1 = new addnum (obj.sum);
        subnum del_obj2 = new subnum(obj.subtract);

        Console.WriteLine("Delegates object");

        del_obj1(val1, val2);
        del_obj2(val1, val2);

        */





    }
} 

