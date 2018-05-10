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
    public class QuestionIndexTests
    {
        QuestionIndex _questionIndex = new QuestionIndex();
        const int AMOUNT = 10;
        PrivateObject _target;

        //test
        [TestMethod()]

        public void SetAmountOfQuestionTest()
        {
            _questionIndex.SetAmountOfQuestion(AMOUNT);
            _target = new PrivateObject(_questionIndex);
            Assert.AreEqual(AMOUNT, _target.GetFieldOrProperty("_amountOfQuestion"));
        }

        //test
        [TestMethod()]

        public void CreateQuestionIndexTest()
        {
            _questionIndex.SetAmountOfQuestion(5);
            _questionIndex.CreateQuestionIndex(AMOUNT);
            List<int> result = _questionIndex.GetQuestionIndex();
            Assert.AreEqual(5, result.Count);
            Assert.AreEqual(false, result.Contains(11));
        }
    }
}