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
    public class CheckTests
    {
        Check _check = new Check();
        const string CORRECT = "Correct!!";
        const string FILLED_CORRECT = "apple";
        const string FILLED_WRONG = "aple";
        const string ANSWER = "apple";
        const string WRONG = "It should be apple!!";
        PrivateObject _target;
        //test
        [TestMethod()]
        public void CheckAnswerTest()
        {
            Assert.AreEqual(WRONG, _check.CheckAnswer(FILLED_WRONG, ANSWER));
            Assert.AreEqual(CORRECT, _check.CheckAnswer(FILLED_CORRECT, ANSWER));
        }

        //test
        [TestMethod()]

        public void MultipleResultTest()
        {
            Assert.AreEqual(CORRECT, _check.MultipleResult(true, ANSWER));
            Assert.AreEqual(WRONG, _check.MultipleResult(false, ANSWER));
        }

        //test
        [TestMethod()]

        public void GetCorrectTest()
        {
            Assert.AreEqual(WRONG, _check.CheckAnswer(FILLED_WRONG, ANSWER));
            Assert.AreEqual(CORRECT, _check.CheckAnswer(FILLED_CORRECT, ANSWER));
            _target = new PrivateObject(_check);
            int correct = _check.GetCorrect();
            Assert.AreEqual(correct, _target.GetFieldOrProperty("_correct"));
        }
    }
}