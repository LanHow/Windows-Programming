using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingModel
{
    class Record
    {
        List<Line> _lineList = new List<Line>();
        List<Rectangle> _rectangleList = new List<Rectangle>();
        List<Ellipse> _ellipse = new List<Ellipse>();
    }
}
