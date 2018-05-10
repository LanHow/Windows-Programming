using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class QuestionText
    {
        private List<int> _index = new List<int>();
        private List<string> _chosenFillQuestionTextList = new List<string>();
        private List<string> _chosenChineseList = new List<string>();
        private List<string> _chosenEnglishList = new List<string>();

        //設定所選題目行數的list
        public void SetIndex(List<int> index)
        {
            _index = index;
        }
        
        //create填空題題目
        public void CreateFillBlankQuestionText(List<string> blankEnglish, List<string> chinese)
        {
            for (int i = 0; i < _index.Count; i++)
            {
                int num = _index.ElementAt(i);
                _chosenFillQuestionTextList.Add(chinese.ElementAt(num) + " " + blankEnglish.ElementAt(num) + "(" + blankEnglish.ElementAt(num).Length + ")");
            }
        }

        //create所選的多選題題目
        public void CreateChosenList(List<string> chinese, List<string> english)
        {
            for (int i = 0; i < _index.Count; i++)
                _chosenChineseList.Add(chinese.ElementAt(_index.ElementAt(i)));
            for (int i = 0; i < _index.Count; i++)
                _chosenEnglishList.Add(english.ElementAt(_index.ElementAt(i)));
        }

        //回傳填空題題目
        public List<string> GetFillBlankQuestionTextList()
        {
            return _chosenFillQuestionTextList;
        }

        //回傳多選題中文list
        public List<string> GetChosenChineseList()
        {
            return _chosenChineseList;
        }

        //回傳多選題英文list
        public List<string> GetChosenEnglishList()
        {
            return _chosenEnglishList;
        }
    }
}
