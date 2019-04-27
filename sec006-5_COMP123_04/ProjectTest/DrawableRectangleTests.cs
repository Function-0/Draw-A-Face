using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Program;
using System.Drawing;

namespace ProjectTest
{
    [TestClass]
    public class DrawableRectangleTests
    {
        [TestMethod]
        public void Area_RectangleCreation_CorrectValue()
        {
            double expected = 20;
            Color color = Color.Red;
            bool filled = false;
            Rectangle boundingRectangle = new Rectangle(0, 0, 4, 5);
            DrawableRectangle rectangle = new DrawableRectangle(color, filled, boundingRectangle);

            double result = rectangle.Area();

            Assert.AreEqual(expected, result);
        }
    }
}
