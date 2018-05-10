using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Blank
    {
        List<string> _blankEnglish = new List<string>();
        string _transform;

        //將英文挖空
        public void MakeBlank(List<string> english)
        {
            for (int i = 0; i < english.Count; ++i)
            {
                if (english.ElementAt(i).Length >= 3)
                    _transform = english.ElementAt(i).Remove(1, english.ElementAt(i).Length - 2);
                else if (english.ElementAt(i).Length == 2)
                {
                    _transform = english.ElementAt(i).Remove(1, 1);
                    _transform = _transform.Insert(1, "_");
                }
                else
                    _transform = "_";
                for (int j = 0; j < english.ElementAt(i).Length - 2; j++)
                    _transform = _transform.Insert(1, "_");
                _blankEnglish.Add(_transform);
            }
        }

        //回傳挖空的英文list
        public List<string> GetBlankEnglish()
        {
            return _blankEnglish;
        }
    }
}
