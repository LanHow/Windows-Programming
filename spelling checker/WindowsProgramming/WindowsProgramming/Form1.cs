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

namespace Program

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _groupBoxCustom.DataBindings.Add("Visible", _presentationModel, "ChangeGroupBoxCustomVisible");
            _groupBoxFill.DataBindings.Add("Visible", _presentationModel, "ChangeGroupBoxFillVisible");
            _groupBoxMultiple.DataBindings.Add("Visible", _presentationModel, "ChangeGroupBoxMultipleVisible");
            _buttonStart.DataBindings.Add("Enabled", _presentationModel, "ChangeButtomStartEnabled");
            _buttonNext.DataBindings.Add("Enabled", _presentationModel, "ChangeButtomNextEnabled");
            _buttonStop.DataBindings.Add("Enabled", _presentationModel, "ChangeButtomStopEnabled");
            _groupBoxFill.DataBindings.Add("Text", _presentationModel, "ChangeGroupBoxTextFill");
            _groupBoxMultiple.DataBindings.Add("Text", _presentationModel, "ChangeGroupBoxTextMultiple");
            _labelFillQuestion.DataBindings.Add("Text", _presentationModel, "ChangeLabelFillQuestion");
            _labelMultipleQuestion.DataBindings.Add("Text", _presentationModel, "ChangeLabelMultipleQuestion");
            _multipleOption1.DataBindings.Add("Text", _presentationModel, "ChangeLabelMultipleChoice1");
            _multipleOption2.DataBindings.Add("Text", _presentationModel, "ChangeLabelMultipleChoice2");
            _multipleOption3.DataBindings.Add("Text", _presentationModel, "ChangeLabelMultipleChoice3");
            _multipleOption4.DataBindings.Add("Text", _presentationModel, "ChangeLabelMultipleChoice4");
            _labelResult.DataBindings.Add("Text", _presentationModel, "Check");
            _progressBarTime.DataBindings.Add("Value", _presentationModel, "ChangeTime");
            _labelTime.DataBindings.Add("Text", _presentationModel, "ChangeTotalTime");
            _labelScore.DataBindings.Add("Text", _presentationModel, "ChangeScore");
        }
        //讀取或設立程式所需資料
        private void Form1Load(object sender, EventArgs e)
        {
            _presentationModel.ReadBeforeStart();
        }

        //按下Start的動作
        private void ButtonStartClick(object sender, EventArgs e)
        {  
            _questionAmount = (int)_numericUpDownQuestionNumber.Value;
            _examinationType = _comboBoxQuestionType.SelectedIndex;
            _presentationModel.SetQuestionAmount(_questionAmount, _examinationType);
            _presentationModel.PlusCount();
            _presentationModel.InitializeModel();
            _presentationModel.LoadAllStringList();
            _presentationModel.CreateWrongChoice();         
            _presentationModel.Click();
            _presentationModel.ClickStart();
            _presentationModel.StartTimer();
        }

        //按下Next的動作
        private void ButtonNextClick(object sender, EventArgs e)
        {
            _presentationModel.SetFillAnswer(_textBoxFillAnswer.Text);
            _presentationModel.SetChoiceOne(_multipleOption1.Checked);
            _presentationModel.SetChoiceTwo(_multipleOption2.Checked);
            _presentationModel.SetChoiceThree(_multipleOption3.Checked);
            _presentationModel.SetChoiceFour(_multipleOption4.Checked);
            _presentationModel.DoCheck();
            _presentationModel.PlusCount();
            _presentationModel.FinishExamination(false);
            _presentationModel.CreateWrongChoice();
            _presentationModel.Click();
            _presentationModel.ClickNext();
            ClickNext();
        }

        //stop按下時的動作
        private void ButtonStopClick(object sender, EventArgs e)
        {
            _presentationModel.SetFillAnswer(_textBoxFillAnswer.Text);
            _presentationModel.SetChoiceOne(_multipleOption1.Checked);
            _presentationModel.SetChoiceTwo(_multipleOption2.Checked);
            _presentationModel.SetChoiceThree(_multipleOption3.Checked);
            _presentationModel.SetChoiceFour(_multipleOption4.Checked);
            _presentationModel.DoCheck();
            _presentationModel.PlusCount();
            _presentationModel.ChangeQuestionAmount();
            _presentationModel.FinishExamination(false);
        }

        //將題目總數設為10
        private void SetQuestionNumberTen(object sender, EventArgs e)
        {
            _numericUpDownQuestionNumber.Value = 10;
        }

        //將題目總數設為20
        private void SetQuestionNumberTwenty(object sender, EventArgs e)
        {
            _numericUpDownQuestionNumber.Value = 20;
        }

        //將題目總數設為50
        private void SetQuestionNumberFifty(object sender, EventArgs e)
        {
            _numericUpDownQuestionNumber.Value = 50;
        }

        //關閉程式
        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //將測驗模式設為隨機
        private void SetExaminationTypeRandom(object sender, EventArgs e)
        {
            _comboBoxQuestionType.SelectedIndex = 0;
        }

        //將測驗模式設為填空
        private void SetExaminationTypeFill(object sender, EventArgs e)
        {
            _comboBoxQuestionType.SelectedIndex = 1;
        }

        //將測驗模式設為多選
        private void SetExaminationTypeMultiple(object sender, EventArgs e)
        {
            _comboBoxQuestionType.SelectedIndex = 2;
        }

        //按下help的動作
        private void ClickAboutDictionaryClick(object sender, EventArgs e)
        {
            MessageBox.Show("Total" + _presentationModel.GetLineAmount() + "words in the dictionary");
        }
    }
}
