using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entities;
using System.Drawing;
using EntityFactory;
using Operations;
using OperationFactory;

namespace TestForLine.test
{
    [TestClass]
    public class TestForTriangle
    {
        [TestMethod]
        public void TestDrawTriangle()
        {
            Triangle triangle = Trianglefactory.GetTriangle();
            triangle.pointOne = new Point(50, 10);
            triangle.pointTwo = new Point(0,50);
            triangle.pointThree = new Point(100, 50);
            ITriangleOperation triangleOperation = TriangleOperationFactory.GetTriangleOperation();
            triangleOperation.Draw(triangle);
        }
    }
}
