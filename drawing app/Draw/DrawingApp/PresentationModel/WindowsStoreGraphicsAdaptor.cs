using Windows.UI;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Xaml.Media;
using DrawingModel;
using System;
namespace DrawingApp.PresentationModel
{
    class WindowsStoreGraphicsAdaptor : IGraphics
    {
        Canvas _canvas;
        public WindowsStoreGraphicsAdaptor(Canvas canvas)
        {
            this._canvas = canvas;
        }
        
        //clear
        public void ClearAll()
        {
            _canvas.Children.Clear();
        }

        //draw line
        public void DrawLine(double x1, double y1, double x2, double y2)
        {
            Windows.UI.Xaml.Shapes.Line line = new Windows.UI.Xaml.Shapes.Line();
            line.X1 = x1;
            line.Y1 = y1;
            line.X2 = x2;
            line.Y2 = y2;
            line.Stroke = new SolidColorBrush(Colors.Black);
            _canvas.Children.Add(line);
        }

        //draw selected line
        public void DrawSelectedLine(double x1, double y1, double x2, double y2)
        {
            Windows.UI.Xaml.Shapes.Line line = new Windows.UI.Xaml.Shapes.Line();
            line.X1 = x1;
            line.Y1 = y1;
            line.X2 = x2;
            line.Y2 = y2;
            line.Stroke = new SolidColorBrush(Colors.Red);
            _canvas.Children.Add(line);
        }

        //draw rectangle
        public void DrawRectangle(double x1, double y1, double x2, double y2)
        {
            double width;
            double height;
            height = Math.Abs(y1 - y2);
            width = Math.Abs(x1 - x2);
            Windows.UI.Xaml.Shapes.Rectangle rectangle = new Windows.UI.Xaml.Shapes.Rectangle();
            rectangle.Width = width;
            rectangle.Height = height;
            rectangle.Margin = new Windows.UI.Xaml.Thickness(x1, y1, x2, y2);
            rectangle.Fill = new SolidColorBrush(Colors.Yellow);
            rectangle.Stroke = new SolidColorBrush(Colors.Black);
            _canvas.Children.Add(rectangle);
        }

        //draw selected rectangle
        public void DrawSelectedRectangle(double x1, double y1, double x2, double y2)
        {
            double width;
            double height;
            height = Math.Abs(y1 - y2);
            width = Math.Abs(x1 - x2);
            Windows.UI.Xaml.Shapes.Rectangle rectangle = new Windows.UI.Xaml.Shapes.Rectangle();
            rectangle.Width = width;
            rectangle.Height = height;
            rectangle.Margin = new Windows.UI.Xaml.Thickness(x1, y1, x2, y2);
            rectangle.Fill = new SolidColorBrush(Colors.Yellow);
            rectangle.Stroke = new SolidColorBrush(Colors.Red);
            _canvas.Children.Add(rectangle);
        }

        //draw ellipse
        public void DrawEllipse(double x1, double y1, double x2, double y2)
        {
            double width, height;
            height = Math.Abs(y1 - y2);
            width = Math.Abs(x1 - x2);
            Windows.UI.Xaml.Shapes.Ellipse ellipse = new Windows.UI.Xaml.Shapes.Ellipse();
            ellipse.Width = width;
            ellipse.Height = height;
            ellipse.Margin = new Windows.UI.Xaml.Thickness(x1, y1, x2, y2);
            ellipse.Fill = new SolidColorBrush(Colors.Green);
            ellipse.Stroke = new SolidColorBrush(Colors.Black);
            _canvas.Children.Add(ellipse);
        }

        //draw selected ellipse
        public void DrawSelectedEllipse(double x1, double y1, double x2, double y2)
        {
            double width, height;
            height = Math.Abs(y1 - y2);
            width = Math.Abs(x1 - x2);
            Windows.UI.Xaml.Shapes.Ellipse ellipse = new Windows.UI.Xaml.Shapes.Ellipse();
            ellipse.Width = width;
            ellipse.Height = height;
            ellipse.Margin = new Windows.UI.Xaml.Thickness(x1, y1, x2, y2);
            ellipse.Fill = new SolidColorBrush(Colors.Green);
            ellipse.Stroke = new SolidColorBrush(Colors.Red);
            _canvas.Children.Add(ellipse);
        }

        //draw arrow
        public void DrawArrow(double x1, double y1, double x2, double y2)
        {
            
        }

        //draw selected arrow
        public void DrawSelectedArrow(double x1, double y1, double x2, double y2)
        {

        }
    }
}
