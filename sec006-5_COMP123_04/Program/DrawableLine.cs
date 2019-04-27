using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace Program
{
    public class DrawableLine : IDrawable, IWritable
    {
        protected Color color;
        protected Point lineStart;
        protected Point lineEnd;

        public DrawableLine(Color color, Point start, Point end)
        {
            this.color = color;
            this.lineStart = start;
            this.lineEnd = end;
        }

        public void Draw(Graphics g)
        {
            Pen colorPen = new Pen(this.color);
            g.DrawLine(colorPen, this.lineStart, this.lineEnd);
        }

        public void Write(TextWriter writer)
        {
            string objectSummary = String.Format($"Object: {GetType()}, " +
                $"Color: {this.color}, " +
                $"Line Start: {"{" + this.lineStart + "}"}, " +
                $"Line End: {"{" + this.lineEnd + "}"}");
            writer.WriteLine(objectSummary);
        }
    }
}
