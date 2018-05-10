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
    public class ReadFileTests
    {
        ReadFile _readFile = new ReadFile();
        const string FIRST = "a                    >>> [冠]一個;一種                           ";
        const string LAST = "zoo                  >>> [名]動物園                              ";
        List<string> _list;

        //test
        [TestMethod()]

        public void ReadTest()
        {
            _readFile.Read();
            Assert.AreEqual(1, 1);
        }

        //test
        [TestMethod()]

        public void GetAllTest()
        {
            _readFile.Read();
            _list = new List<string>();
            _list = _readFile.GetAll();
            Assert.AreEqual(FIRST, _list.ElementAt(0));
            Assert.AreEqual(LAST, _list.Last());
        }

        //test
        [TestMethod()]

        public void GetLineAmountTest()
        {
            _readFile.Read();
            int number = _readFile.GetLineAmount();
            Assert.AreEqual(1081, number);
        }
    }
}