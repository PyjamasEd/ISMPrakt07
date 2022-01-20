using System;
using System.Collections.Generic;
using System.Text;

namespace ISMPrakt07
{
    public class Date
    {
        protected int _Day;
        protected int _Month;
        protected int _Year;
        protected int _Hours;
        protected int _Minutes;
        
        public Date(int day, int month, int year,int hours,int minutes)
        {
            _Day = day;
            _Month = month;
            _Year = year;
            _Hours = hours;
            _Minutes = minutes;
        }
        public Date(Date date)
        {
            _Day = date._Day;
            _Month = date._Month;
            _Year = date._Year;
            _Hours = date._Hours;
            _Minutes = date._Minutes;
        }
        public int Day
        {
            get => _Day;
            set => _Day = value;
        }
        public int Month
        {
            get => _Month;
            set => _Month = value;
        }
        public int Year
        {
            get => _Year;
            set => _Year = value;
        }
        public int Hours
        {
            get => _Hours;
            set => _Hours = value;
        }
        public int Minutes
        {
            get => _Minutes;
            set => _Minutes = value;
        }

    }
}
