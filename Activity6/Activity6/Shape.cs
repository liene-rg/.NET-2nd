using System;

namespace CSharp.Activity.Polymorphism
{
    public abstract class Shape
    {

        public string Name;
        public Shape(string name)
        {
            this.Name = name;
        }
        private double area;
      
        public double Area
        {
            get { return area; }
            protected set { area = value; }
        }

       
        public abstract double CalculateArea();

    }
}
