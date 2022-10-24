using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeLibrary
{
    public class DateTimeClass
    {
        /// <summary>
        /// метод на вычисление предыдущей даты
        /// </summary>
        
        public DateTime PrevDate(DateTime todayDate)
        {
            if (todayDate == new DateTime())
            {
                throw new Exception("Вы не ввели дату");
            }
            else
            {
                todayDate = todayDate.AddDays(-1);
                return todayDate;

            }
        }
        /// <summary>
        /// метод на вычисление следующей даты
        /// </summary>
        public DateTime NextDate(DateTime todayDate)
        {
            if (todayDate == new DateTime())
            {
                throw new Exception("Вы не ввели дату");
            }
            else
            {
                todayDate = todayDate.AddDays(1);
                return todayDate;

            }
        }
        /// <summary>
        /// метод на вычисление дней до конца месяца с текущей даты
        /// </summary>
        public int DaysUntilEndMonth(DateTime todayDate)
        {
            if (todayDate == new DateTime())
            {
                throw new Exception("Вы не ввели дату");
            }
            else
            {
                int daysInMonth = DateTime.DaysInMonth(todayDate.Year, todayDate.Month);
                daysInMonth = daysInMonth - todayDate.Day;
                return daysInMonth;

            }
        }

        /// <summary>
        /// метод на вычисление является ли год високосным
        /// </summary>
        public bool LeapYearCheck(DateTime todayDate)
        {
            if (todayDate == new DateTime())
            {
                throw new Exception("Вы не ввели дату");
            }
            else
            {              
                return DateTime.IsLeapYear(todayDate.Year);
            }
        }
        /// <summary>
        /// метод на вычисление даты причисляя или вычитая дни с текущей 
        /// </summary>
        public DateTime FindDate(DateTime todayDate, int days)
        {
            if (todayDate == new DateTime())
            {
                throw new Exception("Вы не ввели дату");
            }
            else
            {
                return todayDate.AddDays(days);
            }
        }
        /// <summary>
        /// метод на вычисление является ли день последним в месяце
        /// </summary>
        public bool LastDayOfMonthCheck(DateTime todayDate)
        {
            if (todayDate == new DateTime())
            {
                throw new Exception("Вы не ввели дату");
            }
            else
            {
                int daysInMonth = DateTime.DaysInMonth(todayDate.Year, todayDate.Month);
                if (todayDate.Day == daysInMonth)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        /// <summary>
        /// метод на вычисление является ли день первым в году
        /// </summary>
        public bool FirstDayOfYearCheck(DateTime todayDate)
        {
            if (todayDate == new DateTime())
            {
                throw new Exception("Вы не ввели дату");
            }
            else
            {
                if (todayDate.Day == 1 && todayDate.Month == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
