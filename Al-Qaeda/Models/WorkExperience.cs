using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Al_Qaeda.Models
{
    public class WorkExperience
    {
        public int Months;
        public int Years;
        public Work Work = new Work();
        public WorkExperience(Work work, DateTime workstart, DateTime workend)
        {
            Work = work;
            int month = workend.Month - workstart.Month;
            int year = workend.Year - workstart.Year;
            if (month < 0)
            {
                month = 12 - month;
                year -= 1;
            }

            Months = month;
            Years = year;
        }

    }
}