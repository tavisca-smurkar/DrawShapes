using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entities;
using EntityFactory;
using System.Drawing;
using Operations;
using OperationFactory;

namespace TestForLine.test
{
    [TestClass]
    public class TestForHexagon
    {
        [TestMethod]
        public void TestDrawHexagon()
        {
            Hexagon hexagon = HexagonFactory.GetHexagon();
            hexagon.pointOne = new Point(10,0);
            hexagon.pointTwo = new Point(20,0);
            hexagon.pointThree = new Point(0,10);
            hexagon.pointFour = new Point(30,10);
            hexagon.pointFive = new Point(10,20);
            hexagon.pointSix = new Point(20,20);
            IHexagonOperation hexagonOperation = HexagonOperationFactory.GetHexagonOperation();
            hexagonOperation.Draw(hexagon);

        }
    }
}
