using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program
{
    public partial class Form1 : Form
    {
        PresentationModel.PresentationModel _presentationModel = new PresentationModel.PresentationModel();
        int _questionAmount = 10;
        int _examinationType;

        //每次Next按下時所要執行的動作
        private void ClickNext()
        {
            _multipleOption1.Checked = false;
            _multipleOption2.Checked = false;
            _multipleOption3.Checked = false;
            _multipleOption4.Checked = false;
            _textBoxFillAnswer.Text = null; 
        }
    }
}
