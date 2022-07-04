
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace projectshapes
{
    interface IBase
    {
        public double CalculateArea()
        {
            return 0.0;
        }
        public double CalculatePerimeter()
        {
            return 0.0;
        }
    }
    class Circle : IBase
    {

        static readonly double PI = 3.1415;
        public double rad { get; set; }
        public double CalculateArea()
        {
            return Math.Pow(rad, 2) * PI;
        }

        public double CalculatePerimeter()
        {
            return 2 * (PI * rad);

        }
    }
    class Rectangle : IBase
    {
        public double Width { get; set; }
        public double Length { get; set; }

        public double CalculateArea()
        {
            return Width * Length;
        }

        public double CalculatePerimeter()
        {
            return 2 * (Width + Length);

        }
        internal static class Program
        {
            static void Main(string[] args)
            {
                Circle c = new Circle();
                Rectangle r = new Rectangle();
                Console.WriteLine("enter the radius ");
                c.rad = double.Parse(Console.ReadLine());

                Console.WriteLine("area of the circle is " + c.CalculateArea());
                Console.WriteLine("Circumfrence of the circle is  " + c.CalculatePerimeter());



                Console.WriteLine("enter the Length ");
                r.Length = double.Parse(Console.ReadLine());
                Console.WriteLine("enter the Width ");
                r.Width = double.Parse(Console.ReadLine());

                Console.WriteLine("area of the Rectangle is " + r.CalculateArea());
                Console.WriteLine("Perimeter of the Rectangle is " + r.CalculatePerimeter());
                Console.ReadKey();
            }
        }
    }
}
