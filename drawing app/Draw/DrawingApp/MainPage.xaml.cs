using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

//空白頁項目範本收錄在 http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DrawingApp
{
    /// <summary>
    /// 可以在本身使用或巡覽至框架內的空白頁面。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        DrawingModel.Model _model;
        PresentationModel.PresentationModel _presentationModel;

        //mainpage
        public MainPage()
        {
            this.InitializeComponent();
            _model = new DrawingModel.Model();
            _presentationModel = new PresentationModel.PresentationModel(_model, _canvas);
            _canvas.PointerPressed += HandleCanvasPressed;
            _canvas.PointerReleased += HandleCanvasReleased;
            _canvas.PointerMoved += HandleCanvasMoved;
            _rectangle.Click += HandleRectangleButtonClick;
            _ellipse.Click += HandleEllipseButtonClick;
            _line.Click += HandleLineButtonClick;
            _clear.Click += HandleClearButtonClick;
            _undo.Click += HandleUndoButtonClick;
            _redo.Click += HandleRedoButtonClick;
            _select.Click += HandleSelectButtonClick;
            _delete.Click += HandleDeleteButtonClick;
            _model._modelChanged += HandleModelChanged;
        }

        //click rectangle
        private void HandleRectangleButtonClick(object sender, RoutedEventArgs e)
        {
            _model.ClickRectangle();
            _line.IsEnabled = true;
            _ellipse.IsEnabled = true;
            _rectangle.IsEnabled = false;
        }

        //click line
        private void HandleLineButtonClick(object sender, RoutedEventArgs e)
        {
            _model.ClickLine();
            _line.IsEnabled = false;
            _rectangle.IsEnabled = true;
            _ellipse.IsEnabled = true;
        }

        //click ellipse
        private void HandleEllipseButtonClick(object sender, RoutedEventArgs e)
        {
            _model.ClickEllipse();
            _ellipse.IsEnabled = false;
            _line.IsEnabled = true;
            _rectangle.IsEnabled = true;
        }

        //click select
        public void HandleSelectButtonClick(object sender, RoutedEventArgs e)
        {
            _model.ClickSelect();
            _select.IsEnabled = false;
            _ellipse.IsEnabled = true;
            _line.IsEnabled = true;
            _rectangle.IsEnabled = true;
        }

        //click delete
        public void HandleDeleteButtonClick(object sender, RoutedEventArgs e)
        {
            _model.ClickDelete();
            _delete.IsEnabled = true;
        }

        //click clear
        private void HandleClearButtonClick(object sender, RoutedEventArgs e)
        {
            _model.Clear();
            _undo.IsEnabled = _model.GetUndoEnable();
            _redo.IsEnabled = _model.GetRedoEnable();
        }

        //click undo
        private void HandleUndoButtonClick(object sender, RoutedEventArgs e)
        {
            _model.ClickUndo();
            _undo.IsEnabled = _model.GetUndoEnable();
            _redo.IsEnabled = _model.GetRedoEnable();
        }

        //click redo
        private void HandleRedoButtonClick(object sender, RoutedEventArgs e)
        {
            _model.ClickRedo();
            _undo.IsEnabled = _model.GetUndoEnable();
            _redo.IsEnabled = _model.GetRedoEnable();
        }

        //press mouse
        public void HandleCanvasPressed(object sender, PointerRoutedEventArgs e)
        {
            _model.PointerPressed(e.GetCurrentPoint(_canvas).Position.X, e.GetCurrentPoint(_canvas).Position.Y);
        }

        //release mouse
        public void HandleCanvasReleased(object sender, PointerRoutedEventArgs e)
        {
            _model.PointerReleased(e.GetCurrentPoint(_canvas).Position.X, e.GetCurrentPoint(_canvas).Position.Y);
            _undo.IsEnabled = _model.GetUndoEnable();
            _redo.IsEnabled = _model.GetRedoEnable();
        }

        //move mouse
        public void HandleCanvasMoved(object sender, PointerRoutedEventArgs e)
        {
            _model.PointerMoved(e.GetCurrentPoint(_canvas).Position.X, e.GetCurrentPoint(_canvas).Position.Y);
        }

        //model change
        public void HandleModelChanged()
        {
            _presentationModel.Draw();
        }
    }
}
