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
    public class BlankTests
    {
        Blank _blank = new Blank();
        const string ENGLISH_ONE = "apple";
        const string ENGLISH_TWO = "banana";
        const string ENGLISH_THREE = "a";
        const string ENGLISH_FOUR = "at";
        List<string> _english = new List<string>();
        //test
        [TestMethod()]
        public void MakeBlankTest()
        {
            _english.Add(ENGLISH_ONE);
            _english.Add(ENGLISH_TWO);
            _english.Add(ENGLISH_THREE);
            _english.Add(ENGLISH_FOUR);
            _blank.MakeBlank(_english);
            List<string> result = _blank.GetBlankEnglish();
            Assert.AreEqual("a___e", result.ElementAt(0));
            Assert.AreEqual("b____a", result.ElementAt(1));
            Assert.AreEqual("_", result.ElementAt(2));
            Assert.AreEqual("a_", result.ElementAt(3));
        }
    }
}