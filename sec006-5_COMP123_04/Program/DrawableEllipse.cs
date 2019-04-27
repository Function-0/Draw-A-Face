using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Program
{
    public class DrawableEllipse : Primitive, IDrawable
    {
        public DrawableEllipse(Color color, bool filled, Rectangle rectangle) : base(color, filled, rectangle)
        {
        }

        public void Draw(Graphics g)
        {
            if (this.filled)
            {
                SolidBrush colorBrush = new SolidBrush(this.color);
                g.FillEllipse(colorBrush, this.boundingRectangle);
            }
            else
            {
                Pen colorPen = new Pen(this.color);
                g.DrawEllipse(colorPen, this.boundingRectangle);
            }
        }

        public double Area()
        {
            double area = Math.PI * (this.boundingRectangle.Width / 2) * (this.boundingRectangle.Height / 2);
            return area;
        }
    }
}
