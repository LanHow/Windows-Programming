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
    public class QuestionTypeTests
    {
        QuestionType _questionType = new QuestionType();
        const int QUESTION_AMOUNT = 10;
        const int EXAMINATION_TYPE_ONE = 0;
        const int EXAMINATION_TYPE_TWO = 1;
        PrivateObject _amountTarget;
        PrivateObject _examinationTypeTarget;
        PrivateObject _typeListTarget;

        //test
        [TestMethod()]

        public void CreateRandomQuestionTypeListTest()
        {
            _questionType.SetAmountOfQuestion(QUESTION_AMOUNT, EXAMINATION_TYPE_ONE);
            _questionType.CreateRandomQuestionTypeList();
            _typeListTarget = new PrivateObject(_questionType);
            List<int> nullList = new List<int>();
            Assert.AreEqual(false, _typeListTarget.GetFieldOrProperty("_typeList").Equals(nullList));
            Assert.AreEqual(false, ((List<int>)_typeListTarget.GetFieldOrProperty("_typeList")).Contains(4));
            Assert.AreEqual(10, (((List<int>)_typeListTarget.GetFieldOrProperty("_typeList")).Count()));
            QuestionType questionTypeTwo = new QuestionType();
            questionTypeTwo.SetAmountOfQuestion(QUESTION_AMOUNT, EXAMINATION_TYPE_TWO);
            questionTypeTwo.CreateRandomQuestionTypeList();
            _typeListTarget = new PrivateObject(questionTypeTwo);
            Assert.AreEqual(false, ((List<int>)_typeListTarget.GetFieldOrProperty("_typeList")).Contains(1));
        }

        //test
        [TestMethod()]

        public void SetAmountOfQuestionTest()
        {
            _questionType.SetAmountOfQuestion(QUESTION_AMOUNT, EXAMINATION_TYPE_ONE);
            _amountTarget = new PrivateObject(_questionType);
            _examinationTypeTarget = new PrivateObject(_questionType);
            Assert.AreEqual(QUESTION_AMOUNT, _amountTarget.GetFieldOrProperty("_amountOfQuestion"));
            Assert.AreEqual(EXAMINATION_TYPE_ONE, _examinationTypeTarget.GetFieldOrProperty("_examinationType"));
        }

        //test
        [TestMethod()]

        public void GetTypeListTest()
        {
            _questionType.SetAmountOfQuestion(QUESTION_AMOUNT, EXAMINATION_TYPE_ONE);
            _questionType.CreateRandomQuestionTypeList();
            _typeListTarget = new PrivateObject(_questionType);
            List<int> list = _questionType.GetTypeList();
            Assert.AreEqual(list, _typeListTarget.GetFieldOrProperty("_typeList"));
        }
    }
}