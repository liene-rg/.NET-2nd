using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Activity.Polymorphism
{
    public class Circle: Shape, IPrintable
    {
        public double pi = 3.14;
        public double radius;

        public double Radius
        {
            get { return radius; }
            protected set { }
        }
        public Circle(double radius, double pi, string name ): base(name)
        {
           this.pi = pi;
           this.radius = radius;
            
            
        }

       
        public override double CalculateArea()
        {
            return pi * radius * radius;
        }

        public void Print()
        {
            Console.WriteLine("The shape is a Circle with an area of " + this.CalculateArea() + " with name of " + this.Name);
           
        }
    }
}
