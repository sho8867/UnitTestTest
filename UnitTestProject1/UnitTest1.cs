using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var date = TestTarget.DateTimeUtils.StrToDate("2000/01/01", "25:00");

            Assert.IsTrue(date == new DateTime(2000, 1, 2, 1, 0, 0));
        }
    }
}
