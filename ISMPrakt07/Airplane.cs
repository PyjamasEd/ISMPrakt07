using System;
using System.Collections.Generic;
using System.Text;

namespace ISMPrakt07
{
    class Airplane
    {
        protected string _StartCity;
        protected string _FinishCity;
        protected Date _StartDate;
        protected Date _FinishDate;
        public Airplane(string startcity,string finishcity,Date startdate,Date finishdate){
            _StartCity = startcity;
            _FinishCity = finishcity;
            _StartDate = startdate;
            _FinishDate = finishdate;
        }
        public string StartCity
        {
            get => _StartCity;
            set => _StartCity = value;
        }
        public string FinishCity
        {
            get => _FinishCity;
            set => _FinishCity = value;
        }
        public Date StartDate
        {
            get => _StartDate;
            set => _StartDate = value;
        }
        public Date FinishDate
        {
            get => _FinishDate;
            set => _FinishDate = value;
        }
        public int GetTotalTime()
        {
            Date result = new Date(_FinishDate.Day - _StartDate.Day, _FinishDate.Month - _StartDate.Month, _FinishDate.Year - _StartDate.Year, _FinishDate.Hours - _StartDate.Hours, _FinishDate.Minutes - _StartDate.Minutes);
            int resultInMin = 0;
            if (result.Day > 0)
            {
                resultInMin = (result.Day * 24 * 60) + (result.Hours * 60);
            }
            else
            {
                resultInMin = result.Hours * 60;
            }
            return resultInMin;
        }
        public bool IsArrivingToday()
        {
            bool result;
            if (_StartDate.Day == _FinishDate.Day && _StartDate.Month == _FinishDate.Month && _StartDate.Year == _FinishDate.Year)
            {
                result = true;
            }
            else { result = false; }
            return result;
        }


    }
}
