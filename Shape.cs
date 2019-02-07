using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace ShapesHW
{
    public abstract class Shape
    {
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();

        public static bool operator <(Shape self, Shape other)
        {
            return self.CalculateArea() < other.CalculateArea();
        }

        public static bool operator >(Shape self, Shape other)
        {
            return self.CalculateArea() > other.CalculateArea();
        }

        public static bool operator <=(Shape self, Shape other)
        {
            return !(self > other);           
        }

        public static bool operator >=(Shape self, Shape other)
        {
            return !(self < other);
        }

        public static bool operator ==(Shape self, Shape other)
        {
            return !(self < other || self > other);
        }

        public static bool operator !=(Shape self, Shape other)
        {
            return !(self == other);
        }
    }
}
