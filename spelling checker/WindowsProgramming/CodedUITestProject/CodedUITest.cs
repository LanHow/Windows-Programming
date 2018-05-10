using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;

namespace CodedUITestProject
{
    /// <summary>
    /// Summary description for MainFormUITest
    /// </summary>
    [CodedUITest]
    public class MainFormUITest
    {
        const string FILE_PATH = @"..\..\..\..\WindowsProgramming\WindowsProgramming\bin\Debug\WindowsProgramming.exe";
        private const string CALCULATOR_TITLE = "基本能力測驗英文1000字";

        /// <summary>
        /// Launches the Calculator
        /// </summary>
        [TestInitialize()]
        public void Initialize()
        {
            Robot.Initialize(FILE_PATH, CALCULATOR_TITLE);
        }

        /// <summary>
        /// Closes the launched program
        /// </summary>
        [TestCleanup()]
        public void Cleanup()
        {
            Robot.CleanUp();
        }

        /// <summary>
        /// Runs the script: 123 + 321 =
        /// </summary>
        private void RunScriptAdd()
        {
            Robot.ClickButton("Start");
            Robot.ClickButton("Next");
            Robot.ClickButton("Stop");
        }

        /// <summary>
        /// Tests that the result of 123 + 321 should be 444
        /// </summary>
        [TestMethod]
        public void TestAdd()
        {
            RunScriptAdd();
        }

        [TestMethod]
        public void TestAbout()
        {
            Robot.ClickMenuItem(new string[] { "Examination", "Number of Questions", "50 Questions" });
            Robot.ClickMenuItem(new string[] { "Examination", "Number of Questions", "20 Questions" });
            Robot.ClickMenuItem(new string[] { "Examination", "Number of Questions", "10 Questions" });
            Robot.ClickMenuItem(new string[] { "Examination", "Question Type", "All fill-in-blank questions" });
            Robot.ClickMenuItem(new string[] { "Examination", "Question Type", "All multiple-choice questions" });
            Robot.ClickMenuItem(new string[] { "Examination", "Question Type", "Pick up questions randomly" });
            Robot.ClickMenuItem(new string[] { "Help", "About Spelling Checker" });
            Robot.ClickMenuItem(new string[] { "Help", "About Dictionary" });
        }

        [TestMethod]
        public void TestExit()
        {
            Robot.ClickMenuItem(new string[] { "File", "Exit" });
        }
    }
}