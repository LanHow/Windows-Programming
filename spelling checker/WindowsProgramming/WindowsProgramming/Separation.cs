using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Separation
    {
        private Random _randomNumber = new Random();
        private List<string> _allEnglish = new List<string>();
        private List<string> _allChinese = new List<string>();
        private List<string> _list = new List<string>();
        private List<int> _index = new List<int>();
        //將中文與英文分開
        public void SeparateEnglishAndChinese(List<string> list)
        {
            _list = list;
            char[] array = new char[] { ' ', '>' };
            for (int i = 0; i < _list.Count ; i++)
            {
                string[] separate = _list.ElementAt(i).Split(array, StringSplitOptions.RemoveEmptyEntries);
                _allChinese.Add(separate[1]);
                _allEnglish.Add(separate[0]);
            }
        }

        //回傳包含錯誤選項的字串List
        public List<string> GetWrongChoice(int type)
        {
            const int CHOICE_AMOUNT = 3;
            int[] number = new int[CHOICE_AMOUNT];
            List<string> wrongChoice = new List<string>();
            while (wrongChoice.Count() < CHOICE_AMOUNT)
            {
                int num = _randomNumber.Next(1, _list.Count);
                if (_index.Contains(num) == false)
                {
                    if (type == 3)
                        wrongChoice.Add(_allChinese[num]);
                    else
                        wrongChoice.Add(_allEnglish[num]);
                }
            }
            return wrongChoice;
        }

        //回傳所有英文的list
        public List<string> GetAllEnglish()
        {
            return _allEnglish;
        }

        //回傳所有中文的list
        public List<string> GetAllChinese()
        {
            return _allChinese;
        }

        //設定INDEX
        public void SetIndex(List<int> index)
        {
            _index = index;
        }
    }
}
