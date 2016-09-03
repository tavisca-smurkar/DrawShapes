using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entities;
using EntityFactory;
using Operations;
using OperationFactory;

namespace TestForLine.test
{
    [TestClass]
    public class TestForLine
    {
        [TestMethod]
        public void TestDrawLine()
        {
            Line line = LineFactory.GetLine();
            line.pointOneXCoordinate = 100;
            line.pointOneYCoordinate = 200;
            line.pointTwoXCoordinate = 100;
            line.pointTwoYCoordinate = 400;
            ILineOperation lineOperation = LineOperationFactory.GetLineOperation();
            lineOperation.Draw(line);
        }
    }
}
