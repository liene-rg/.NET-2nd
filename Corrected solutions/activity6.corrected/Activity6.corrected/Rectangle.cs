using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Activity.Polymorphism
{
    public class Rectangle : Shape, IPrintable
    {

        //public double Length;
        //public double Width;

        //public Rectangle(double width, double length, string name) : base(name)

        //{
        //    this.Width = width;
        //    this.Length = length;
        //}


        //public override double CalculateArea()
        //{
        //    double area = Length * Width;
        //    return area;
        //}

        //public void Print()
        //{
        //    Console.WriteLine("The shape is a Rectangle with an area of " + this.CalculateArea() + " with name of " + this.Name);
        //}

        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length, double width)
        {
            this.Length = length;
            this.Width = width;
        }

        public override void CalculateArea()
        {
            this.Area = this.Length * this.Width;
        }

        public override void CalculatePerimeter()
        {
            this.Perimeter = 2 * (this.Length + this.Width);
        }

        public void Print()
        {
            Console.WriteLine("The area of the rectangle is " + this.Area + System.Environment.NewLine +
                "The perimeter of the rectangle is " + this.Perimeter);
        }


    }


}
