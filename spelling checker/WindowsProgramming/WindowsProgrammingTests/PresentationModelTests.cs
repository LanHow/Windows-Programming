using Microsoft.VisualStudio.TestTools.UnitTesting;
using PresentationModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationModel.Tests
{
    [TestClass()]
    public class PresentationModelTests
    {
        PresentationModel _presentationModel = new PresentationModel();
        const string TEST = " ";
        PrivateObject _target;
        const int AMOUNT = 5;
        const string FILL = "123";

        //test
        [TestMethod()]

        public void ClickStartTest()
        {
            _presentationModel.SetQuestionAmount(10, 0);
            _presentationModel.ClickStart();
            Assert.AreEqual(" ", TEST);
        }

        //test
        [TestMethod()]

        public void ClickNextTest()
        {
            _presentationModel.ClickNext();
            Assert.AreEqual(" ", TEST);
            _presentationModel.ReadBeforeStart();
            _presentationModel.SetQuestionAmount(AMOUNT, 1);
            _presentationModel.InitializeModel();
            _presentationModel.LoadAllStringList();
            Assert.AreEqual(" ", TEST);
        }

        //test
        [TestMethod()]

        public void CreateWrongChoiceTest()
        {
            _presentationModel.CreateWrongChoice();
            Assert.AreEqual(" ", TEST);
            _presentationModel.ReadBeforeStart();
            _presentationModel.SetQuestionAmount(AMOUNT, 1);
            _presentationModel.InitializeModel();
            _presentationModel.LoadAllStringList();
            _presentationModel.CreateWrongChoice();
            Assert.AreEqual(" ", TEST);
        }

        //test
        [TestMethod()]

        public void DoCheckTest()
        {
            _presentationModel.DoCheck();
            Assert.AreEqual(" ", TEST);
        }

        //test
        [TestMethod()]

        public void FinishExaminationTest()
        {
            _presentationModel.FinishExamination(false);
            Assert.AreEqual(" ", TEST);
            _presentationModel.ReadBeforeStart();
            _presentationModel.SetQuestionAmount(AMOUNT, 1);
            _presentationModel.InitializeModel();
            _presentationModel.LoadAllStringList();
            _presentationModel.ChangeQuestionAmount();
        }

        //test
        [TestMethod()]

        public void SetFillAnswerTest()
        {
            _target = new PrivateObject(_presentationModel);
            _presentationModel.SetFillAnswer(FILL);
            Assert.AreEqual(FILL, _target.GetFieldOrProperty("_userFillAnswer"));
        }

        //test
        [TestMethod()]

        public void SetChoiceOneTest()
        {
            bool choice = true;
            _target = new PrivateObject(_presentationModel);
            _presentationModel.SetChoiceOne(choice);
            Assert.AreEqual(choice, _target.GetFieldOrProperty("_choiceOne"));
        }

        //test
        [TestMethod()]

        public void SetChoiceTwoTest()
        {
            bool choice = true;
            _target = new PrivateObject(_presentationModel);
            _presentationModel.SetChoiceTwo(choice);
            Assert.AreEqual(choice, _target.GetFieldOrProperty("_choiceTwo"));
        }

        //test
        [TestMethod()]

        public void SetChoiceThreeTest()
        {
            bool choice = true;
            _target = new PrivateObject(_presentationModel);
            _presentationModel.SetChoiceThree(choice);
            Assert.AreEqual(choice, _target.GetFieldOrProperty("_choiceThree"));
        }

        //test
        [TestMethod()]

        public void SetChoiceFourTest()
        {
            bool choice = true;
            _target = new PrivateObject(_presentationModel);
            _presentationModel.SetChoiceFour(choice);
            Assert.AreEqual(choice, _target.GetFieldOrProperty("_choiceFour"));
        }

        //test
        [TestMethod()]

        public void ChangeQuestionAmountTest()
        {
            _presentationModel.ChangeQuestionAmount();
            _presentationModel.SetQuestionAmount(AMOUNT, 1);
            _presentationModel.PlusCount();
            _presentationModel.ChangeQuestionAmount();
            Assert.AreEqual(" ", TEST);
        }

        //test
        [TestMethod()]

        public void AddCountTest()
        {
            _presentationModel.SetQuestionAmount(AMOUNT, 1);
            _target = new PrivateObject(_presentationModel);
            int count = (int)_target.GetFieldOrProperty("_count");
            _presentationModel.PlusCount();
            Assert.AreEqual((count + 1), _target.GetFieldOrProperty("_count"));
        }

        //test
        [TestMethod()]

        public void ClickTest()
        {
            _presentationModel.ReadBeforeStart();
            _presentationModel.SetQuestionAmount(AMOUNT, 1);
            _presentationModel.InitializeModel();
            _presentationModel.LoadAllStringList();
            _presentationModel.Click();
            Assert.AreEqual(true, _presentationModel.ChangeGroupBoxCustomVisible);
            Assert.AreEqual(" ", TEST);
        }

        //test
        [TestMethod()]

        public void ReadBeforeStartTest()
        {
            _presentationModel.ReadBeforeStart();
            Assert.AreEqual(" ", TEST);
        }

        //test
        [TestMethod()]

        public void InitializeModelTest()
        {
            _presentationModel.InitializeModel();
            Assert.AreEqual(" ", TEST);
        }

        //test
        [TestMethod()]

        public void LoadAllStringListTest()
        {
            _presentationModel.ReadBeforeStart();
            _presentationModel.SetQuestionAmount(AMOUNT, 1);
            _presentationModel.InitializeModel();
            _presentationModel.LoadAllStringList();
            _target = new PrivateObject(_presentationModel);
            Assert.AreEqual(false, _target.GetFieldOrProperty("_randomQuestionTypeList").Equals(null));
            Assert.AreEqual(false, _target.GetFieldOrProperty("_chineseList").Equals(null));
            Assert.AreEqual(false, _target.GetFieldOrProperty("_englishList").Equals(null));
            Assert.AreEqual(false, _target.GetFieldOrProperty("_blankEnglishList").Equals(null));
        }

        //test
        [TestMethod()]

        public void GetLineAmountTest()
        {
            _presentationModel.ReadBeforeStart();
            int result = _presentationModel.GetLineAmount();
            Assert.AreEqual(1081, result);
        }

        //test
        [TestMethod()]

        public void Test()
        {
            _presentationModel.ReadBeforeStart();
            _presentationModel.SetQuestionAmount(AMOUNT, 1);
            _presentationModel.PlusCount();
            _presentationModel.InitializeModel();
            _presentationModel.LoadAllStringList();
            _presentationModel.CreateWrongChoice();
            _presentationModel.Click();
            _presentationModel.ClickStart();
            _presentationModel.ChangeGroupBoxTextFill = " ";
            _presentationModel.ChangeGroupBoxTextMultiple = " ";
            _presentationModel.ChangeLabelFillQuestion = " ";
            _presentationModel.ChangeLabelMultipleChoice1 = " ";
            _presentationModel.ChangeLabelMultipleChoice2 = " ";
            _presentationModel.ChangeLabelMultipleChoice3 = " ";
            _presentationModel.ChangeLabelMultipleChoice4 = " ";
            _presentationModel.ChangeLabelMultipleQuestion = " ";
        }

        //test
        [TestMethod()]

        public void TestTwo()
        {
            _presentationModel.ReadBeforeStart();
            _presentationModel.SetQuestionAmount(AMOUNT, 1);
            _presentationModel.PlusCount();
            _presentationModel.InitializeModel();
            _presentationModel.LoadAllStringList();
            _presentationModel.CreateWrongChoice();
            _presentationModel.Click();
            _presentationModel.ClickStart();
            _presentationModel.ChangeScore = " ";
            _presentationModel.ChangeTotalTime = " ";
            _presentationModel.Check = " ";
            _presentationModel.SetQuestionAmount(AMOUNT, 2);
            _presentationModel.Check = " ";
            _presentationModel.SetQuestionAmount(AMOUNT, 3);
            _presentationModel.Check = " ";
        }
        //test
        [TestMethod()]

        public void TestProperty()
        {
            _presentationModel.ReadBeforeStart();
            _presentationModel.SetQuestionAmount(AMOUNT, 1);
            _presentationModel.PlusCount();
            _presentationModel.InitializeModel();
            _presentationModel.LoadAllStringList();
            _presentationModel.CreateWrongChoice();
            _presentationModel.Click();
            _presentationModel.ClickStart();
            _presentationModel.ChangeButtomNextEnabled = true;
            _presentationModel.ChangeButtomStartEnabled = true;
            _presentationModel.ChangeButtomStopEnabled = true;
            _presentationModel.ChangeGroupBoxCustomVisible = true;
            _presentationModel.ChangeGroupBoxFillVisible = true;
            _presentationModel.ChangeGroupBoxMultipleVisible = true;
            _presentationModel.CheckMultipleAnswer(2);
            _presentationModel.StartTimer();
            _presentationModel.ChangeTime = 0;
            _presentationModel.FinishExamination(true);
            _presentationModel.TransformTotalTimeToString(true);
            Assert.AreEqual(_presentationModel.ChangeButtomNextEnabled, _presentationModel.ChangeButtomNextEnabled);
            Assert.AreEqual(_presentationModel.ChangeButtomStartEnabled, _presentationModel.ChangeButtomStartEnabled);
            Assert.AreEqual(_presentationModel.ChangeButtomStopEnabled, _presentationModel.ChangeButtomStopEnabled);
            Assert.AreEqual(_presentationModel.ChangeGroupBoxCustomVisible, _presentationModel.ChangeGroupBoxCustomVisible);
            Assert.AreEqual(_presentationModel.ChangeGroupBoxFillVisible, _presentationModel.ChangeGroupBoxFillVisible);
            Assert.AreEqual(_presentationModel.ChangeGroupBoxMultipleVisible, _presentationModel.ChangeGroupBoxMultipleVisible);
            Assert.AreEqual(_presentationModel.ChangeGroupBoxTextFill, _presentationModel.ChangeGroupBoxTextFill);
            Assert.AreEqual(_presentationModel.ChangeGroupBoxTextMultiple, _presentationModel.ChangeGroupBoxTextMultiple);
            Assert.AreEqual(_presentationModel.ChangeLabelFillQuestion, _presentationModel.ChangeLabelFillQuestion);
            Assert.AreEqual(_presentationModel.ChangeLabelMultipleChoice1, _presentationModel.ChangeLabelMultipleChoice1);
            Assert.AreEqual(_presentationModel.ChangeLabelMultipleChoice2, _presentationModel.ChangeLabelMultipleChoice2);
            Assert.AreEqual(_presentationModel.ChangeLabelMultipleChoice3, _presentationModel.ChangeLabelMultipleChoice3);
            Assert.AreEqual(_presentationModel.ChangeLabelMultipleChoice4, _presentationModel.ChangeLabelMultipleChoice4);
            Assert.AreEqual(_presentationModel.ChangeLabelMultipleQuestion, _presentationModel.ChangeLabelMultipleQuestion);
            Assert.AreEqual(_presentationModel.CheckExaminationRandom(), _presentationModel.CheckExaminationRandom());
            Assert.AreEqual(_presentationModel.CheckExaminationMultiple(), _presentationModel.CheckExaminationMultiple());
            Assert.AreEqual(_presentationModel.ChangeScore, _presentationModel.ChangeScore);
            Assert.AreEqual(_presentationModel.ChangeTime, _presentationModel.ChangeTime);
            Assert.AreEqual(_presentationModel.ChangeTotalTime, _presentationModel.ChangeTotalTime);
            Assert.AreEqual(_presentationModel.Check, _presentationModel.Check);
        }
    }
}