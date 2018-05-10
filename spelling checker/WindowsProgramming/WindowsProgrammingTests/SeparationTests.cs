using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Tests
{
    [TestClass()]
    public class SeparationTests
    {
        Separation _separation = new Separation();
        List<string> _inputList = new List<string>();
        List<string> _wrongChoice = new List<string>();
        List<int> _index = new List<int>();
        const string FIRST = "a                    >>> [冠]一個;一種                           ";
        const string LAST = "zoo                  >>> [名]動物園                              ";
        const string ENGLISH_FIRST = "a";
        const string ENGLISH_LAST = "zoo";
        const string CHINESE_FIRST = "[冠]一個;一種";
        const string CHINESE_LAST = "[名]動物園";
        PrivateObject _chineseListTarget;
        PrivateObject _englishListTarget;
        PrivateObject _indexTarget;

        //test
        [TestMethod()]

        public void SeparateEnglishAndChineseTest()
        {
            _chineseListTarget = new PrivateObject(_separation);
            _englishListTarget = new PrivateObject(_separation);
            _inputList.Add(FIRST);
            _inputList.Add(LAST);
            _separation.SeparateEnglishAndChinese(_inputList);
            Assert.AreEqual(false, (_chineseListTarget.GetFieldOrProperty("_allChinese").Equals(null)));
            Assert.AreEqual(false, (_englishListTarget.GetFieldOrProperty("_allEnglish").Equals(null)));
        }

        //test
        [TestMethod()]

        public void GetWrongChoiceTest()
        {
            _indexTarget = new PrivateObject(_separation);
            _index.Add(0);
            _separation.SetIndex(_index);
            _inputList.Add(FIRST);
            _inputList.Add(LAST);
            _separation.SeparateEnglishAndChinese(_inputList);
            _wrongChoice = _separation.GetWrongChoice(3);
            Assert.AreEqual(false, _wrongChoice.Equals(null));
            _wrongChoice = _separation.GetWrongChoice(2);
            Assert.AreEqual(false, _wrongChoice.Equals(null));
        }

        //test
        [TestMethod()]

        public void GetAllEnglishTest()
        {
            _inputList.Add(FIRST);
            _inputList.Add(LAST);
            _separation.SeparateEnglishAndChinese(_inputList);
            List<string> allEnglish = _separation.GetAllEnglish();
            Assert.AreEqual(ENGLISH_FIRST, allEnglish.ElementAt(0));
            Assert.AreEqual(ENGLISH_LAST, allEnglish.Last());
        }

        //test
        [TestMethod()]

        public void GetAllChineseTest()
        {
            _inputList.Add(FIRST);
            _inputList.Add(LAST);
            _separation.SeparateEnglishAndChinese(_inputList);
            List<string> allChinese = _separation.GetAllChinese();
            Assert.AreEqual(CHINESE_FIRST, allChinese.ElementAt(0));
            Assert.AreEqual(CHINESE_LAST, allChinese.Last());
        }

        //test
        [TestMethod()]

        public void SetIndexTest()
        {
            _indexTarget = new PrivateObject(_separation);
            _index.Add(0);
            _separation.SetIndex(_index);
            Assert.AreEqual(true, _indexTarget.GetFieldOrProperty("_index").Equals(_index));
        }
    }
}