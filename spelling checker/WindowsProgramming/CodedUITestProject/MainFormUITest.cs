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
        const string FILE_PATH = @"../../../Easy Calculator.exe";
        private const string CALCULATOR_TITLE = "MainForm";
        private const string EXPECTED_VALUE = "444";
        private const string RESULT_CONTROL_NAME = "Monitor";

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
            Robot.ClickButton("C");
            Robot.ClickButton("1");
            Robot.ClickButton("2");
            Robot.ClickButton("3");
            Robot.ClickButton("+");
            Robot.ClickButton("3");
            Robot.ClickButton("2");
            Robot.ClickButton("1");
            Robot.ClickButton("=");
        }

        /// <summary>
        /// Tests that the result of 123 + 321 should be 444
        /// </summary>
        [TestMethod]
        public void TestAdd()
        {
            RunScriptAdd();
            Robot.AssertText(RESULT_CONTROL_NAME, EXPECTED_VALUE);
        }

        [TestMethod]
        public void TestAbout()
        {
            Robot.ClickMenuItem(new string[] { "About", "Calculator" });
            Robot.AssertWindow("Caption");
            Robot.SendKeyEnterToMessageBox("Caption");
        }
    }
}