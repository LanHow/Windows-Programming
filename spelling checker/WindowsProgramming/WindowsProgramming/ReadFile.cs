using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Model
{
    public class ReadFile
    {
        private const string EMPTY_LINE = " ";
        private List<string> _problem = new List<string>();

        //讀取txt檔
        public void Read()
        {
            StreamReader file = new StreamReader(@"..\..\..\question.txt", Encoding.Default);
            while (!file.EndOfStream)
            {
                string line = file.ReadLine();// Ignore the line, if it is empty
                if (line.Equals(EMPTY_LINE))
                    continue;// Use string operations to parse the line
                _problem.Add(line);
            }
        }

        //回傳所有文字
        public List<string> GetAll()
        {
            return _problem;
        }

        //回傳總行數
        public int GetLineAmount()
        {
            return _problem.Count;
        }
    }
}