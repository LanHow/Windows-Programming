using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Check
    {
        int _correct;
        const string STRING_SHOULD_BE = "It should be ";
        const string STRING_SYMBOL = "!!";
        const string CORRECT = "Correct!!";

        //檢查填空題是否答對並回傳結果
        public string CheckAnswer(string filled, string answer)
        {
            if (answer == filled)
            {
                _correct++;
                return CORRECT;
            }
            else
                return STRING_SHOULD_BE + answer + STRING_SYMBOL;
        }

        //回傳多選題是否答對
        public string MultipleResult(bool right, string answer)
        {
            if (right == true)
            {
                _correct++;
                return CORRECT;
            }
            else
                return STRING_SHOULD_BE + answer + STRING_SYMBOL;
        }

        //回傳答對題數
        public int GetCorrect()
        {
            return _correct;
        }
    }
}