using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class QuestionType
    {
        private Random _randomNumber = new Random();
        private int _amountOfQuestion;
        private int _examinationType;
        private List<int> _typeList = new List<int>();
        //create隨機題型與多選題的題型list
        public void CreateRandomQuestionTypeList()
        {
            if (_examinationType == 0)
                for (int i = 0; i < _amountOfQuestion; i++)
                    _typeList.Add(_randomNumber.Next(1, 4));
            else
                for (int i = 0; i < _amountOfQuestion; i++)
                    _typeList.Add(_randomNumber.Next(2, 4));
        }

        //設定題目總數和測驗模式
        public void SetAmountOfQuestion(int amount, int examinationType)
        {
            _amountOfQuestion = amount;
            _examinationType = examinationType;
        }

        //回傳題型list
        public List<int> GetTypeList()
        {
            return _typeList;
        }
    }
}
