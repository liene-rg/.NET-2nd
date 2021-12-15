using System;

namespace CSharp.Activity.Polymorphism
{
    public abstract class Shape
    {

        //public string Name;
        //public Shape(string name)
        //{
        //    this.Name = name;
        //}
        //private double area;

        //public double Area
        //{
        //    get { return area; }
        //    protected set { area = value; }
        //}


        //public abstract double CalculateArea();


        public double Area { get; protected set; }
        public double Perimeter { get; protected set; }
        public abstract void CalculateArea();  //this method is actually used as the setter
        public abstract void CalculatePerimeter();

    }
}
