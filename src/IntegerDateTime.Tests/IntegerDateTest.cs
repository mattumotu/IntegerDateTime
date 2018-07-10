namespace IntegerDateTime.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class IntegerDateTest
    {
        [TestMethod]
        public void StringCtor_GivesCorrectYear()
        {
            //Arrange
            string input = "20180427";
            int expected = 2018;
            IntegerDate testObj;

            //Act
            testObj = new IntegerDate(input);

            //Assert
            Assert.AreEqual(expected, testObj.Year);
        }

        [TestMethod]
        public void StringCtor_GivesCorrectMonth()
        {
            //Arrange
            string input = "20180427";
            int expected = 4;
            IntegerDate testObj;

            //Act
            testObj = new IntegerDate(input);

            //Assert
            Assert.AreEqual(expected, testObj.Month);
        }

        [TestMethod]
        public void StringCtor_GivesCorrectDay()
        {
            //Arrange
            string input = "20180427";
            int expected = 27;
            IntegerDate testObj;

            //Act
            testObj = new IntegerDate(input);

            //Assert
            Assert.AreEqual(expected, testObj.Day);
        }

        [TestMethod]
        public void DateTimeCtor_GivesCorrectYear()
        {
            //Arrange
            DateTime input = new DateTime(2018, 05, 16);
            int expected = 2018;
            IntegerDate testObj;

            //Act
            testObj = new IntegerDate(input);

            //Assert
            Assert.AreEqual(expected, testObj.Year);
        }

        [TestMethod]
        public void DateTimeCtor_GivesCorrectMonth()
        {
            //Arrange
            DateTime input = new DateTime(2018, 05, 16);
            int expected = 5;
            IntegerDate testObj;

            //Act
            testObj = new IntegerDate(input);

            //Assert
            Assert.AreEqual(expected, testObj.Month);
        }

        [TestMethod]
        public void DateTimeCtor_GivesCorrectDay()
        {
            //Arrange
            DateTime input = new DateTime(2018, 05, 16);
            int expected = 16;
            IntegerDate testObj;

            //Act
            testObj = new IntegerDate(input);

            //Assert
            Assert.AreEqual(expected, testObj.Day);
        }

        [TestMethod]
        public void IntCtor_GivesCorrectDayMonthYear()
        {
            //Arrange
            int expectedDay = 16;
            int expectedMonth = 05;
            int expectedYear = 2018;
            int input = (expectedYear * 10000) + (expectedMonth * 100) + expectedDay;
            IntegerDate testObj;

            //Act
            testObj = new IntegerDate(input);

            //Assert
            Assert.AreEqual(expectedDay, testObj.Day);
            Assert.AreEqual(expectedMonth, testObj.Month);
            Assert.AreEqual(expectedYear, testObj.Year);
        }

        [TestMethod]
        public void ToDateTime()
        {
            //Arrange
            string input = "20180427";
            DateTime expected = new DateTime(2018, 04, 27);
            IntegerDate testObj;

            //Act
            testObj = new IntegerDate(input);

            //Assert
            Assert.AreEqual(expected, testObj.ToDateTime);
        }

        [TestMethod]
        public void ToInt32_Correct()
        {
            //Arrange
            string input = "20180427";
            int expected = 20180427;
            IntegerDate testObj;

            //Act
            testObj = new IntegerDate(input);

            //Assert
            Assert.AreEqual(expected, testObj.ToInt);
        }

        [TestMethod]
        public void ToString_Correct()
        {
            //Arrange
            string input = "20180427";
            string expected = "20180427";
            IntegerDate testObj;

            //Act
            testObj = new IntegerDate(input);

            //Assert
            Assert.AreEqual(expected, testObj.ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void NonNumericThrows()
        {
            //Arrange
            string input = "aaa";

            IntegerDate testObj;

            //Act
            testObj = new IntegerDate(input);

            //Assert
            //Throws
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void InvalidLengthInputThrows()
        {
            //Arrange
            string input = "111";
            IntegerDate testObj;

            //Act
            testObj = new IntegerDate(input);

            //Assert
            //Throws
        }
    }
}
