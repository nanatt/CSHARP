#region System Directives 
using System;
using System.Collections.Generic;
using System.Text;
#endregion
namespace Classes
{
    public class Point
    {
        // campos
        private int x, y;
        private static int objectCount = 0;

        // construtores
        public Point()
        {
            objectCount++;
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
            objectCount++;
        }

            public double DistanceTo(Point other)
            {
                int xDiff = this.x - other.x;
                int yDiff = this.y - other.y;

                return Math.Sqrt((xDiff * xDiff) + (yDiff * yDiff));
            }
            public static int ObjectCount()
            {
                return objectCount;
            }
    }
}
