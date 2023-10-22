using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.HubulovaVI.Sprint3.Task3.V20.Lib;

namespace Tyuiu.HubulovaVI.Sprint3.Task3.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCharCount()
        {
            DataService ds = new DataService();

            string str = "abcde abc abcdefg abcd ab";
            char chr = 'b';

            int res = ds.GetCharCount(str, chr);

            Assert.AreEqual(5, res);
        }
    }
}