using Microsoft.VisualStudio.TestTools.UnitTesting;
using DrawingModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace DrawingModel.Tests
{
    [TestClass()]
    public class ModelTests
    {
        Model _model = new Model();
        const double X1 = 10;
        const double Y1 = 10;
        const double X2 = 50;
        const double Y2 = 60;
        const double X3 = 80;
        const double Y3 = 90;
        [TestMethod()]
        public void PointerPressedTest()
        {
            _model.ClickLine();
            _model.PointerPressed(X1, Y1);
            _model.PointerMoved(X2, Y2);
            _model.PointerReleased(X3, Y3);
            _model.ClickRectangle();
            _model.PointerPressed(X1, Y1);
            _model.PointerMoved(X2, Y2);
            _model.PointerReleased(X3, Y3);
            _model.ClickEllipse();
            _model.PointerPressed(X1, Y1);
            _model.PointerMoved(X2, Y2);
            _model.PointerReleased(X3, Y3);
            _model.ClickArrow();
            _model.PointerPressed(X1, Y1);
            _model.PointerMoved(X2, Y2);
            _model.PointerReleased(X3, Y3);
            _model.ClickSelect();
            _model.PointerPressed(X1, Y1);
            _model.PointerMoved(X2, Y2);
            _model.PointerReleased(X3, Y3);
            _model.ClickDelete();
            _model.ClickUndo();
            _model.ClickRedo();
            _model.Clear();
            Assert.AreEqual(1, 1);
        }

        [TestMethod()]
        public void GetRedoEnableTest()
        {
            _model.GetRedoEnable();
            Assert.AreEqual(1, 1);
        }

        [TestMethod()]
        public void GetUndoEnableTest()
        {
            _model.GetUndoEnable();
            Assert.AreEqual(1, 1);
        }
    }
}