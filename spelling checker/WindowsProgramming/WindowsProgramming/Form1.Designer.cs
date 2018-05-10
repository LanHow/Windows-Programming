namespace Program
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
            this._tableLayoutPanelAll = new System.Windows.Forms.TableLayoutPanel();
            this._buttonStart = new System.Windows.Forms.Button();
            this._buttonNext = new System.Windows.Forms.Button();
            this._groupBoxMultiple = new System.Windows.Forms.GroupBox();
            this._tableLayoutPanelMultiple = new System.Windows.Forms.TableLayoutPanel();
            this._multipleOption1 = new System.Windows.Forms.RadioButton();
            this._multipleOption2 = new System.Windows.Forms.RadioButton();
            this._multipleOption3 = new System.Windows.Forms.RadioButton();
            this._multipleOption4 = new System.Windows.Forms.RadioButton();
            this._labelMultipleQuestion = new System.Windows.Forms.Label();
            this._groupBoxFill = new System.Windows.Forms.GroupBox();
            this._tableLayoutPanelFill = new System.Windows.Forms.TableLayoutPanel();
            this._labelChinese = new System.Windows.Forms.Label();
            this._labelEnglish = new System.Windows.Forms.Label();
            this._textBoxFillAnswer = new System.Windows.Forms.TextBox();
            this._labelFillQuestion = new System.Windows.Forms.Label();
            this._groupBoxCustom = new System.Windows.Forms.GroupBox();
            this._tableLayoutPanelCustom = new System.Windows.Forms.TableLayoutPanel();
            this._labelNumberOfQuestion = new System.Windows.Forms.Label();
            this._labelQuestionType = new System.Windows.Forms.Label();
            this._numericUpDownQuestionNumber = new System.Windows.Forms.NumericUpDown();
            this._comboBoxQuestionType = new System.Windows.Forms.ComboBox();
            this._buttonStop = new System.Windows.Forms.Button();
            this._labelResult = new System.Windows.Forms.Label();
            this._progressBarTime = new System.Windows.Forms.ProgressBar();
            this._labelTime = new System.Windows.Forms.Label();
            this._labelScore = new System.Windows.Forms.Label();
            this._examinationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._examinationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this._startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._nextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._numberOfQuestionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._questionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._questionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this._questionsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this._questionTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._allFillInTheBlankQuestionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._allMultipleChoiceQuestionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._pickUpQuestionsRandomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._aboutDictionaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._aboutSpellingCheckerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._menuStrip1 = new System.Windows.Forms.MenuStrip();
            this._tableLayoutPanelAll.SuspendLayout();
            this._groupBoxMultiple.SuspendLayout();
            this._tableLayoutPanelMultiple.SuspendLayout();
            this._groupBoxFill.SuspendLayout();
            this._tableLayoutPanelFill.SuspendLayout();
            this._groupBoxCustom.SuspendLayout();
            this._tableLayoutPanelCustom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numericUpDownQuestionNumber)).BeginInit();
            this._menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _tableLayoutPanelAll
            // 
            this._tableLayoutPanelAll.AutoScroll = true;
            this._tableLayoutPanelAll.AutoSize = true;
            this._tableLayoutPanelAll.ColumnCount = 3;
            this._tableLayoutPanelAll.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._tableLayoutPanelAll.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this._tableLayoutPanelAll.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this._tableLayoutPanelAll.Controls.Add(this._buttonStart, 0, 3);
            this._tableLayoutPanelAll.Controls.Add(this._buttonNext, 1, 3);
            this._tableLayoutPanelAll.Controls.Add(this._groupBoxMultiple, 0, 2);
            this._tableLayoutPanelAll.Controls.Add(this._groupBoxFill, 0, 1);
            this._tableLayoutPanelAll.Controls.Add(this._groupBoxCustom, 0, 0);
            this._tableLayoutPanelAll.Controls.Add(this._buttonStop, 2, 3);
            this._tableLayoutPanelAll.Controls.Add(this._labelResult, 0, 5);
            this._tableLayoutPanelAll.Controls.Add(this._progressBarTime, 1, 4);
            this._tableLayoutPanelAll.Controls.Add(this._labelTime, 0, 4);
            this._tableLayoutPanelAll.Controls.Add(this._labelScore, 2, 4);
            this._tableLayoutPanelAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayoutPanelAll.Location = new System.Drawing.Point(0, 28);
            this._tableLayoutPanelAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._tableLayoutPanelAll.Name = "_tableLayoutPanelAll";
            this._tableLayoutPanelAll.RowCount = 6;
            this._tableLayoutPanelAll.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tableLayoutPanelAll.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tableLayoutPanelAll.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tableLayoutPanelAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this._tableLayoutPanelAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this._tableLayoutPanelAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this._tableLayoutPanelAll.Size = new System.Drawing.Size(481, 420);
            this._tableLayoutPanelAll.TabIndex = 0;
            // 
            // _buttonStart
            // 
            this._buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonStart.BackColor = System.Drawing.SystemColors.Control;
            this._buttonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this._buttonStart.Location = new System.Drawing.Point(4, 358);
            this._buttonStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._buttonStart.Name = "_buttonStart";
            this._buttonStart.Size = new System.Drawing.Size(152, 42);
            this._buttonStart.TabIndex = 4;
            this._buttonStart.Text = "Start";
            this._buttonStart.UseVisualStyleBackColor = true;
            this._buttonStart.Click += new System.EventHandler(this.ButtonStartClick);
            // 
            // _buttonNext
            // 
            this._buttonNext.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this._buttonNext.Enabled = false;
            this._buttonNext.Location = new System.Drawing.Point(164, 358);
            this._buttonNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._buttonNext.Name = "_buttonNext";
            this._buttonNext.Size = new System.Drawing.Size(152, 42);
            this._buttonNext.TabIndex = 5;
            this._buttonNext.Text = "Next";
            this._buttonNext.UseVisualStyleBackColor = true;
            this._buttonNext.Click += new System.EventHandler(this.ButtonNextClick);
            // 
            // _groupBoxMultiple
            // 
            this._groupBoxMultiple.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._groupBoxMultiple.AutoSize = true;
            this._tableLayoutPanelAll.SetColumnSpan(this._groupBoxMultiple, 3);
            this._groupBoxMultiple.Controls.Add(this._tableLayoutPanelMultiple);
            this._groupBoxMultiple.Location = new System.Drawing.Point(4, 204);
            this._groupBoxMultiple.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._groupBoxMultiple.Name = "_groupBoxMultiple";
            this._groupBoxMultiple.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._groupBoxMultiple.Size = new System.Drawing.Size(473, 146);
            this._groupBoxMultiple.TabIndex = 8;
            this._groupBoxMultiple.TabStop = false;
            this._groupBoxMultiple.Text = "Q1:Multiple Choice Question";
            // 
            // _tableLayoutPanelMultiple
            // 
            this._tableLayoutPanelMultiple.AutoSize = true;
            this._tableLayoutPanelMultiple.ColumnCount = 1;
            this._tableLayoutPanelMultiple.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tableLayoutPanelMultiple.Controls.Add(this._multipleOption1, 0, 1);
            this._tableLayoutPanelMultiple.Controls.Add(this._multipleOption2, 0, 2);
            this._tableLayoutPanelMultiple.Controls.Add(this._multipleOption3, 0, 3);
            this._tableLayoutPanelMultiple.Controls.Add(this._multipleOption4, 0, 4);
            this._tableLayoutPanelMultiple.Controls.Add(this._labelMultipleQuestion, 0, 0);
            this._tableLayoutPanelMultiple.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayoutPanelMultiple.Location = new System.Drawing.Point(4, 22);
            this._tableLayoutPanelMultiple.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._tableLayoutPanelMultiple.Name = "_tableLayoutPanelMultiple";
            this._tableLayoutPanelMultiple.RowCount = 5;
            this._tableLayoutPanelMultiple.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._tableLayoutPanelMultiple.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._tableLayoutPanelMultiple.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._tableLayoutPanelMultiple.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._tableLayoutPanelMultiple.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._tableLayoutPanelMultiple.Size = new System.Drawing.Size(465, 120);
            this._tableLayoutPanelMultiple.TabIndex = 0;
            // 
            // _multipleOption1
            // 
            this._multipleOption1.AutoSize = true;
            this._multipleOption1.Dock = System.Windows.Forms.DockStyle.Left;
            this._multipleOption1.Location = new System.Drawing.Point(4, 28);
            this._multipleOption1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._multipleOption1.Name = "_multipleOption1";
            this._multipleOption1.Size = new System.Drawing.Size(17, 16);
            this._multipleOption1.TabIndex = 0;
            this._multipleOption1.TabStop = true;
            this._multipleOption1.UseVisualStyleBackColor = true;
            // 
            // _multipleOption2
            // 
            this._multipleOption2.AutoSize = true;
            this._multipleOption2.Location = new System.Drawing.Point(4, 52);
            this._multipleOption2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._multipleOption2.Name = "_multipleOption2";
            this._multipleOption2.Size = new System.Drawing.Size(17, 16);
            this._multipleOption2.TabIndex = 1;
            this._multipleOption2.TabStop = true;
            this._multipleOption2.UseVisualStyleBackColor = true;
            // 
            // _multipleOption3
            // 
            this._multipleOption3.AutoSize = true;
            this._multipleOption3.Location = new System.Drawing.Point(4, 76);
            this._multipleOption3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._multipleOption3.Name = "_multipleOption3";
            this._multipleOption3.Size = new System.Drawing.Size(17, 16);
            this._multipleOption3.TabIndex = 2;
            this._multipleOption3.TabStop = true;
            this._multipleOption3.UseVisualStyleBackColor = true;
            // 
            // _multipleOption4
            // 
            this._multipleOption4.AutoSize = true;
            this._multipleOption4.Location = new System.Drawing.Point(4, 100);
            this._multipleOption4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._multipleOption4.Name = "_multipleOption4";
            this._multipleOption4.Size = new System.Drawing.Size(17, 16);
            this._multipleOption4.TabIndex = 3;
            this._multipleOption4.TabStop = true;
            this._multipleOption4.UseVisualStyleBackColor = true;
            // 
            // _labelMultipleQuestion
            // 
            this._labelMultipleQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._labelMultipleQuestion.AutoSize = true;
            this._labelMultipleQuestion.Location = new System.Drawing.Point(4, 0);
            this._labelMultipleQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._labelMultipleQuestion.Name = "_labelMultipleQuestion";
            this._labelMultipleQuestion.Size = new System.Drawing.Size(457, 24);
            this._labelMultipleQuestion.TabIndex = 4;
            this._labelMultipleQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _groupBoxFill
            // 
            this._groupBoxFill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._groupBoxFill.AutoSize = true;
            this._tableLayoutPanelAll.SetColumnSpan(this._groupBoxFill, 3);
            this._groupBoxFill.Controls.Add(this._tableLayoutPanelFill);
            this._groupBoxFill.Location = new System.Drawing.Point(4, 104);
            this._groupBoxFill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._groupBoxFill.Name = "_groupBoxFill";
            this._groupBoxFill.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._groupBoxFill.Size = new System.Drawing.Size(473, 92);
            this._groupBoxFill.TabIndex = 7;
            this._groupBoxFill.TabStop = false;
            this._groupBoxFill.Text = "Q1:Fill in the Blanks";
            // 
            // _tableLayoutPanelFill
            // 
            this._tableLayoutPanelFill.AutoSize = true;
            this._tableLayoutPanelFill.ColumnCount = 2;
            this._tableLayoutPanelFill.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this._tableLayoutPanelFill.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this._tableLayoutPanelFill.Controls.Add(this._labelChinese, 0, 0);
            this._tableLayoutPanelFill.Controls.Add(this._labelEnglish, 0, 1);
            this._tableLayoutPanelFill.Controls.Add(this._textBoxFillAnswer, 1, 1);
            this._tableLayoutPanelFill.Controls.Add(this._labelFillQuestion, 1, 0);
            this._tableLayoutPanelFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayoutPanelFill.Location = new System.Drawing.Point(4, 22);
            this._tableLayoutPanelFill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._tableLayoutPanelFill.Name = "_tableLayoutPanelFill";
            this._tableLayoutPanelFill.RowCount = 2;
            this._tableLayoutPanelFill.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tableLayoutPanelFill.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tableLayoutPanelFill.Size = new System.Drawing.Size(465, 66);
            this._tableLayoutPanelFill.TabIndex = 0;
            // 
            // _labelChinese
            // 
            this._labelChinese.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._labelChinese.AutoSize = true;
            this._labelChinese.Location = new System.Drawing.Point(4, 0);
            this._labelChinese.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._labelChinese.Name = "_labelChinese";
            this._labelChinese.Size = new System.Drawing.Size(131, 33);
            this._labelChinese.TabIndex = 0;
            this._labelChinese.Text = "Chinese";
            this._labelChinese.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _labelEnglish
            // 
            this._labelEnglish.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._labelEnglish.AutoSize = true;
            this._labelEnglish.Location = new System.Drawing.Point(4, 33);
            this._labelEnglish.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._labelEnglish.Name = "_labelEnglish";
            this._labelEnglish.Size = new System.Drawing.Size(131, 33);
            this._labelEnglish.TabIndex = 1;
            this._labelEnglish.Text = "English";
            this._labelEnglish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _textBoxFillAnswer
            // 
            this._textBoxFillAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._textBoxFillAnswer.Location = new System.Drawing.Point(143, 37);
            this._textBoxFillAnswer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._textBoxFillAnswer.Name = "_textBoxFillAnswer";
            this._textBoxFillAnswer.Size = new System.Drawing.Size(318, 25);
            this._textBoxFillAnswer.TabIndex = 6;
            // 
            // _labelFillQuestion
            // 
            this._labelFillQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._labelFillQuestion.AutoSize = true;
            this._labelFillQuestion.Location = new System.Drawing.Point(143, 0);
            this._labelFillQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._labelFillQuestion.Name = "_labelFillQuestion";
            this._labelFillQuestion.Size = new System.Drawing.Size(318, 33);
            this._labelFillQuestion.TabIndex = 2;
            this._labelFillQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _groupBoxCustom
            // 
            this._groupBoxCustom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._groupBoxCustom.AutoSize = true;
            this._tableLayoutPanelAll.SetColumnSpan(this._groupBoxCustom, 3);
            this._groupBoxCustom.Controls.Add(this._tableLayoutPanelCustom);
            this._groupBoxCustom.Location = new System.Drawing.Point(4, 4);
            this._groupBoxCustom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._groupBoxCustom.Name = "_groupBoxCustom";
            this._groupBoxCustom.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._groupBoxCustom.Size = new System.Drawing.Size(473, 92);
            this._groupBoxCustom.TabIndex = 9;
            this._groupBoxCustom.TabStop = false;
            this._groupBoxCustom.Text = "Customize Your Examination";
            // 
            // _tableLayoutPanelCustom
            // 
            this._tableLayoutPanelCustom.AutoSize = true;
            this._tableLayoutPanelCustom.ColumnCount = 2;
            this._tableLayoutPanelCustom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this._tableLayoutPanelCustom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this._tableLayoutPanelCustom.Controls.Add(this._labelNumberOfQuestion, 0, 0);
            this._tableLayoutPanelCustom.Controls.Add(this._labelQuestionType, 0, 1);
            this._tableLayoutPanelCustom.Controls.Add(this._numericUpDownQuestionNumber, 1, 0);
            this._tableLayoutPanelCustom.Controls.Add(this._comboBoxQuestionType, 1, 1);
            this._tableLayoutPanelCustom.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayoutPanelCustom.Location = new System.Drawing.Point(4, 22);
            this._tableLayoutPanelCustom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._tableLayoutPanelCustom.Name = "_tableLayoutPanelCustom";
            this._tableLayoutPanelCustom.RowCount = 2;
            this._tableLayoutPanelCustom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tableLayoutPanelCustom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tableLayoutPanelCustom.Size = new System.Drawing.Size(465, 66);
            this._tableLayoutPanelCustom.TabIndex = 0;
            // 
            // _labelNumberOfQuestion
            // 
            this._labelNumberOfQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._labelNumberOfQuestion.AutoSize = true;
            this._labelNumberOfQuestion.Location = new System.Drawing.Point(4, 0);
            this._labelNumberOfQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._labelNumberOfQuestion.Name = "_labelNumberOfQuestion";
            this._labelNumberOfQuestion.Size = new System.Drawing.Size(201, 33);
            this._labelNumberOfQuestion.TabIndex = 0;
            this._labelNumberOfQuestion.Text = "Number of Quetions";
            this._labelNumberOfQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _labelQuestionType
            // 
            this._labelQuestionType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._labelQuestionType.AutoSize = true;
            this._labelQuestionType.Location = new System.Drawing.Point(4, 33);
            this._labelQuestionType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._labelQuestionType.Name = "_labelQuestionType";
            this._labelQuestionType.Size = new System.Drawing.Size(201, 33);
            this._labelQuestionType.TabIndex = 1;
            this._labelQuestionType.Text = "Quetion Type";
            this._labelQuestionType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _numericUpDownQuestionNumber
            // 
            this._numericUpDownQuestionNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._numericUpDownQuestionNumber.AutoSize = true;
            this._numericUpDownQuestionNumber.Location = new System.Drawing.Point(213, 4);
            this._numericUpDownQuestionNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._numericUpDownQuestionNumber.Name = "_numericUpDownQuestionNumber";
            this._numericUpDownQuestionNumber.Size = new System.Drawing.Size(248, 25);
            this._numericUpDownQuestionNumber.TabIndex = 2;
            this._numericUpDownQuestionNumber.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // _comboBoxQuestionType
            // 
            this._comboBoxQuestionType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._comboBoxQuestionType.FormattingEnabled = true;
            this._comboBoxQuestionType.Items.AddRange(new object[] {
            "Pick up questions randomly",
            "All fill-in-blanks questions",
            "All multiple-choice questions"});
            this._comboBoxQuestionType.Location = new System.Drawing.Point(213, 37);
            this._comboBoxQuestionType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._comboBoxQuestionType.Name = "_comboBoxQuestionType";
            this._comboBoxQuestionType.Size = new System.Drawing.Size(248, 23);
            this._comboBoxQuestionType.TabIndex = 3;
            this._comboBoxQuestionType.Text = "Pick up questions randomly";
            // 
            // _buttonStop
            // 
            this._buttonStop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this._buttonStop.Enabled = false;
            this._buttonStop.Location = new System.Drawing.Point(324, 358);
            this._buttonStop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._buttonStop.Name = "_buttonStop";
            this._buttonStop.Size = new System.Drawing.Size(153, 42);
            this._buttonStop.TabIndex = 10;
            this._buttonStop.Text = "Stop";
            this._buttonStop.UseVisualStyleBackColor = true;
            this._buttonStop.Click += new System.EventHandler(this.ButtonStopClick);
            // 
            // _labelResult
            // 
            this._labelResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._labelResult.AutoSize = true;
            this._labelResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._tableLayoutPanelAll.SetColumnSpan(this._labelResult, 3);
            this._labelResult.ForeColor = System.Drawing.SystemColors.ControlText;
            this._labelResult.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._labelResult.Location = new System.Drawing.Point(4, 442);
            this._labelResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._labelResult.MaximumSize = new System.Drawing.Size(800, 44);
            this._labelResult.Name = "_labelResult";
            this._labelResult.Size = new System.Drawing.Size(473, 25);
            this._labelResult.TabIndex = 3;
            this._labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _progressBarTime
            // 
            this._progressBarTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._progressBarTime.Location = new System.Drawing.Point(164, 408);
            this._progressBarTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._progressBarTime.MarqueeAnimationSpeed = 10;
            this._progressBarTime.Maximum = 10;
            this._progressBarTime.Name = "_progressBarTime";
            this._progressBarTime.Size = new System.Drawing.Size(152, 30);
            this._progressBarTime.TabIndex = 11;
            // 
            // _labelTime
            // 
            this._labelTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._labelTime.AutoSize = true;
            this._labelTime.Location = new System.Drawing.Point(4, 404);
            this._labelTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._labelTime.Name = "_labelTime";
            this._labelTime.Size = new System.Drawing.Size(152, 38);
            this._labelTime.TabIndex = 12;
            this._labelTime.Text = "label1";
            this._labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _labelScore
            // 
            this._labelScore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._labelScore.AutoSize = true;
            this._labelScore.Location = new System.Drawing.Point(324, 404);
            this._labelScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._labelScore.Name = "_labelScore";
            this._labelScore.Size = new System.Drawing.Size(153, 38);
            this._labelScore.TabIndex = 13;
            this._labelScore.Text = "label2";
            this._labelScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _examinationToolStripMenuItem
            // 
            this._examinationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._exitToolStripMenuItem});
            this._examinationToolStripMenuItem.Name = "_examinationToolStripMenuItem";
            this._examinationToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this._examinationToolStripMenuItem.Text = "File";
            // 
            // _exitToolStripMenuItem
            // 
            this._exitToolStripMenuItem.Name = "_exitToolStripMenuItem";
            this._exitToolStripMenuItem.Size = new System.Drawing.Size(108, 26);
            this._exitToolStripMenuItem.Text = "Exit";
            this._exitToolStripMenuItem.Click += new System.EventHandler(this.Exit);
            // 
            // _examinationToolStripMenuItem1
            // 
            this._examinationToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._startToolStripMenuItem,
            this._nextToolStripMenuItem,
            this._stopToolStripMenuItem,
            this._numberOfQuestionsToolStripMenuItem,
            this._questionTypeToolStripMenuItem});
            this._examinationToolStripMenuItem1.Name = "_examinationToolStripMenuItem1";
            this._examinationToolStripMenuItem1.Size = new System.Drawing.Size(106, 24);
            this._examinationToolStripMenuItem1.Text = "Examination";
            // 
            // _startToolStripMenuItem
            // 
            this._startToolStripMenuItem.Name = "_startToolStripMenuItem";
            this._startToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this._startToolStripMenuItem.Text = "Start";
            this._startToolStripMenuItem.Click += new System.EventHandler(this.ButtonStartClick);
            // 
            // _nextToolStripMenuItem
            // 
            this._nextToolStripMenuItem.Name = "_nextToolStripMenuItem";
            this._nextToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this._nextToolStripMenuItem.Text = "Next";
            this._nextToolStripMenuItem.Click += new System.EventHandler(this.ButtonNextClick);
            // 
            // _stopToolStripMenuItem
            // 
            this._stopToolStripMenuItem.Name = "_stopToolStripMenuItem";
            this._stopToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this._stopToolStripMenuItem.Text = "Stop";
            this._stopToolStripMenuItem.Click += new System.EventHandler(this.ButtonStopClick);
            // 
            // _numberOfQuestionsToolStripMenuItem
            // 
            this._numberOfQuestionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._questionsToolStripMenuItem,
            this._questionsToolStripMenuItem1,
            this._questionsToolStripMenuItem2});
            this._numberOfQuestionsToolStripMenuItem.Name = "_numberOfQuestionsToolStripMenuItem";
            this._numberOfQuestionsToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this._numberOfQuestionsToolStripMenuItem.Text = "Number of Questions";
            // 
            // _questionsToolStripMenuItem
            // 
            this._questionsToolStripMenuItem.Name = "_questionsToolStripMenuItem";
            this._questionsToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this._questionsToolStripMenuItem.Text = "10 Questions";
            this._questionsToolStripMenuItem.Click += new System.EventHandler(this.SetQuestionNumberTen);
            // 
            // _questionsToolStripMenuItem1
            // 
            this._questionsToolStripMenuItem1.Name = "_questionsToolStripMenuItem1";
            this._questionsToolStripMenuItem1.Size = new System.Drawing.Size(176, 26);
            this._questionsToolStripMenuItem1.Text = "20 Questions";
            this._questionsToolStripMenuItem1.Click += new System.EventHandler(this.SetQuestionNumberTwenty);
            // 
            // _questionsToolStripMenuItem2
            // 
            this._questionsToolStripMenuItem2.Name = "_questionsToolStripMenuItem2";
            this._questionsToolStripMenuItem2.Size = new System.Drawing.Size(176, 26);
            this._questionsToolStripMenuItem2.Text = "50 Questions";
            this._questionsToolStripMenuItem2.Click += new System.EventHandler(this.SetQuestionNumberFifty);
            // 
            // _questionTypeToolStripMenuItem
            // 
            this._questionTypeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._allFillInTheBlankQuestionsToolStripMenuItem,
            this._allMultipleChoiceQuestionsToolStripMenuItem,
            this._pickUpQuestionsRandomToolStripMenuItem});
            this._questionTypeToolStripMenuItem.Name = "_questionTypeToolStripMenuItem";
            this._questionTypeToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this._questionTypeToolStripMenuItem.Text = "Question Type";
            // 
            // _allFillInTheBlankQuestionsToolStripMenuItem
            // 
            this._allFillInTheBlankQuestionsToolStripMenuItem.Name = "_allFillInTheBlankQuestionsToolStripMenuItem";
            this._allFillInTheBlankQuestionsToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            this._allFillInTheBlankQuestionsToolStripMenuItem.Text = "All fill-in-blank questions";
            this._allFillInTheBlankQuestionsToolStripMenuItem.Click += new System.EventHandler(this.SetExaminationTypeFill);
            // 
            // _allMultipleChoiceQuestionsToolStripMenuItem
            // 
            this._allMultipleChoiceQuestionsToolStripMenuItem.Name = "_allMultipleChoiceQuestionsToolStripMenuItem";
            this._allMultipleChoiceQuestionsToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            this._allMultipleChoiceQuestionsToolStripMenuItem.Text = "All multiple-choice questions";
            this._allMultipleChoiceQuestionsToolStripMenuItem.Click += new System.EventHandler(this.SetExaminationTypeMultiple);
            // 
            // _pickUpQuestionsRandomToolStripMenuItem
            // 
            this._pickUpQuestionsRandomToolStripMenuItem.Name = "_pickUpQuestionsRandomToolStripMenuItem";
            this._pickUpQuestionsRandomToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            this._pickUpQuestionsRandomToolStripMenuItem.Text = "Pick up questions randomly";
            this._pickUpQuestionsRandomToolStripMenuItem.Click += new System.EventHandler(this.SetExaminationTypeRandom);
            // 
            // _helpToolStripMenuItem
            // 
            this._helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._aboutDictionaryToolStripMenuItem,
            this._aboutSpellingCheckerToolStripMenuItem});
            this._helpToolStripMenuItem.Name = "_helpToolStripMenuItem";
            this._helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this._helpToolStripMenuItem.Text = "Help";
            // 
            // _aboutDictionaryToolStripMenuItem
            // 
            this._aboutDictionaryToolStripMenuItem.Name = "_aboutDictionaryToolStripMenuItem";
            this._aboutDictionaryToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this._aboutDictionaryToolStripMenuItem.Text = "About Dictionary";
            this._aboutDictionaryToolStripMenuItem.Click += new System.EventHandler(this.ClickAboutDictionaryClick);
            // 
            // _aboutSpellingCheckerToolStripMenuItem
            // 
            this._aboutSpellingCheckerToolStripMenuItem.Name = "_aboutSpellingCheckerToolStripMenuItem";
            this._aboutSpellingCheckerToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this._aboutSpellingCheckerToolStripMenuItem.Text = "About Spelling Checker";
            // 
            // _menuStrip1
            // 
            this._menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this._menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._examinationToolStripMenuItem,
            this._examinationToolStripMenuItem1,
            this._helpToolStripMenuItem});
            this._menuStrip1.Location = new System.Drawing.Point(0, 0);
            this._menuStrip1.Name = "_menuStrip1";
            this._menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this._menuStrip1.Size = new System.Drawing.Size(481, 28);
            this._menuStrip1.TabIndex = 1;
            this._menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(481, 448);
            this.Controls.Add(this._tableLayoutPanelAll);
            this.Controls.Add(this._menuStrip1);
            this.MainMenuStrip = this._menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "基本能力測驗英文1000字";
            this.Load += new System.EventHandler(this.Form1Load);
            this._tableLayoutPanelAll.ResumeLayout(false);
            this._tableLayoutPanelAll.PerformLayout();
            this._groupBoxMultiple.ResumeLayout(false);
            this._groupBoxMultiple.PerformLayout();
            this._tableLayoutPanelMultiple.ResumeLayout(false);
            this._tableLayoutPanelMultiple.PerformLayout();
            this._groupBoxFill.ResumeLayout(false);
            this._groupBoxFill.PerformLayout();
            this._tableLayoutPanelFill.ResumeLayout(false);
            this._tableLayoutPanelFill.PerformLayout();
            this._groupBoxCustom.ResumeLayout(false);
            this._groupBoxCustom.PerformLayout();
            this._tableLayoutPanelCustom.ResumeLayout(false);
            this._tableLayoutPanelCustom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numericUpDownQuestionNumber)).EndInit();
            this._menuStrip1.ResumeLayout(false);
            this._menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanelAll;
        private System.Windows.Forms.Label _labelChinese;
        private System.Windows.Forms.Label _labelEnglish;
        private System.Windows.Forms.Label _labelFillQuestion;
        private System.Windows.Forms.Label _labelResult;
        private System.Windows.Forms.Button _buttonStart;
        private System.Windows.Forms.Button _buttonNext;
        private System.Windows.Forms.TextBox _textBoxFillAnswer;
        private System.Windows.Forms.GroupBox _groupBoxFill;
        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanelFill;
        private System.Windows.Forms.GroupBox _groupBoxMultiple;
        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanelMultiple;
        private System.Windows.Forms.RadioButton _multipleOption1;
        private System.Windows.Forms.RadioButton _multipleOption2;
        private System.Windows.Forms.RadioButton _multipleOption3;
        private System.Windows.Forms.RadioButton _multipleOption4;
        private System.Windows.Forms.Label _labelMultipleQuestion;
        private System.Windows.Forms.GroupBox _groupBoxCustom;
        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanelCustom;
        private System.Windows.Forms.Label _labelNumberOfQuestion;
        private System.Windows.Forms.Label _labelQuestionType;
        private System.Windows.Forms.NumericUpDown _numericUpDownQuestionNumber;
        private System.Windows.Forms.ComboBox _comboBoxQuestionType;
        private System.Windows.Forms.Button _buttonStop;
        private System.Windows.Forms.ProgressBar _progressBarTime;
        private System.Windows.Forms.ToolStripMenuItem _examinationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _examinationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem _startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _nextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _numberOfQuestionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _questionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _questionsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem _questionsToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem _questionTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _allFillInTheBlankQuestionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _allMultipleChoiceQuestionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _pickUpQuestionsRandomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _aboutDictionaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _aboutSpellingCheckerToolStripMenuItem;
        private System.Windows.Forms.MenuStrip _menuStrip1;
        private System.Windows.Forms.Label _labelTime;
        private System.Windows.Forms.Label _labelScore;
    }
}

