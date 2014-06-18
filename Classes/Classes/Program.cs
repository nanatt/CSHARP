#region Using Directives
using System;
using System.Collections.Generic;
using System.Text;
#endregion


namespace Classes
{
    class Program
    {
        public static void Entrance()
        {
            Point point1 = new Point();
            Point point2 = new Point(1024, 1200);
            double distance = point1.DistanceTo(point2);
            Console.WriteLine("Distance is {0}", distance);
            Console.WriteLine("Number of Point objects: {0}", Point.ObjectCount());
        }
        public static void Main(string[] args)
        {
            try
            {
                Entrance();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
