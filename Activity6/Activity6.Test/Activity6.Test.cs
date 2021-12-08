using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharp.Activity.Polymorphism;

namespace Activity6.Test
{
    [TestClass]
    public class ShapeTest
    {

       // private Shape shape;
        private Circle circle;
        private Rectangle rectangle;

        [TestInitialize]
        
            // Initialize objects

            public void Initialize()
            {
          
            
           
            circle = new Circle(5, 3.14, "circleTest");

            rectangle = new Rectangle(10, 15, "rectangleTest");
                                           
            }


        [TestMethod]
        public void TestMethod1()
        {


            Assert.AreEqual("circleTest", circle.Name);
            Assert.AreEqual(3.14, circle.pi);
            Assert.AreEqual(78.5, circle.CalculateArea());
            

            Assert.AreEqual("rectangleTest", rectangle.Name);
            Assert.AreEqual(10, rectangle.Width);
            Assert.AreEqual(15, rectangle.Length);
            Assert.AreEqual(150, rectangle.CalculateArea());

            
        }
         

        [TestMethod]
        public void TestPrintElements()
        {
            

            string outputExpectedRectangle = "The shape is a Rectangle with an area of " + rectangle.CalculateArea() + " with name of " + rectangle.Name;
            System.IO.StringWriter stringWrite = new System.IO.StringWriter();
            System.Console.SetOut(stringWrite);
            rectangle.Print();
            Assert.AreEqual(outputExpectedRectangle, stringWrite.ToString());

            string outputExpectedCircle = "The shape is a Circle with an area of " + circle.CalculateArea() + " with name of " + circle.Name;
            System.IO.StringWriter stringWrite2 = new System.IO.StringWriter();
            System.Console.SetOut(stringWrite2);
            rectangle.Print();
            Assert.AreEqual(outputExpectedCircle, stringWrite2.ToString());


        }

    }
}
