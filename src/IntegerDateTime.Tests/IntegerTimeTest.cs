namespace IntegerDateTime.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class IntegerTimeTest
    {
        [TestMethod]
        public void SQLCtor_GivesCorrectHour_ShortHour()
        {
            //Arrange
            string input = "85023";
            int expected = 8;
            IntegerTime testObj;

            //Act
            testObj = new IntegerTime(input);

            //Assert
            Assert.AreEqual(expected, testObj.Hour);
        }

        [TestMethod]
        public void SQLCtor_GivesCorrectHour_LongHour()
        {
            //Arrange
            string input = "115023";
            int expected = 11;
            IntegerTime testObj;

            //Act
            testObj = new IntegerTime(input);

            //Assert
            Assert.AreEqual(expected, testObj.Hour);
        }

        [TestMethod]
        public void SQLCtor_GivesCorrectMinute()
        {
            //Arrange
            string input = "85023";
            int expected = 50;

            IntegerTime testObj;

            //Act
            testObj = new IntegerTime(input);

            //Assert
            Assert.AreEqual(expected, testObj.Minute);
        }

        [TestMethod]
        public void SQLCtor_GivesCorrectSecond()
        {
            //Arrange
            string input = "85023";
            int expected = 23;

            IntegerTime testObj;

            //Act
            testObj = new IntegerTime(input);

            //Assert
            Assert.AreEqual(expected, testObj.Second);
        }

        [TestMethod]
        public void DateTimeCtor_GivesCorrectHour()
        {
            //Arrange
            DateTime input = new DateTime(2018, 5, 16, 14, 26, 1);
            int expected = 14;
            IntegerTime testObj;

            //Act
            testObj = new IntegerTime(input);

            //Assert
            Assert.AreEqual(expected, testObj.Hour);
        }

        [TestMethod]
        public void DateTimeCtor_GivesCorrectMinute()
        {
            //Arrange
            DateTime input = new DateTime(2018, 5, 16, 14, 26, 1);
            int expected = 26;

            IntegerTime testObj;

            //Act
            testObj = new IntegerTime(input);

            //Assert
            Assert.AreEqual(expected, testObj.Minute);
        }

        [TestMethod]
        public void DateTimeCtor_GivesCorrectSecond()
        {
            //Arrange
            DateTime input = new DateTime(2018, 5, 16, 14, 26, 1);
            int expected = 1;

            IntegerTime testObj;

            //Act
            testObj = new IntegerTime(input);

            //Assert
            Assert.AreEqual(expected, testObj.Second);
        }

        [TestMethod]
        public void IntCtor_GivesCorrectHourMinuteSecond()
        {
            //Arrange
            int expectedHour = 10;
            int expectedMinute = 11;
            int expectedSecond = 12;
            int input = (expectedHour * 10000) + (expectedMinute * 100) + expectedSecond;
            IntegerTime testObj;

            //Act
            testObj = new IntegerTime(input);

            //Assert
            Assert.AreEqual(expectedHour, testObj.Hour);
            Assert.AreEqual(expectedMinute, testObj.Minute);
            Assert.AreEqual(expectedSecond, testObj.Second);
        }

        [TestMethod]
        public void SQLCtor_ZeroInputWorks()
        {
            //Arrange
            string input = "0";

            IntegerTime testObj;

            //Act
            testObj = new IntegerTime(input);

            //Assert
            Assert.AreEqual(0, testObj.Hour);
            Assert.AreEqual(0, testObj.Minute);
            Assert.AreEqual(0, testObj.Second);
        }

        [TestMethod]
        public void ToTimeSpan()
        {
            //Arrange
            string input = "85023";
            TimeSpan expected = new TimeSpan(08, 50, 23);
            IntegerTime testObj;

            //Act
            testObj = new IntegerTime(input);

            //Assert
            Assert.AreEqual(expected, testObj.ToTimeSpan);
        }

        [TestMethod]
        public void ToInt32_Correct()
        {
            //Arrange
            string input = "82536";
            int expected = 82536;
            IntegerTime testObj;

            //Act
            testObj = new IntegerTime(input);

            //Assert
            Assert.AreEqual(expected, testObj.ToInt);
        }

        [TestMethod]
        public void ToString_Correct()
        {
            //Arrange
            string input = "82536";
            string expected = "82536";
            IntegerTime testObj;

            //Act
            testObj = new IntegerTime(input);

            //Assert
            Assert.AreEqual(expected, testObj.ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void NonNumericThrows()
        {
            //Arrange
            string input = "aaa";
            IntegerTime testObj;

            //Act
            testObj = new IntegerTime(input);

            //Assert
            //Throws
        }
    }
}
