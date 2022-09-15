using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class Date
    {
        private int day, year;
        private  string month;

        public Date()
        {
            day = 12;
            month = "sept";
            year = 2020;

        }
        public Date(int day,string month ,int year)
        {
            this.day = day;
            this.year = year;
            this.month = month;
        }
        public string Displayvalue()
        {
            return $"{day} / {month} / {year} ";
        }
    }
}
