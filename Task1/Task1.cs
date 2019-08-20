using System;
using System.Numerics;

namespace Task1
{
    public class Point
    {
        public double x, y;
        public Point()
        {
            x = 0;
            y = 0;
        }
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }
    #region task 1-2
    public class Rectangle
    {
        public Point TopLeft { get; private set; }
        public Point BottomRight { get; private set; }
        public Rectangle(Point topLeft, Point bottomRight)
        {
            this.TopLeft = topLeft;
            this.BottomRight = bottomRight;
        }

        public double Width()
        {
            if (this.BottomRight.x >= this.TopLeft.x)
            {
                return (this.BottomRight.x - this.TopLeft.x);
            }
            return (this.TopLeft.x - this.BottomRight.x);
        }
        public double Height()
        {
            if (TopLeft.y >= BottomRight.y)
            {
                return (TopLeft.y - BottomRight.y);
            }
            return (BottomRight.y - TopLeft.y);
        }
        public double Square()
        {

            return (Width() * Height());
        }
        public double Perimeter()
        {
            return (2 * Width() + 2 * Height());
        }
    }
    #endregion

    #region task 3
    public class Circle
    {
        public const double PI = 3.14159265358979;
        public double Square(double r)
        {
            if (r > 0)
            {
                return PI * r * r;
            }
            return 0;
        }
        public double Circuit(double r)
        {
            if (r > 0)
            {
                return 2 * PI * r;
            }
            return 0;
        }
    }
    #endregion

    #region task 4
    public static class RectangleStatic
    {
        public static double Width(Point tl, Point br)
        {
            if (br.x >= tl.x)
            {
                return (br.x - tl.x);
            }
            return (tl.x - br.x);
        }
        public static double Height(Point tl, Point br)
        {
            if (tl.y >= br.y)
            {
                return (tl.y - br.y);
            }
            return (br.y - tl.y);
        }
        public static double Square(Point tl, Point br)
        {

            return (Width(tl, br) * Height(tl, br));
        }
        public static double Perimeter(Point tl, Point br)
        {
            return (2 * Width(tl, br) + 2 * Height(tl, br));
        }
    }
    #endregion

    #region task 5
    public static class ComplexNuber
    {
        public static Complex Multiply(Complex c1, Complex c2)
        {
            double rel = c1.Real * c2.Real - c1.Imaginary * c2.Imaginary;
            double img = c1.Real * c2.Imaginary + c1.Imaginary * c2.Real;
            return new Complex(rel, img);
        }

        public static Complex Division(Complex c1, Complex c2)
        {
            double rel = (c1.Real * c2.Real + c1.Imaginary * c2.Imaginary) / (c2.Real * c2.Real + c2.Imaginary * c2.Imaginary);
            double img = (c1.Imaginary * c2.Real - c1.Real * c2.Imaginary) / (c2.Real * c2.Real + c2.Imaginary * c2.Imaginary);
            return new Complex(rel, img);
        }
    }
    #endregion

    public class Task1
    {
        public void Execute()
        {
            //task 1-2
            Point tl = new Point(2, 3);
            Point br = new Point(5, 1);
            Rectangle rec = new Rectangle(tl, br);
            Console.WriteLine("Square: " + rec.Square() + "\nPerimeter: " + rec.Perimeter() + "\n");

            //tasck 3
            Circle c = new Circle();
            double r = 10;
            Console.WriteLine("Square: " + c.Square(r) + "\nCircuit: " + c.Circuit(r) + "\n");

            //task1 4
            Console.WriteLine("Square: " + RectangleStatic.Square(tl, br) + "\nPerimeter: " + RectangleStatic.Perimeter(tl, br) + "\n");

            Complex c1 = new Complex(3, 6);
            Complex c2 = new Complex(10, 2);
            Console.WriteLine("Multiply: " + ComplexNuber.Multiply(c1, c2) + "\nDivision: " + ComplexNuber.Division(c1, c2));
        }
    }
}