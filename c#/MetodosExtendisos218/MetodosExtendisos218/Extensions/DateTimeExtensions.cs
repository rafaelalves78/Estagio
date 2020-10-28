﻿using System;
using System.Globalization;

namespace MetodosExtendisos218.Extensions
{
   
    static class DateTimeExtensions
    {
       
        static public string ElapsedTime(this DateTime thisObj)
        {

            TimeSpan duration = DateTime.Now.Subtract(thisObj);

            if(duration.TotalHours < 24.0)
            {
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " hours.";
            }
            else
            {
                return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " days";
            }
        }
    }
}