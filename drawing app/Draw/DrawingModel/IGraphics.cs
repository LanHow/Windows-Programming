using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingModel
{
    public interface IGraphics
    {
        //clear the board
        void ClearAll();
        //draw a line
        void DrawLine(double x1, double y1, double x2, double y2);
        //draw a rectangle
        void DrawRectangle(double x1, double y1, double x2, double y2);
        //draw a ellipse
        void DrawEllipse(double x1, double y1, double x2, double y2);
        //draw a arrow
        void DrawArrow(double x1, double y1, double x2, double y2);
        //draw select line
        void DrawSelectedLine(double x1, double y1, double x2, double y2);
        //draw select ellipse
        void DrawSelectedEllipse(double x1, double y1, double x2, double y2);
        //draw select rectangle
        void DrawSelectedRectangle(double x1, double y1, double x2, double y2);
        //draw select arrow
        void DrawSelectedArrow(double x1, double y1, double x2, double y2);
    }
}
