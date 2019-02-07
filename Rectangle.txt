using System;
using System.Drawing;
using static System.Math;

namespace ShapesHW
{
    public class Rectangle : Shape
    {
        //constructors
        public Rectangle()
        {
            new Rectangle(defaultHeight, defaultWidth);
        }
        public Rectangle(double height, double width)
        {
            _height = height;
            _width = width;
        }          

        //fields
        private double _height;
        private double _width;
        public const double defaultHeight = 0;
        public const double defaultWidth = 0;

        internal double whatever = 6;

        //properties
        // public Color Color { get; set; }

        public double Height { get; set; }
        //{
        //    get { return height; }

        //    set { height = value; }           
        //}

        public double Width
        {
            get { return _width; }

            set { _width = value; }
        }

        //methods
        public static double CalculateArea(double height, double width)
        {
            return height * width;
        }
        public override double CalculateArea()
        {
            return CalculateArea(_height, _width);
        }

        public override double CalculatePerimeter()
        {
            return _height * 2 + _width * 2;
        }

        //destructor
        ~Rectangle()
        {

        }
        // overloaded operators
        // not needed due to inheritance.
        /*
        public static bool operator <(Rectangle self, Rectangle other)
        {
            return self.CalculateArea() < other.CalculateArea();
        }
        
        public static bool operator >(Rectangle self, Rectangle other)
        {
            return self.CalculateArea() > other.CalculateArea();
        }
        
        public static bool operator <=(Rectangle self, Rectangle other)
        {
            return self.CalculateArea() <= other.CalculateArea();
        }

        public static bool operator >=(Rectangle self, Rectangle other)
        {
            return self.CalculateArea() >= other.CalculateArea();
        }

        public static bool operator ==(Rectangle self, Rectangle other)
        {
            return self.CalculateArea() == other.CalculateArea();
        }

        public static bool operator !=(Rectangle self, Rectangle other)
        {
            return self.CalculateArea() != other.CalculateArea();
        }
        */
    }
}