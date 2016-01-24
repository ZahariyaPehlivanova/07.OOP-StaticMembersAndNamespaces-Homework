using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Point_3D
{
    public class Program
    {
       public static void Main(string[] args)
        {
            Point3D first = new Point3D(2,6,9);
            Point3D second = new Point3D(13, 17, 3);
            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine("Starting point:");
            Console.WriteLine(Point3D.startPoint);
        }
    }
}
