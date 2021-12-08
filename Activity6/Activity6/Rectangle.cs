using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Activity.Polymorphism
{
    public class Rectangle : Shape, IPrintable
    {

        public double Length;
        public double Width;

        public Rectangle(double width, double length, string name): base(name)
       
        {
            this.Width = width;
            this.Length = length;
        }

                         
        public override double CalculateArea()
        {
            double area = Length * Width;
            return area;
        }

        public void Print()
        {
            Console.WriteLine("The shape is a Rectangle with an area of " + this.CalculateArea() + " with name of " + this.Name);
        }


    }

    
}
