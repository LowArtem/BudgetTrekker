﻿using System;

namespace BudgetTrekker.Models
{
    public static class DateTimeExtensions
    {
        public static DateTime StartOfWeek(this DateTime dt, DayOfWeek startOfWeek)
        {
            int diff = (7 + (dt.DayOfWeek - startOfWeek)) % 7;
            return dt.AddDays(-1 * diff).Date;
        }

        public static DateTime StartOfMonth(this DateTime dt)
        {
            var start = new DateTime(dt.Year, dt.Month, 1);
            return start;
        }

        public static DateTime StartOfYear(this DateTime dt)
        {
            var start = new DateTime(dt.Year, 1, 1);
            return start;
        }
    }
}
