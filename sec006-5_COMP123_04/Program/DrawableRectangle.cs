using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace Program
{
    public class DrawableRectangle : Primitive, IDrawable, IWritable
    {
        public DrawableRectangle(Color color, bool filled, Rectangle rectangle) : base(color, filled, rectangle)
        {
        }

        public void Draw(Graphics g)
        {
            if (this.filled)
            {
                SolidBrush colorBrush = new SolidBrush(this.color);
                g.FillRectangle(colorBrush, this.boundingRectangle);
            }
            else
            {
                Pen colorPen = new Pen(this.color);
                g.DrawRectangle(colorPen, this.boundingRectangle);
            }
        }

        public void Write(TextWriter writer)
        {
            string objectSummary = String.Format($"Object: {GetType()}, " +
                $"Color: {this.color}, " +
                $"Filled: {this.filled}, " +
                $"Bounding Rectangle: {"{" + this.boundingRectangle + "}"}");
            writer.WriteLine(objectSummary);
        }

        public double Area()
        {
            double area = this.boundingRectangle.Width * this.boundingRectangle.Height;
            return area;
        }
    }
}
