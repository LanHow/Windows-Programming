namespace DrawingForm
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this._buttonDelete = new System.Windows.Forms.Button();
            this._panel = new DrawingForm.DoubleBufferedPanel();
            this._buttonSelect = new System.Windows.Forms.Button();
            this._buttonArrow = new System.Windows.Forms.Button();
            this._buttonSave = new System.Windows.Forms.Button();
            this._buttonRedo = new System.Windows.Forms.Button();
            this._buttonUndo = new System.Windows.Forms.Button();
            this._buttonEllipse = new System.Windows.Forms.Button();
            this._buttonRectangle = new System.Windows.Forms.Button();
            this._buttonLine = new System.Windows.Forms.Button();
            this._buttonClear = new System.Windows.Forms.Button();
            this._panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _buttonDelete
            // 
            this._buttonDelete.Location = new System.Drawing.Point(322, 157);
            this._buttonDelete.Name = "_buttonDelete";
            this._buttonDelete.Size = new System.Drawing.Size(75, 23);
            this._buttonDelete.TabIndex = 9;
            this._buttonDelete.Text = "Delete";
            this._buttonDelete.UseVisualStyleBackColor = true;
            this._buttonDelete.Click += new System.EventHandler(this.HandleDeleteButtonClick);
            // 
            // _panel
            // 
            this._panel.BackColor = System.Drawing.Color.LightYellow;
            this._panel.Controls.Add(this._buttonDelete);
            this._panel.Controls.Add(this._buttonSelect);
            this._panel.Controls.Add(this._buttonArrow);
            this._panel.Controls.Add(this._buttonSave);
            this._panel.Controls.Add(this._buttonRedo);
            this._panel.Controls.Add(this._buttonUndo);
            this._panel.Controls.Add(this._buttonEllipse);
            this._panel.Controls.Add(this._buttonRectangle);
            this._panel.Controls.Add(this._buttonLine);
            this._panel.Controls.Add(this._buttonClear);
            this._panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._panel.Location = new System.Drawing.Point(0, 0);
            this._panel.Name = "_panel";
            this._panel.Size = new System.Drawing.Size(409, 287);
            this._panel.TabIndex = 0;
            this._panel.Paint += new System.Windows.Forms.PaintEventHandler(this.HandleCanvasPaint);
            this._panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HandleCanvasPressed);
            this._panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HandleCanvasMoved);
            this._panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HandleCanvasReleased);
            // 
            // _buttonSelect
            // 
            this._buttonSelect.Location = new System.Drawing.Point(322, 128);
            this._buttonSelect.Name = "_buttonSelect";
            this._buttonSelect.Size = new System.Drawing.Size(75, 23);
            this._buttonSelect.TabIndex = 8;
            this._buttonSelect.Text = "Select";
            this._buttonSelect.UseVisualStyleBackColor = true;
            this._buttonSelect.Click += new System.EventHandler(this.HandleSelectButtonClick);
            // 
            // _buttonArrow
            // 
            this._buttonArrow.Location = new System.Drawing.Point(311, 12);
            this._buttonArrow.Name = "_buttonArrow";
            this._buttonArrow.Size = new System.Drawing.Size(95, 23);
            this._buttonArrow.TabIndex = 7;
            this._buttonArrow.Text = "Arrow";
            this._buttonArrow.UseVisualStyleBackColor = true;
            this._buttonArrow.Click += new System.EventHandler(this.HandleArrowButtonClick);
            // 
            // _buttonSave
            // 
            this._buttonSave.Location = new System.Drawing.Point(291, 261);
            this._buttonSave.Name = "_buttonSave";
            this._buttonSave.Size = new System.Drawing.Size(115, 23);
            this._buttonSave.TabIndex = 6;
            this._buttonSave.Text = "Save to Google Drive";
            this._buttonSave.UseVisualStyleBackColor = true;
            this._buttonSave.Click += new System.EventHandler(this.ClickSaveButton);
            // 
            // _buttonRedo
            // 
            this._buttonRedo.Enabled = false;
            this._buttonRedo.Location = new System.Drawing.Point(322, 99);
            this._buttonRedo.Name = "_buttonRedo";
            this._buttonRedo.Size = new System.Drawing.Size(75, 23);
            this._buttonRedo.TabIndex = 5;
            this._buttonRedo.TabStop = false;
            this._buttonRedo.Text = "Redo";
            this._buttonRedo.UseVisualStyleBackColor = true;
            this._buttonRedo.Click += new System.EventHandler(this.HandleRedoButtonClick);
            // 
            // _buttonUndo
            // 
            this._buttonUndo.Enabled = false;
            this._buttonUndo.Location = new System.Drawing.Point(322, 70);
            this._buttonUndo.Name = "_buttonUndo";
            this._buttonUndo.Size = new System.Drawing.Size(75, 23);
            this._buttonUndo.TabIndex = 4;
            this._buttonUndo.TabStop = false;
            this._buttonUndo.Text = "Undo";
            this._buttonUndo.UseVisualStyleBackColor = true;
            this._buttonUndo.Click += new System.EventHandler(this.HandleUndoButtonClick);
            // 
            // _buttonEllipse
            // 
            this._buttonEllipse.Location = new System.Drawing.Point(210, 12);
            this._buttonEllipse.Name = "_buttonEllipse";
            this._buttonEllipse.Size = new System.Drawing.Size(95, 23);
            this._buttonEllipse.TabIndex = 3;
            this._buttonEllipse.TabStop = false;
            this._buttonEllipse.Text = "Ellipse";
            this._buttonEllipse.UseVisualStyleBackColor = true;
            this._buttonEllipse.Click += new System.EventHandler(this.HandleEllipseButtonClick);
            // 
            // _buttonRectangle
            // 
            this._buttonRectangle.Location = new System.Drawing.Point(109, 12);
            this._buttonRectangle.Name = "_buttonRectangle";
            this._buttonRectangle.Size = new System.Drawing.Size(95, 23);
            this._buttonRectangle.TabIndex = 2;
            this._buttonRectangle.TabStop = false;
            this._buttonRectangle.Text = "Rectangle";
            this._buttonRectangle.UseVisualStyleBackColor = true;
            this._buttonRectangle.Click += new System.EventHandler(this.HandleRectangleButtonClick);
            // 
            // _buttonLine
            // 
            this._buttonLine.Enabled = false;
            this._buttonLine.Location = new System.Drawing.Point(8, 12);
            this._buttonLine.Name = "_buttonLine";
            this._buttonLine.Size = new System.Drawing.Size(95, 23);
            this._buttonLine.TabIndex = 1;
            this._buttonLine.TabStop = false;
            this._buttonLine.Text = "Line";
            this._buttonLine.UseVisualStyleBackColor = true;
            this._buttonLine.Click += new System.EventHandler(this.HandleLineButtonClick);
            // 
            // _buttonClear
            // 
            this._buttonClear.Location = new System.Drawing.Point(311, 41);
            this._buttonClear.Name = "_buttonClear";
            this._buttonClear.Size = new System.Drawing.Size(95, 23);
            this._buttonClear.TabIndex = 0;
            this._buttonClear.TabStop = false;
            this._buttonClear.Text = "Clear";
            this._buttonClear.UseVisualStyleBackColor = true;
            this._buttonClear.Click += new System.EventHandler(this.HandleClearButtonClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 287);
            this.Controls.Add(this._panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this._panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private DoubleBufferedPanel _panel;
        private System.Windows.Forms.Button _buttonRectangle;
        private System.Windows.Forms.Button _buttonLine;
        private System.Windows.Forms.Button _buttonClear;

        #endregion

        private System.Windows.Forms.Button _buttonEllipse;
        private System.Windows.Forms.Button _buttonRedo;
        private System.Windows.Forms.Button _buttonUndo;
        private System.Windows.Forms.Button _buttonSave;
        private System.Windows.Forms.Button _buttonArrow;
        private System.Windows.Forms.Button _buttonSelect;
        private System.Windows.Forms.Button _buttonDelete;
    }
}

