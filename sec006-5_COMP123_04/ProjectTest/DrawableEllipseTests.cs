using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Program;
using System.Drawing;

namespace ProjectTest
{
    [TestClass]
    public class DrawableEllipseTests
    {
        [TestMethod]
        public void Area_EllipseCreation_CorrectValue()
        {
            double expected = 62.83;
            Color color = Color.Red;
            bool filled = false;
            Rectangle boundingRectangle = new Rectangle(0, 0, 8, 10);
            DrawableEllipse ellipse = new DrawableEllipse(color, filled, boundingRectangle);

            double result = ellipse.Area();

            Assert.AreEqual(expected, Math.Round(result, 2));
        }
    }
}
