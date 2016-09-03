using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entities;
using EntityFactory;
using Operations;
using OperationFactory;

namespace TestForLine.test
{
    [TestClass]
    public class TestForCircle
    {
        [TestMethod]
        public void TestDrawCircle()
        {
            Circle cirle = CircleFactory.GetCircle();
            cirle.pointOneXCoordinate = 10;
            cirle.pointOneYCoordinate = 10;
            cirle.pointTwoXCoordinate = 50;
            cirle.pointTwoYCoordinate = 50;
            ICircleOperation circleOperation = CircleOperationFactory.GetCircleOperation();
            circleOperation.Draw(cirle);
        }
    }
}
