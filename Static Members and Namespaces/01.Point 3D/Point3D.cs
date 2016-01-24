using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Point_3D
{
   public class Point3D
    {
        private int x;
        private int y;
        private int z;
        public static readonly Point3D startPoint;
        public int AxisX;

        public int X
        {
            get { return this.x; }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("X cannot be negative");
                }
                this.x = value;
            }
        }
        public int Y
        {
            get { return this.y; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Y cannot be negative");
                }
                this.y = value;
            }
        }
        public int Z
        {
            get { return this.z; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Z cannot be negative");
                }
                this.z = value;
            }
        }
       
        public Point3D(int x,int y,int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        static Point3D()
        {
            startPoint = new Point3D(0, 0, 0);
        }

        public override string ToString()
        {
            return string.Format("X : {0}\nY : {1}\nZ : {2}\n ",this.X,this.Y,this.Z);
        }
    }
}
