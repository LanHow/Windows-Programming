using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingModel
{
    //形狀parent
    abstract class Shape
    {
        public double x1;
        public double y1;
        public double x2;
        public double y2;
        //virtual function
        public abstract void Draw(IGraphics graphics);

        //virtual function
        public abstract void DrawSelected(IGraphics graphics);
    }

    //橢圓
    class Ellipse : Shape
    {
        //多型
        public override void Draw(IGraphics graphics)
        {
            graphics.DrawEllipse(x1, y1, x2, y2);
        }

        //drawselected
        public override void DrawSelected(IGraphics graphics)
        {
            graphics.DrawSelectedEllipse(x1, y1, x2, y2);
        }
    }

    //線
    class Line : Shape
    {
        //多型
        public override void Draw(IGraphics graphics)
        {
            graphics.DrawLine(x1, y1, x2, y2);
        }

        //drawselected
        public override void DrawSelected(IGraphics graphics)
        {
            graphics.DrawSelectedLine(x1, y1, x2, y2);
        }
    }

    //矩形
    class Rectangle : Shape
    {
        //多型
        public override void Draw(IGraphics graphics)
        {
            graphics.DrawRectangle(x1, y1, x2, y2);
        }

        //drawselected
        public override void DrawSelected(IGraphics graphics)
        {
            graphics.DrawSelectedRectangle(x1, y1, x2, y2);
        }
    }

    class Arrow : Shape
    {
        //多型
        public override void Draw(IGraphics graphics)
        {
            graphics.DrawArrow(x1, y1, x2, y2);
        }

        //drawselected
        public override void DrawSelected(IGraphics graphics)
        {
            graphics.DrawSelectedArrow(x1, y1, x2, y2);
        }
    }
}
