using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;

namespace DrawingModel
{
    public class ShapeFactory
    {
        Line _line = new Line();
        Rectangle _rectangle = new Rectangle();
        Ellipse _ellipse = new Ellipse();
        Arrow _arrow = new Arrow();
        List<Shape> _shapes = new List<Shape>();
        List<Shape> _redoShapes = new List<Shape>();
        Shape _shape = null;
        Shape _originShape;
        string _mode = "Line";
        const string LINE = "Line";
        const string RECTANGLE = "Rectangle";
        const string ELLIPSE = "Ellipse";
        const string ARROW = "Arrow";
        const string SELECT = "Select";
        double _firstPointX;
        double _firstPointY;
        double _dx;
        double _dy;
        bool _redo = false;
        bool _undo = false;
        bool _find = false;

        //press
        public void PointerPressed(double x, double y)
        {
            if (x > 0 && y > 0)
            {
                _firstPointX = x;
                _firstPointY = y;
                if (_mode == LINE)
                {
                    _line.x1 = _firstPointX;
                    _line.y1 = _firstPointY;
                }
                if (_mode == RECTANGLE)
                {
                    _rectangle.x1 = _firstPointX;
                    _rectangle.y1 = _firstPointY;
                }
                if (_mode == ELLIPSE)
                {
                    _ellipse.x1 = _firstPointX;
                    _ellipse.y1 = _firstPointY;
                }
                if (_mode == ARROW)
                {
                    _arrow.x1 = _firstPointX;
                    _arrow.y1 = _firstPointY;
                }
                if (_mode == SELECT)
                {
                    bool flag = false;
                    foreach (Shape aShape in _shapes)
                    {
                        if (aShape.x1 < _firstPointX && aShape.x2 > _firstPointX && aShape.y1 < _firstPointY && aShape.y2 > _firstPointY)
                        {
                            _shape = aShape;
                            _dx = _firstPointX - aShape.x1;
                            _dy = _firstPointY - aShape.y1;
                            _find = true;
                            flag = true;
                        }
                    }
                    _find = flag;
                    _originShape = _shape;
                }
            }
        }

        //move
        public void PointerMoved(double x, double y)
        {
            if (_mode == LINE)
            {
                _line.x2 = x;
                _line.y2 = y;
            }
            if (_mode == RECTANGLE)
            {
                _rectangle.x2 = x;
                _rectangle.y2 = y;
            }
            if (_mode == ELLIPSE)
            {
                _ellipse.x2 = x;
                _ellipse.y2 = y;
            }
            if (_mode == ARROW)
            {
                _arrow.x2 = x;
                _arrow.y2 = y;
            }
            if (_mode == SELECT && _shape != null)
            {
                _shape.x2 = _shape.x2 - (_shape.x1 - x) - _dx;
                _shape.y2 = _shape.y2 - (_shape.y1 - y) - _dy;
                _shape.x1 = x - _dx;
                _shape.y1 = y - _dy;
            }
        }

        //release
        public void PointerReleased(double x, double y)
        {
            if (_mode == LINE)
            {
                Line hint = new Line();
                hint.x1 = _firstPointX;
                hint.y1 = _firstPointY;
                hint.x2 = x;
                hint.y2 = y;
                _shapes.Add(hint);
                _redoShapes.Clear();
            }
            if (_mode == RECTANGLE)
            {
                Rectangle hint = new Rectangle();
                hint.x1 = _firstPointX;
                hint.y1 = _firstPointY;
                hint.x2 = x;
                hint.y2 = y;
                _shapes.Add(hint);
                _redoShapes.Clear();
            }
            if (_mode == ELLIPSE)
            {
                Ellipse hint = new Ellipse();
                hint.x1 = _firstPointX;
                hint.y1 = _firstPointY;
                hint.x2 = x;
                hint.y2 = y;
                _shapes.Add(hint);
                _redoShapes.Clear();
            }
            if (_mode == ARROW)
            {
                Arrow hint = new Arrow();
                hint.x1 = _firstPointX;
                hint.y1 = _firstPointY;
                hint.x2 = x;
                hint.y2 = y;
                _shapes.Add(hint);
                _redoShapes.Clear();
            }
            if (_mode == SELECT)
            {
                if (_shape != null)
                {
                    if (_shape.x1 != _originShape.x1 || _shape.y1 != _originShape.y1)
                    {
                        int index = _shapes.IndexOf(_originShape);
                        _shapes.Remove(_shape);
                        _shapes.Insert(index, _shape);
                        _shape = null;
                    }
                }
                if (_find == false)
                {
                    _shape = null;
                    _originShape = null;
                }
            }
        }

        //click button "Delete"
        public void ClickDelete()
        {
            if (_shapes.Contains(_originShape) == true)
                _shapes.Remove(_originShape);
            _shape = null;
        }

        //click button "Line"
        public void ClickLine()
        {
            _mode = LINE;
        }

        //click button "Rectangle"
        public void ClickRectangle()
        {
            _mode = RECTANGLE;
        }

        //click button "Ellipse"
        public void ClickEllipse()
        {
            _mode = ELLIPSE;
        }

        //click button "Arrow"
        public void ClickArrow()
        {
            _mode = ARROW;
        }

        //click button "Select"
        public void ClickSelect()
        {
            _mode = SELECT;
        }

        //clear
        public void Clear()
        {
            _shapes.Clear();
            _redoShapes.Clear();
        }

        //undo
        public void ClickUndo()
        {
            if (_shapes.Count > 0)
            {
                _redoShapes.Add(_shapes.Last());
                _shapes.RemoveAt(_shapes.Count() - 1);
            }
        }

        //redo
        public void ClickRedo()
        {
            if (_redoShapes.Count > 0)
            {
                _shapes.Add(_redoShapes.Last());
                _redoShapes.RemoveAt(_redoShapes.Count() - 1);
            }
        }

        //return enable of redo
        public bool GetRedoEnable()
        {
            if (_redoShapes.Count > 0)
                _redo = true;
            else
                _redo = false;
            return _redo;
        }

        //return enable of undo
        public bool GetUndoEnable()
        {
            if (_shapes.Count > 0)
                _undo = true;
            else
                _undo = false;
            return _undo;
        }

        //draw the graphic
        public void Draw(IGraphics graphics, bool isPressed)
        {
            graphics.ClearAll();
            foreach (Shape aShape in _shapes)
                aShape.Draw(graphics);
            if (_shape != null)
                _shape.DrawSelected(graphics);
            if (isPressed)
            {
                if (_mode == LINE)
                    _line.Draw(graphics);
                if (_mode == RECTANGLE)
                    _rectangle.Draw(graphics);
                if (_mode == ELLIPSE)
                    _ellipse.Draw(graphics);
                if (_mode == ARROW)
                    _arrow.Draw(graphics);
                if (_mode == SELECT && _shape != null)
                    _shape.DrawSelected(graphics);
            }
        }
    }
}
