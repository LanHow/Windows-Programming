using System.Windows.Forms;
using System.Drawing;
using DrawingModel;
using System.Drawing.Drawing2D;
using System;
namespace DrawingForm.PresentationModel
{
    class WindowsFormsGraphicsAdaptor : IGraphics
    {
        Graphics _graphics;
        public WindowsFormsGraphicsAdaptor(Graphics graphics)
        {
            this._graphics = graphics;
        }

        //clear
        public void ClearAll()
        {
            // OnPaint時會自動清除畫面，因此不需實作
        }

        //draw line
        public void DrawLine(double x1, double y1, double x2, double y2)
        {
            _graphics.DrawLine(Pens.Black, (float)x1, (float)y1, (float)x2, (float)y2);
        }

        //draw selected line
        public void DrawSelectedLine(double x1, double y1, double x2, double y2)
        {
            _graphics.DrawLine(Pens.Red, (float)x1, (float)y1, (float)x2, (float)y2);
        }

        //draw rectangle
        public void DrawRectangle(double x1, double y1, double x2, double y2)
        {
            _graphics.FillRectangle(Brushes.Yellow, (float)x1, (float)y1, (float)(x2 - x1), (float)(y2 - y1));
            _graphics.DrawRectangle(Pens.Black, (float)x1, (float)y1, (float)(x2 - x1), (float)(y2 - y1));
        }

        //draw selected rectangle
        public void DrawSelectedRectangle(double x1, double y1, double x2, double y2)
        {
            _graphics.FillRectangle(Brushes.Yellow, (float)x1, (float)y1, (float)(x2 - x1), (float)(y2 - y1));
            _graphics.DrawRectangle(Pens.Red, (float)x1, (float)y1, (float)(x2 - x1), (float)(y2 - y1));
        }

        //draw ellipse
        public void DrawEllipse(double x1, double y1, double x2, double y2)
        {
            _graphics.FillEllipse(Brushes.Green, (float)x1, (float)y1, (float)(x2 - x1), (float)(y2 - y1));
            _graphics.DrawEllipse(Pens.Black, (float)x1, (float)y1, (float)(x2 - x1), (float)(y2 - y1));
        }

        //draw selected ellipse
        public void DrawSelectedEllipse(double x1, double y1, double x2, double y2)
        {
            _graphics.FillEllipse(Brushes.Green, (float)x1, (float)y1, (float)(x2 - x1), (float)(y2 - y1));
            _graphics.DrawEllipse(Pens.Red, (float)x1, (float)y1, (float)(x2 - x1), (float)(y2 - y1));
        }

        //draw arrow
        public void DrawArrow(double x1, double y1, double x2, double y2)
        {
            double width, height, cross;
            height = Math.Abs(y1 - y2);
            width = Math.Abs(x1 - x2);
            cross = Math.Sqrt((height * height) + (width * width));
            double penWidth = cross / 10;
            AdjustableArrowCap arrow = new AdjustableArrowCap(3,3);
            Pen pen = new Pen(Color.Blue, (float)penWidth);
            pen.CustomEndCap = arrow;
            _graphics.DrawLine(pen, (float)x1, (float)y1, (float)(x2), (float)(y2));
        }

        //draw selected arrow
        public void DrawSelectedArrow(double x1, double y1, double x2, double y2)
        {
            double width, height, cross;
            height = Math.Abs(y1 - y2);
            width = Math.Abs(x1 - x2);
            cross = Math.Sqrt((height * height) + (width * width));
            double penWidth = cross / 10;
            AdjustableArrowCap arrow = new AdjustableArrowCap(3, 3);
            Pen pen = new Pen(Color.Red, (float)penWidth);
            pen.CustomEndCap = arrow;
            _graphics.DrawLine(pen, (float)x1, (float)y1, (float)(x2), (float)(y2));
        }
    }
}