using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace Program
{
    public class DrawableBezier : IDrawable, IWritable
    {
        protected Color color;
        protected Point curveStart;
        protected Point controlFirst;
        protected Point controlSecond;
        protected Point curveEnd;

        public DrawableBezier(Color color, Point start, Point first, Point second, Point end)
        {
            this.color = color;
            this.curveStart = start;
            this.controlFirst = first;
            this.controlSecond = second;
            this.curveEnd = end;
        }

        public void Draw(Graphics g)
        {
            Pen colorPen = new Pen(this.color);
            g.DrawBezier(colorPen, this.curveStart, this.controlFirst, this.controlSecond, this.curveEnd);
        }

        public void Write(TextWriter writer)
        {
            string objectSummary = String.Format($"Object: {GetType()}, " +
                $"Color: {this.color}, " +
                $"Curve Start: {"{" + this.curveStart + "}"}, " +
                $"Control First: {"{" + this.controlFirst + "}"}, " +
                $"Control Second: {"{" + this.controlSecond + "}"}, " +
                $"Curve End: {"{" + this.curveEnd + "}"}");
            writer.WriteLine(objectSummary);
        }
    }
}
