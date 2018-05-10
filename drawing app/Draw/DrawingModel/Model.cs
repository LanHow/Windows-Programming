using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingModel
{
    public class Model
    {
        public event ModelChangedEventHandler _modelChanged;
        public delegate void ModelChangedEventHandler();
        bool _isPressed = false;
        ShapeFactory _shapeFactory = new ShapeFactory();
        //press the mouse
        public void PointerPressed(double x, double y)
        {
            _shapeFactory.PointerPressed(x, y);
            if (x > 0 && y > 0)
                _isPressed = true;
        }

        //move the mouse
        public void PointerMoved(double x, double y)
        {
            if (_isPressed)
            {
                _shapeFactory.PointerMoved(x, y);
                NotifyModelChanged();
            }
        }

        //release the mouse
        public void PointerReleased(double x, double y)
        {
            if (_isPressed)
            {
                _isPressed = false;
                _shapeFactory.PointerReleased(x, y);
                NotifyModelChanged();
            }
        }

        //delete
        public void ClickDelete()
        {
            _shapeFactory.ClickDelete();
            NotifyModelChanged();
        }

        //clear the board
        public void Clear()
        {
            _isPressed = false;
            _shapeFactory.Clear();
            NotifyModelChanged();
        }

        //click button "Line"
        public void ClickLine()
        {
            _shapeFactory.ClickLine();
        }

        //click button "Rectangle"
        public void ClickRectangle()
        {
            _shapeFactory.ClickRectangle();
        }

        //click button "Ellipse"
        public void ClickEllipse()
        {
            _shapeFactory.ClickEllipse();
        }

        //click button "Arrow"
        public void ClickArrow()
        {
            _shapeFactory.ClickArrow();
        }

        //click button "Select"
        public void ClickSelect()
        {
            _shapeFactory.ClickSelect();
        }

        //undo
        public void ClickUndo()
        {
            _shapeFactory.ClickUndo();
            NotifyModelChanged();
        }

        //redo
        public void ClickRedo()
        {
            _shapeFactory.ClickRedo();
            NotifyModelChanged();
        }

        //return enable of redo
        public bool GetRedoEnable()
        {
            return _shapeFactory.GetRedoEnable();
        }

        //return enable of undo
        public bool GetUndoEnable()
        {
            return _shapeFactory.GetUndoEnable();
        }

        //draw the graphic
        public void Draw(IGraphics graphics)
        {
            _shapeFactory.Draw(graphics, _isPressed);
        }

        //notifier
        void NotifyModelChanged()
        {
            if (_modelChanged != null)
                _modelChanged();
        }
    }
}
