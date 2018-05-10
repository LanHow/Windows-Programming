using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class QuestionIndex
    {
        private Random _randomNumber = new Random();
        private int _amountOfQuestion;
        private List<int> _questionIndex = new List<int>();

        //設定題目總數
        public void SetAmountOfQuestion(int amount)
        {
            _amountOfQuestion = amount;
        }

        //create選出的題目行數
        public void CreateQuestionIndex(int lineAmount)
        {
            while (_questionIndex.Count < _amountOfQuestion)
            {
                int num = _randomNumber.Next(1, lineAmount);
                if (!_questionIndex.Contains(num))
                    _questionIndex.Add(num);
            }
        }

        //回傳選定的題目行數
        public List<int> GetQuestionIndex()
        {
            return _questionIndex;
        }
    }
}
