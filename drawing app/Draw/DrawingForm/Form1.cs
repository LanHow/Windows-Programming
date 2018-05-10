using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DrawingForm
{
    public partial class Form1 : Form
    {
        DrawingModel.Model _model;
        PresentationModel.PresentationModel _presentationModel;
        Panel _canvas = new DoubleBufferedPanel();
        const string FILENAME = "Draw.jpeg";
        GoogleDriveService _service;

        public Form1()
        {
            const string APPLICATION_NAME = "DrawAnywhere";
            const string CLIENT_SECRET_FILE_NAME = "clientSecret.json";
            const string PATH = "C:/Users/user/Desktop";
            InitializeComponent();
            //
            // prepare presentation model and model
            //
            _model = new DrawingModel.Model();
            _presentationModel = new PresentationModel.PresentationModel(_model, _panel);
            _model._modelChanged += HandleModelChanged;
            _service = new GoogleDriveService(APPLICATION_NAME, CLIENT_SECRET_FILE_NAME);
            List<Google.Apis.Drive.v2.Data.File> fileList = _service.ListRootFileAndFolder();
            Google.Apis.Drive.v2.Data.File foundFile = fileList.Find(item => { return item.Title == FILENAME; });
            int find = fileList.FindIndex(item => { return item.Title == FILENAME; });
            if (find != -1)
                _service.DownloadFile(foundFile, PATH);
        }

        //click line
        public void HandleLineButtonClick(object sender, System.EventArgs e)
        {
            _model.ClickLine();
            _buttonLine.Enabled = false;
            _buttonRectangle.Enabled = true;
            _buttonEllipse.Enabled = true;
            _buttonArrow.Enabled = true;
            _buttonSelect.Enabled = true;
        }

        //click rectangle
        public void HandleRectangleButtonClick(object sender, System.EventArgs e)
        {
            _model.ClickRectangle();
            _buttonRectangle.Enabled = false;
            _buttonLine.Enabled = true;
            _buttonEllipse.Enabled = true;
            _buttonArrow.Enabled = true;
            _buttonSelect.Enabled = true;
        }

        //click ellipse
        public void HandleEllipseButtonClick(object sender, System.EventArgs e)
        {
            _model.ClickEllipse();
            _buttonEllipse.Enabled = false;
            _buttonLine.Enabled = true;
            _buttonRectangle.Enabled = true;
            _buttonArrow.Enabled = true;
            _buttonSelect.Enabled = true;
        }

        //click arrow
        public void HandleArrowButtonClick(object sender, System.EventArgs e)
        {
            _model.ClickArrow();
            _buttonEllipse.Enabled = true;
            _buttonLine.Enabled = true;
            _buttonRectangle.Enabled = true;
            _buttonArrow.Enabled = false;
            _buttonSelect.Enabled = true;
        }

        //click select
        public void HandleSelectButtonClick(object sender, System.EventArgs e)
        {
            _model.ClickSelect();
            _buttonSelect.Enabled = false;
            _buttonEllipse.Enabled = true;
            _buttonLine.Enabled = true;
            _buttonRectangle.Enabled = true;
            _buttonArrow.Enabled = true;
        }

        //click delete
        public void HandleDeleteButtonClick(object sender, System.EventArgs e)
        {
            _model.ClickDelete();
            _buttonDelete.Enabled = true;
        }

        //click clear
        public void HandleClearButtonClick(object sender, System.EventArgs e)
        {
            _model.Clear();
            _buttonUndo.Enabled = false;
            _buttonRedo.Enabled = false;
        }

        //click undo
        public void HandleUndoButtonClick(object sender, System.EventArgs e)
        {
            _model.ClickUndo();
            _buttonUndo.Enabled = _model.GetUndoEnable();
            _buttonRedo.Enabled = _model.GetRedoEnable();
        }

        //click redo 
        public void HandleRedoButtonClick(object sender, System.EventArgs e)
        {
            _model.ClickRedo();
            _buttonRedo.Enabled = _model.GetRedoEnable();
            _buttonUndo.Enabled = _model.GetUndoEnable();
        }

        //press mouse
        public void HandleCanvasPressed(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            _model.PointerPressed(e.X, e.Y);
        }

        //release mouse
        public void HandleCanvasReleased(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            _model.PointerReleased(e.X, e.Y);
            _buttonUndo.Enabled = _model.GetUndoEnable();
            _buttonRedo.Enabled = _model.GetRedoEnable();
        }

        //move mouse
        public void HandleCanvasMoved(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            _model.PointerMoved(e.X, e.Y);
        }

        //paint
        public void HandleCanvasPaint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            _presentationModel.Draw(e.Graphics);
        }

        //click save
        private void ClickSaveButton(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(_panel.Width, _panel.Height);
            _panel.DrawToBitmap(bitmap, new Rectangle(0, 0, _panel.Width, _panel.Height));
            bitmap.Save(FILENAME);
            const string CONTENT_TYPE = "image/jpeg";
            List<Google.Apis.Drive.v2.Data.File> fileList = _service.ListRootFileAndFolder();
            Google.Apis.Drive.v2.Data.File foundFile = fileList.Find(item => { return item.Title == FILENAME; });
            int exist = fileList.FindIndex(item => { return item.Title == FILENAME; });
            if (exist != -1)
                _service.UpdateFile(FILENAME, foundFile.Id, CONTENT_TYPE);
            else
                _service.UploadFile(FILENAME, CONTENT_TYPE);
        }

        //change view
        public void HandleModelChanged()
        {
            Invalidate(true);
        }
    }
}
