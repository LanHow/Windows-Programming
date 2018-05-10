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
    public class QuestionTextTests
    {
        QuestionText _questionText = new QuestionText();
        PrivateObject _indexTarget;
        List<int> _index = new List<int>();
        List<string> _blank = new List<string>();
        List<string> _chinese = new List<string>();
        List<string> _fill = new List<string>();
        List<string> _english = new List<string>();
        const string BLANK_ONE = "a___e";
        const string BLANK_TWO = "b____a";
        const string ENGLISH_ONE = "apple";
        const string ENGLISH_TWO = "banana";
        const string CHINESE_ONE = "蘋果";
        const string CHINESE_TWO = "香蕉";
        //test
        [TestMethod()]

        public void SetIndexTest()
        {
            _indexTarget = new PrivateObject(_questionText);
            _index.Add(0);
            _index.Add(1);
            _questionText.SetIndex(_index);
            Assert.AreEqual(_index, _indexTarget.GetFieldOrProperty("_index"));
        }

        //test
        [TestMethod()]

        public void CreateFillBlankQuestionTextTest()
        {
            _index.Add(0);
            _index.Add(1);
            _questionText.SetIndex(_index);
            _blank.Add(BLANK_ONE);
            _blank.Add(BLANK_TWO);
            _chinese.Add(CHINESE_ONE);
            _chinese.Add(CHINESE_TWO);
            _questionText.CreateFillBlankQuestionText(_blank, _chinese);
            _fill.Add(_chinese.ElementAt(0) + " " + _blank.ElementAt(0) + "(" + _blank.ElementAt(0).Length + ")");
            _fill.Add(_chinese.ElementAt(1) + " " + _blank.ElementAt(1) + "(" + _blank.ElementAt(1).Length + ")");
            List<string> result = _questionText.GetFillBlankQuestionTextList();
            Assert.AreEqual(_fill.ElementAt(0), result.ElementAt(0));
            Assert.AreEqual(_fill.ElementAt(1), result.ElementAt(1));
        }

        //test
        [TestMethod()]

        public void CreateChosenListTest()
        {
            _index.Add(0);
            _index.Add(1);
            _questionText.SetIndex(_index);
            _english.Add(ENGLISH_ONE);
            _english.Add(ENGLISH_TWO);
            _chinese.Add(CHINESE_ONE);
            _chinese.Add(CHINESE_TWO);
            _questionText.CreateChosenList(_chinese, _english);
            List<string> chinese = _questionText.GetChosenChineseList();
            List<string> english = _questionText.GetChosenEnglishList();
            Assert.AreEqual(_chinese.ElementAt(0), chinese.ElementAt(0));
            Assert.AreEqual(_chinese.ElementAt(1), chinese.ElementAt(1));
            Assert.AreEqual(_english.ElementAt(0), english.ElementAt(0));
            Assert.AreEqual(_english.ElementAt(1), english.ElementAt(1));
        }
    }
}