namespace IntegerDateTime.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ReadMeTests
    {
        [TestMethod]
        public void IntegerDateReadmeTest()
        {
            // Find date components
            IntegerDate fromString = new IntegerDate("20180710");
            Assert.AreEqual(2018, fromString.Year);
            Assert.AreEqual(7, fromString.Month);
            Assert.AreEqual(10, fromString.Day);

            IntegerDate fromInt = new IntegerDate(20180609);
            Assert.AreEqual(2018, fromInt.Year);
            Assert.AreEqual(6, fromInt.Month);
            Assert.AreEqual(9, fromInt.Day);

            // Convert
            Assert.AreEqual(20180710, fromString.ToInt);
            Assert.AreEqual("20180609", fromInt.ToString());

            Assert.AreEqual(2018, fromInt.ToDateTime.Year);
            Assert.AreEqual(6, fromInt.ToDateTime.Month);
            Assert.AreEqual(9, fromInt.ToDateTime.Day);

            IntegerDate fromDateTime = new IntegerDate(new DateTime(2018, 07, 10));
            Assert.AreEqual(2018, fromDateTime.Year);
            Assert.AreEqual(7, fromDateTime.Month);
            Assert.AreEqual(10, fromDateTime.Day);
            Assert.AreEqual(20180710, fromDateTime.ToInt);
            Assert.AreEqual("20180710", fromDateTime.ToString());
        }

        [TestMethod]
        public void IntegerTimeReadmeTest()
        {
            // Find date components
            IntegerTime fromString = new IntegerTime("010203");
            Assert.AreEqual(1, fromString.Hour);
            Assert.AreEqual(2, fromString.Minute);
            Assert.AreEqual(3, fromString.Second);

            IntegerTime fromInt = new IntegerTime(101112);
            Assert.AreEqual(10, fromInt.Hour);
            Assert.AreEqual(11, fromInt.Minute);
            Assert.AreEqual(12, fromInt.Second);

            // Convert
            Assert.AreEqual(10203, fromString.ToInt);
            Assert.AreEqual("101112", fromInt.ToString());

            Assert.AreEqual(10, fromInt.ToTimeSpan.Hours);
            Assert.AreEqual(11, fromInt.ToTimeSpan.Minutes);
            Assert.AreEqual(12, fromInt.ToTimeSpan.Seconds);
        }
    }
}
