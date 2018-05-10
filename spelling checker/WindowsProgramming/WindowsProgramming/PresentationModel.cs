using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace PresentationModel
{
    public class PresentationModel:INotifyPropertyChanged
    {
        private Model.ReadFile _readFile = new Model.ReadFile();
        private Model.Separation _separation = new Model.Separation();
        private Model.Blank _blank = new Model.Blank();
        private Model.QuestionIndex _questionIndex = new Model.QuestionIndex();
        private Model.QuestionType _questionType = new Model.QuestionType();
        private Model.QuestionText _questionText = new Model.QuestionText();
        private Model.Check _check = new Model.Check();
        private List<int> _randomQuestionTypeList = new List<int>();
        private List<string> _chineseList = new List<string>();
        private List<string> _englishList = new List<string>();
        private List<string> _blankEnglishList = new List<string>();
        private string _groupBoxFillText;
        private string _groupBoxMultipleText;
        private string _blankEnglish;
        private string _multipleQuestion;
        private string _result;
        private int _count = -1;
        private int _questionAmount = 0;
        private int _examinationType;
        private string _userFillAnswer;
        private bool _choiceOne = false;
        private bool _choiceTwo = false;
        private bool _choiceThree = false;
        private bool _choiceFour = false;
        private bool _buttonStartEnable = true;
        private bool _buttonNextEnable = false;
        private bool _buttonStopEnable = false;
        private bool _groupBoxCustomVisible = true;
        private bool _groupBoxFillVisible;
        private bool _groupBoxMultipleVisible;
        private List<string> _multipleChoiceList = new List<string>();
        private const int MILLISECONDS_PER_SECOND = 1000;
        private Timer _timer;
        private int _time = 10;
        private string _totalTimeString;
        private int _second = 0;
        private int _minute = 0;
        private int _hour = 0;
        private string _secondString = "00";
        private string _minuteString = "00";
        private string _hourString = "00";
        private double _score = 0;
        private double _pointEveryQuestion = 10;
        private double _deadlineCount = 0;

        //啟動計時器
        public void StartTimer()
        {
            _timer = new Timer();
            _timer.Interval = MILLISECONDS_PER_SECOND;
            _timer.Tick += TickEventHandler;
            _timer.Start();
        }

        //每秒執行一次的動作
        private void TickEventHandler(object s, EventArgs e)
        {
            ChangeTime = 0;
            ChangeTotalTime = "";
        }

        //屬性變更呼叫
        void NotifyPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        //property
        public string ChangeTotalTime
        {
            get
            {
                return _totalTimeString;
            }
            set
            {
                if (_second < 59)
                    _second++;
                else if (_minute < 59)
                {
                    _second = 0;
                    _minute++;
                }
                else
                {
                    _second = 0;
                    _minute = 0;
                    _hour++;
                }
                _totalTimeString = TransformTotalTimeToString(false);
            }
        }

        //將時間轉成字串
        public string TransformTotalTimeToString(bool test)
        {
            if (_second < 10 && test == false)
                _secondString = "0" + _second.ToString();
            else
                _secondString = _second.ToString();
            if (_minute < 10 && test == false)
                _minuteString = "0" + _minute.ToString();
            else
                _minuteString = _minute.ToString();
            if (_hour < 10 && test == false)
                _hourString = "0" + _hour.ToString();
            else
                _hourString = _hour.ToString();
            return _hourString + ":" + _minuteString + ":" + _secondString;
        }

        //property
        public int ChangeTime
        {
            get
            {
                return _time;
            }
            set
            {
                if (_time > 0)
                    _time--;
                else
                {
                    _time = 9;
                    _deadlineCount++;
                    ChangeScore = "";
                }
                NotifyPropertyChanged();
            }
        }

        //property
        public string ChangeScore
        {
            get
            {
                return "Score:" + _score.ToString();
            }
            set
            {
                if (_check.GetCorrect() == _questionAmount)
                    _score = 100 - _deadlineCount;
                else
                    _score = _pointEveryQuestion * _check.GetCorrect() - _deadlineCount;
                NotifyPropertyChanged();
            }
        }

        //property
        public bool ChangeGroupBoxCustomVisible
        {
            get
            {
                return _groupBoxCustomVisible;
            }
            set
            {
                _groupBoxCustomVisible = value;
                NotifyPropertyChanged();
            }
        }

        //property
        public bool ChangeGroupBoxFillVisible
        {
            get
            {
                return _groupBoxFillVisible;
            }
            set
            {
                _groupBoxFillVisible = value;
                NotifyPropertyChanged();
            }
        }

        //property
        public bool ChangeGroupBoxMultipleVisible
        {
            get
            {
                return _groupBoxMultipleVisible;
            }
            set
            {
                _groupBoxMultipleVisible = value;
                NotifyPropertyChanged();
            }
        }

        //property
        public bool ChangeButtomStartEnabled
        {
            get
            {
                return _buttonStartEnable;
            }
            set
            {
                _buttonStartEnable = value;
                NotifyPropertyChanged();
            }
        }

        //property
        public bool ChangeButtomNextEnabled
        {
            get
            {
                return _buttonNextEnable;
            }
            set
            {
                _buttonNextEnable = value;
                NotifyPropertyChanged();
            }
        }

        //property
        public bool ChangeButtomStopEnabled
        {
            get
            {
                return _buttonStopEnable;
            }
            set
            {
                _buttonStopEnable = value;
                NotifyPropertyChanged();
            }
        }

        //按下start執行的指令
        public void ClickStart()
        {
            ChangeGroupBoxCustomVisible = false;
            ChangeButtomStartEnabled = false;
            ChangeButtomNextEnabled = true;
            ChangeButtomStopEnabled = true;
            _pointEveryQuestion = 100 / _questionAmount;
            ClickNext();
        }

        //按下next執行的指令
        public void ClickNext()
        {
            if(_count < _questionAmount && _count >= 0)
            {
                if (_examinationType == 1 || _randomQuestionTypeList.ElementAt(_count) == 1)
                {
                    ChangeGroupBoxFillVisible = true;
                    ChangeGroupBoxMultipleVisible = false;
                }
                else
                {
                    ChangeGroupBoxMultipleVisible = true;
                    ChangeGroupBoxFillVisible = false;
                }
                _time = 10;
            }
        }

        //property
        public string ChangeGroupBoxTextFill
        {
            get
            {
                return _groupBoxFillText;
            }
            set
            {
                _groupBoxFillText = "Q" + (_count + 1) + ":Fill in the Blanks";
                NotifyPropertyChanged();
            }
        }

        //property
        public string ChangeGroupBoxTextMultiple
        {
            get
            {
                return _groupBoxMultipleText;
            }
            set
            {
                _groupBoxMultipleText = "Q" + (_count + 1) + ":Multiple Choice Question";
                NotifyPropertyChanged();
            }
        }

        //property
        public string ChangeLabelFillQuestion
        {
            get
            {
                return _blankEnglish;
            }
            set
            {
                if(_count < _questionAmount)
                    if (_examinationType == 1 || _randomQuestionTypeList.ElementAt(_count).Equals(1))
                    {
                        _blankEnglish = _blankEnglishList.ElementAt(_count);
                        NotifyPropertyChanged();
                    }
            }
        }

        //property
        public string ChangeLabelMultipleQuestion
        {
            get
            {
                return _multipleQuestion;
            }
            set
            {
                if (_randomQuestionTypeList.ElementAt(_count) == 2 && (_examinationType == 0 || _examinationType == 2))
                {
                    _multipleQuestion = _chineseList.ElementAt(_count);
                    NotifyPropertyChanged();
                }
                else if(_randomQuestionTypeList.ElementAt(_count) == 3 && (_examinationType == 0 || _examinationType == 2))
                {
                    _multipleQuestion = _englishList.ElementAt(_count);
                    NotifyPropertyChanged();
                }
            }
        }

        //製造錯誤選項
        public void CreateWrongChoice()
        {
            if(_count < _questionAmount && _count >= 0)
            {
                int _correct;
                Random _randomNumber = new Random();
                _multipleChoiceList = _separation.GetWrongChoice(_randomQuestionTypeList.ElementAt(_count));
                List<string> list = new List<string>();
                if (_randomQuestionTypeList.ElementAt(_count) == 2)
                    list = _englishList;
                else
                    list = _chineseList;
                _correct = _randomNumber.Next(0, 4);
                _multipleChoiceList.Insert(_correct, list.ElementAt(_count));
            }  
        }

        //property
        public string ChangeLabelMultipleChoice1
        {
            get
            {
                if (_multipleChoiceList.Count > 0)
                    return _multipleChoiceList[0];
                else
                    return "";
            }
            set
            {
                if (_examinationType != 1 && _randomQuestionTypeList.ElementAt(_count) != 1)
                    NotifyPropertyChanged();
            }
        }

        //property
        public string ChangeLabelMultipleChoice2
        {
            get
            {
                if (_multipleChoiceList.Count > 0)
                    return _multipleChoiceList[1];
                else
                    return "";
            }
            set
            {
                if (_examinationType != 1 && _randomQuestionTypeList.ElementAt(_count) != 1)
                    NotifyPropertyChanged();
            }
        }
        
        //property
        public string ChangeLabelMultipleChoice3
        {
            get
            {
                if (_multipleChoiceList.Count > 0)
                    return _multipleChoiceList[2];
                else
                    return "";
            }
            set
            {
                if (_examinationType != 1 && _randomQuestionTypeList.ElementAt(_count) != 1)
                    NotifyPropertyChanged();
            }
        }
        
        //property
        public string ChangeLabelMultipleChoice4
        {
            get
            {
                if (_multipleChoiceList.Count > 0)
                    return _multipleChoiceList[3];
                else
                    return "";
            }
            set
            {
                if (_examinationType != 1 && _randomQuestionTypeList.ElementAt(_count) != 1)
                    NotifyPropertyChanged();
            }
        }

        //檢查答案
        public string Check
        {
            get
            {
                return _result;
            }
            set
            {
                if (_count >= 0)
                {
                    if (_examinationType == 1)
                        _result = _check.CheckAnswer(_userFillAnswer, _englishList.ElementAt(_count));
                    else if (_examinationType == 2)
                        _result = CheckExaminationMultiple();
                    else
                        _result = CheckExaminationRandom();
                }
                NotifyPropertyChanged();
            }
        }

        //變更結果屬性
        public void DoCheck()
        {
            Check = "";
            ChangeScore = "";
        }

        //檢查多選題
        public bool CheckMultipleAnswer(int type)
        {
            List<string> list;
            if (type == 2)
                list = _englishList;
            else
                list = _chineseList;
            if (_multipleChoiceList[0] == list.ElementAt(_count) && _choiceOne == true)
                return true;
            else if (_multipleChoiceList[1] == list.ElementAt(_count) && _choiceTwo == true)
                return true;
            else if (_multipleChoiceList[2] == list.ElementAt(_count) && _choiceThree == true)
                return true;
            else if (_multipleChoiceList[3] == list.ElementAt(_count) && _choiceFour == true)
                return true;
            else
                return false;
        }

        //檢查隨機題型
        public string CheckExaminationRandom()
        {
            if (_randomQuestionTypeList.ElementAt(_count) == 1)
                return _check.CheckAnswer(_userFillAnswer, _englishList.ElementAt(_count));
            else if (_randomQuestionTypeList.ElementAt(_count) == 2)
                return _check.MultipleResult(CheckMultipleAnswer(2), _englishList.ElementAt(_count));
            else
                return _check.MultipleResult(CheckMultipleAnswer(3), _chineseList.ElementAt(_count));
        }

        //檢查全部多選題
        public string CheckExaminationMultiple()
        {
            if (_randomQuestionTypeList.ElementAt(_count) == 2)
                return _check.MultipleResult(CheckMultipleAnswer(2), _englishList.ElementAt(_count));
            else
                return _check.MultipleResult(CheckMultipleAnswer(3), _chineseList.ElementAt(_count));
        }

        //測驗結束
        public void FinishExamination(bool test)
        {
            const string PASS = "You pass ";
            const string OF = " of ";
            const string QUESTION = " question!!\n";
            const string SCORE = "Your score is:";
            if(_count == _questionAmount || test == true)
            {
                _timer.Stop();
                MessageBox.Show(PASS + _check.GetCorrect() + OF + _count + QUESTION + SCORE + _score);
                Application.Exit();
            }
        }

        //取得填空提的回答
        public void SetFillAnswer(string userAnswer)
        {
            _userFillAnswer = userAnswer;
        }

        //檢查選項1是否被選擇
        public void SetChoiceOne(bool choose)
        {
            _choiceOne = choose;
        }

        //檢查選項2是否被選擇
        public void SetChoiceTwo(bool choose)
        {
            _choiceTwo = choose;
        }

        //檢查選項3是否被選擇
        public void SetChoiceThree(bool choose)
        {
            _choiceThree = choose;
        }

        //檢查選項4是否被選擇
        public void SetChoiceFour(bool choose)
        {
            _choiceFour = choose;
        }

        //按下stop時更改總題數
        public void ChangeQuestionAmount()
        {
            if (_count >= 0)
                _questionAmount = _count;
        }

        //增加已答題數
        public void PlusCount()
        {
            if (_questionAmount != 0)
                _count++;
        }

        //設定屬性
        public void Click()
        {
            if (_count < _questionAmount && _count >= 0)
            {
                ChangeGroupBoxTextFill = "";
                ChangeGroupBoxTextMultiple = "";
                ChangeLabelMultipleChoice1 = "";
                ChangeLabelMultipleChoice2 = "";
                ChangeLabelMultipleChoice3 = "";
                ChangeLabelMultipleChoice4 = "";
                ChangeLabelFillQuestion = "";
                ChangeLabelMultipleQuestion = "";
            }
        }

        //property
        public event PropertyChangedEventHandler PropertyChanged;

        //按下Start之前先讀的東西
        public void ReadBeforeStart()
        {
            _readFile.Read();
            _separation.SeparateEnglishAndChinese(_readFile.GetAll());
            _blank.MakeBlank(_separation.GetAllEnglish());
        }

        //設定題目總數
        public void SetQuestionAmount(int amount, int examinationType)
        {
            _questionIndex.SetAmountOfQuestion(amount);
            _questionType.SetAmountOfQuestion(amount, examinationType);
            _questionAmount = amount;
            _examinationType = examinationType;
        }

        //初始化model
        public void InitializeModel()
        {
            _questionType.CreateRandomQuestionTypeList();
            _questionIndex.CreateQuestionIndex(_readFile.GetLineAmount());
            _questionText.SetIndex(_questionIndex.GetQuestionIndex());
            _separation.SetIndex(_questionIndex.GetQuestionIndex());
            _questionText.CreateFillBlankQuestionText(_blank.GetBlankEnglish(), _separation.GetAllChinese());
            _questionText.CreateChosenList(_separation.GetAllChinese(), _separation.GetAllEnglish());
        }

        //讀取所有字串list
        public void LoadAllStringList()
        {
            _randomQuestionTypeList = _questionType.GetTypeList();
            _chineseList = _questionText.GetChosenChineseList();
            _englishList = _questionText.GetChosenEnglishList();
            _blankEnglishList = _questionText.GetFillBlankQuestionTextList();
        }

        //回傳文字檔的總行數
        public int GetLineAmount()
        {
            return _readFile.GetLineAmount();
        }
    }
}
