//Matthew Dobbs
//CSC 260 2:30 PM - 3:45 PM

using System;


namespace ClassLibrary1
{

    public class Square
    {
        private double LengthOfSide;

        public Square(double LengthOfSide)
        {
            Console.WriteLine(string.Format("Initializing a Square with a side length of {0}.", LengthOfSide));
            this.LengthOfSide = LengthOfSide;
        }
        public double area;

        public double CalculateArea(double LengthOfSide)
        {
            area = LengthOfSide * LengthOfSide;
            return area;
        }

        public double perimeter;

        public double CalculatePerimeter(double LengthOfSide)
        {
            perimeter = 4 * LengthOfSide;
            return perimeter;
        }
    }

    public class Rectangle
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            Console.WriteLine(string.Format("Initializing a Rectangle with a width of {0}", width));
            Console.WriteLine(string.Format("And height of {0}", height));
            this.width = width;
            this.height = height;
        }
        double area;

        public double CalculateArea(double width, double height)
        {
            area = width * height;
            return area;
        }

        double perimeter;

        public double CalculatePerimeter(double width, double height)
        {
            perimeter = (2 * width) + (2 * height);
            return perimeter;
        }
    }

    public class Circle
    {
        private double radius;

        public Circle(double radius)
        {
            Console.WriteLine(string.Format("Initializing a Circle with a radius value of {0}.", radius));
            this.radius = radius;
        }

        public double area;

        public double CalculateArea(double radius)
        {
            area = 3.14 * (radius * radius);
            return area;
        }

        public double perimeter;

        public double CalculatePerimeter(double radius)
        {
            perimeter = 2 * perimeter;
            return perimeter;
        }
    }

    public class Ellipse
    {
        private double SemiMinorAxis;
        private double SemiMajorAxis;

        public Ellipse(double SemiMinorAxis, double SemiMajorAxis)
        {
            Console.WriteLine(string.Format("Initializing an Ellipse with a semi minor axis of {0}", SemiMinorAxis));
            Console.WriteLine(string.Format("and semi major axis of {0}", SemiMajorAxis));

            this.SemiMinorAxis = SemiMinorAxis;
            this.SemiMajorAxis = SemiMajorAxis;
        }
        double perimeter;

        public double CalculatePerimeter(double SemiMinorAxis, double SemiMajorAxis)
        {
            double h;
            h = ((SemiMinorAxis - SemiMajorAxis) * (SemiMinorAxis - SemiMajorAxis)) / ((SemiMinorAxis + SemiMajorAxis) * (SemiMinorAxis + SemiMajorAxis));
            perimeter = (3.14 * (SemiMinorAxis + SemiMajorAxis)) * (1 + (3 * h)) / (10 + (Math.Sqrt(4 - 3 * h)));
            return perimeter;
        }

        double area;

        public double CalculateArea(double SemiMinorAxis, double SemiMajorAxis)
        {
            area = (SemiMinorAxis * SemiMajorAxis) * 3.14;
            return area;
        }
        public class Shapes
        {
            public static void Main()
            {
                var circle1 = new Circle(15);

                double area = circle1.area;
                Console.WriteLine(string.Format("Area of Circle is {0}", area));
                double perimeter = circle1.perimeter;
                Console.WriteLine(string.Format("Area of Circle is {0}", perimeter));

                var rectangle1 = new Rectangle(15, 20);
                
                /*  
                double area = rectangle1.area;
                Console.WriteLine(string.Format("Area of Circle is {0}", area));
                double perimeter = rectangle1.perimeter;
                Console.WriteLine(string.Format("Area of Circle is {0}", perimeter));
                */ //wont work for area and perimeter as well
                var square1 = new Square(15);

                /*
                double area = square1.area;
                Console.WriteLine(string.Format("Area of Circle is {0}", area));
                double perimeter = square1.perimeter;
                Console.WriteLine(string.Format("Area of Circle is {0}", perimeter));
                */ //won't work for area and perimeter as well

                var ellipse1 = new Ellipse(15, 20);

                /*
                double area = ellipse1.area;
                Console.WriteLine(string.Format("Area of Circle is {0}", area));
                double perimeter = ellipse1.perimeter;
                Console.WriteLine(string.Format("Area of Circle is {0}", perimeter));
                */ // won't work for area and perimeter as well

            }
        }
    }
}