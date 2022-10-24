using System;
using DateTimeLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DateTimeLibraryTests
{
    [TestClass]
    public class DateTimeClassTests
    {
        DateTimeClass testedObject = new DateTimeClass();

        //проверка метода предидущей даты 

        /// <summary>
        /// тест на правильное вычитание даты 
        /// </summary>
        [TestMethod]
        public void PrevDate_RightDate_ReturnPreviousDate()
        {
            //Arrange
            DateTime entryDateTime = (new DateTime(2003, 04, 13));
            DateTime expectDateTime = (new DateTime(2003, 04, 12));
            //Act
            DateTime actualDateTime = testedObject.PrevDate(entryDateTime);
            //Assert
            Assert.AreEqual(actualDateTime, expectDateTime);
        }

        /// <summary>
        /// тест на неправильное вычитание даты 
        /// </summary>
        [TestMethod]
        public void PrevDate_NotRightDate_ReturnPreviousDate()
        {
            //Arrange
            DateTime entryDateTime = (new DateTime(2003, 04, 13));
            DateTime expectDateTime = (new DateTime(2003, 04, 11));
            //Act
            DateTime actualDateTime = testedObject.PrevDate(entryDateTime);
            //Assert
            Assert.AreNotEqual(actualDateTime, expectDateTime);
        }

        /// <summary>
        /// тест на ошибку при пустой дате 
        /// </summary>
        [TestMethod]
        public void PrevDate_NullDate_ThrowExeption()
        {
            //Arrange
            DateTime entryDateTime = new DateTime();            
            //Assert
            Assert.ThrowsException<Exception>(() => testedObject.PrevDate(entryDateTime));
        }











        //проверка метода следующей даты 

        /// <summary>
        /// тест на правильное сложение даты 
        /// </summary>
        [TestMethod]
        public void NextDate_RightDate_ReturnNextDate()
        {
            //Arrange
            DateTime entryDateTime = (new DateTime(2003, 04, 13));
            DateTime expectDateTime = (new DateTime(2003, 04, 14));
            //Act
            DateTime actualDateTime = testedObject.NextDate(entryDateTime);
            //Assert
            Assert.AreEqual(actualDateTime, expectDateTime);
        }

        /// <summary>
        /// тест на неправильное сложение даты 
        /// </summary>
        [TestMethod]
        public void NextDate_NotRightDate_ReturnNextDate()
        {
            //Arrange
            DateTime entryDateTime = (new DateTime(2003, 04, 13));
            DateTime expectDateTime = (new DateTime(2003, 05, 14));
            //Act
            DateTime actualDateTime = testedObject.NextDate(entryDateTime);
            //Assert
            Assert.AreNotEqual(actualDateTime, expectDateTime);
        }

        /// <summary>
        /// тест на ошибку при пустой дате 
        /// </summary>
        [TestMethod]
        public void NextDate_NullDate_ThrowExeption()
        {
            //Arrange
            DateTime entryDateTime = new DateTime();
            //Assert
            Assert.ThrowsException<Exception>(() => testedObject.NextDate(entryDateTime));
        }










        //проверка метода оставшихся дней в месяце

        /// <summary>
        /// тест на правильное кол-во оставшихся дней
        /// </summary>
        [TestMethod]
        public void DaysUntilEndMonth_RightDate_ReturnRightEndMonth()
        {
            //Arrange
            DateTime entryDateTime = (new DateTime(2022, 10, 24));
            int expectDays = 7;
            //Act
            int actualDays = testedObject.DaysUntilEndMonth(entryDateTime);
            //Assert
            Assert.AreEqual(expectDays, actualDays);
        }

        /// <summary>
        /// тест на неправильное кол-во дней
        /// </summary>
        [TestMethod]
        public void DaysUntilEndMonth_NotRightDate_ReturnNotRightEndMonth()
        {
            //Arrange
            DateTime entryDateTime = (new DateTime(2022, 10, 24));
            int expectDays = 20;
            //Act
            int actualDays = testedObject.DaysUntilEndMonth(entryDateTime);
            //Assert
            Assert.AreNotEqual(expectDays, actualDays);
        }

        /// <summary>
        /// тест на ошибку при пустой дате 
        /// </summary>
        [TestMethod]
        public void DaysUntilEndMonth_NullDate_ThrowExeption()
        {
            //Arrange
            DateTime entryDateTime = new DateTime();
            //Assert
            Assert.ThrowsException<Exception>(() => testedObject.DaysUntilEndMonth(entryDateTime));
        }
















        //проверка метода является ли год високосным

        /// <summary>
        /// тест на високосный год
        /// </summary>
        [TestMethod]
        public void LeapYearCheck_LeapYear_ReturnTrue()
        {
            //Arrange
            DateTime entryDateTime = (new DateTime(2024, 10, 24));
            //Assert
            Assert.IsTrue(testedObject.LeapYearCheck(entryDateTime));
        }

        /// <summary>
        /// тест на не високосный год
        /// </summary>
        [TestMethod]
        public void LeapYearCheck_NotLeapYear_ReturnFalse()
        {
            //Arrange
            DateTime entryDateTime = (new DateTime(2022, 10, 24));
            //Assert
            Assert.IsFalse(testedObject.LeapYearCheck(entryDateTime));
        }

        /// <summary>
        /// тест на ошибку при пустой дате 
        /// </summary>
        [TestMethod]
        public void LeapYearCheck_NullDate_ThrowExeption()
        {
            //Arrange
            DateTime entryDateTime = new DateTime();
            //Assert
            Assert.ThrowsException<Exception>(() => testedObject.LeapYearCheck(entryDateTime));
        }















        //проверка метода на нахождение даты прибавляя или вычитая дни

        /// <summary>
        /// тест на нахождение даты вперед
        /// </summary>
        [TestMethod]
        public void FindDate_DaysForward_ReturnRightDate()
        {
            //Arrange
            DateTime entryDateTime = (new DateTime(2022, 10, 24));
            int entryDays = 16;
            DateTime expectDateTime = (new DateTime(2022, 11, 9));
            //Act
            DateTime actualDate = testedObject.FindDate(entryDateTime, entryDays);
            //Assert
            Assert.AreEqual(actualDate, expectDateTime);
        }

        /// <summary>
        /// тест на нахождение даты назад
        /// </summary>
        [TestMethod]
        public void FindDate_NotLeapYear_ReturnRightDate()
        {
            //Arrange
            DateTime entryDateTime = (new DateTime(2022, 10, 24));
            int entryDays = -24;
            DateTime expectDateTime = (new DateTime(2022, 9, 30));
            //Act
            DateTime actualDate = testedObject.FindDate(entryDateTime, entryDays);
            //Assert
            Assert.AreEqual(actualDate, expectDateTime);
        }

        /// <summary>
        /// тест на ошибку при пустой дате 
        /// </summary>
        [TestMethod]
        public void FindDate_NullDate_ThrowExeption()
        {
            //Arrange
            DateTime entryDateTime = new DateTime();
            int entryDays = 0;
            //Assert
            Assert.ThrowsException<Exception>(() => testedObject.FindDate(entryDateTime, entryDays));
        }












        //проверка метода является ли дата последним днем в месяце

        /// <summary>
        /// тест на последний день месяца
        /// </summary>
        [TestMethod]
        public void LastDayOfMonthCheck_LastDay_ReturnTrue()
        {
            //Arrange
            DateTime entryDateTime = (new DateTime(2022, 10, 31));
            //Assert
            Assert.IsTrue(testedObject.LastDayOfMonthCheck(entryDateTime));
        }

        /// <summary>
        /// тест на не последний день месяца
        /// </summary>
        [TestMethod]
        public void LastDayOfMonthCheck_NotLastDay_ReturnFalse()
        {
            //Arrange
            DateTime entryDateTime = (new DateTime(2022, 10, 24));
            //Assert
            Assert.IsFalse(testedObject.LastDayOfMonthCheck(entryDateTime));
        }

        /// <summary>
        /// тест на ошибку при пустой дате 
        /// </summary>
        [TestMethod]
        public void LastDayOfMonthCheck_NullDate_ThrowExeption()
        {
            //Arrange
            DateTime entryDateTime = new DateTime();
            //Assert
            Assert.ThrowsException<Exception>(() => testedObject.LastDayOfMonthCheck(entryDateTime));
        }











        //проверка метода является ли дата первым числом в году

        /// <summary>
        /// тест на последний день месяца
        /// </summary>
        [TestMethod]
        public void FirstDayOfYearCheck_FirstDay_ReturnTrue()
        {
            //Arrange
            DateTime entryDateTime = (new DateTime(2022, 1, 1));
            //Assert
            Assert.IsTrue(testedObject.FirstDayOfYearCheck(entryDateTime));
        }

        /// <summary>
        /// тест на не последний день месяца
        /// </summary>
        [TestMethod]
        public void FirstDayOfYearCheck_NotFirstDay_ReturnFalse()
        {
            //Arrange
            DateTime entryDateTime = (new DateTime(2022, 1, 2));
            //Assert
            Assert.IsFalse(testedObject.FirstDayOfYearCheck(entryDateTime));
        }

        /// <summary>
        /// тест на ошибку при пустой дате 
        /// </summary>
        [TestMethod]
        public void FirstDayOfYearCheck_NullDate_ThrowExeption()
        {
            //Arrange
            DateTime entryDateTime = new DateTime();
            //Assert
            Assert.ThrowsException<Exception>(() => testedObject.FirstDayOfYearCheck(entryDateTime));
        }

    }
}
