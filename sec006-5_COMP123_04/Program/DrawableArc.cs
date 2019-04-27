using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace Program
{
    public class DrawableArc : Primitive, IDrawable, IWritable
    {
        protected float start;
        protected float end;

        public DrawableArc(Color color, bool filled, Rectangle rectangle, float start, float end) :
            base(color, filled, rectangle)
        {
            this.start = start;
            this.end = end;
        }

        public void Draw(Graphics g)
        {
            Pen colorPen = new Pen(this.color);
            g.DrawArc(colorPen, this.boundingRectangle, this.start, this.end);
        }

        public void Write(TextWriter writer)
        {
            string objectSummary = String.Format($"Object: {GetType()}, " +
                $"Color: {this.color}, " +
                $"Filled: {this.filled}, " +
                $"Bounding Rectangle: {"{" + this.boundingRectangle + "}"}, " +
                $"Start: {"{" + this.start + "}"}, " +
                $"End: {"{" + this.end + "}"}");
            writer.WriteLine(objectSummary);
        }
    }
}
