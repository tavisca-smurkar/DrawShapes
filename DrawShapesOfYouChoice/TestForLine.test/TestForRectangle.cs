using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entities;
using EntityFactory;
using Operations;
using OperationFactory;

namespace TestForLine.test
{
    [TestClass]
    public class TestForRectangle
    {
        [TestMethod]
        public void TestDrawRectangle()
        {
            RecTangle rectangle = RectangleFactory.GetRectangle();
            rectangle.pointOneXCoordinate = 100;
            rectangle.pointOneYCoordinate = 100;
            rectangle.pointTwoXCoordinate = 500;
            rectangle.pointTwoYCoordinate = 200;
            IRectangleOperation rectangleOperation = RectangleOperationFactory.GetRectangleOperation();
            rectangleOperation.Draw(rectangle);
        }
    }
}
