using _01.Point_3D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.DistanceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var pointA = new Point3D(7, 4, 3);
            var pointB = new Point3D(17, 6, 2);

            var pointC = new Point3D(12, 7, 9);
            var pointD = new Point3D(6, 18, 5);

            Console.WriteLine("Distance: {0:N3}\n", DistanceCalculator.Calculate3DPointDistance(pointA, pointB));
            Console.WriteLine("Distance: {0:N3}\n", DistanceCalculator.Calculate3DPointDistance(pointC, pointD));
        }
    }
}
