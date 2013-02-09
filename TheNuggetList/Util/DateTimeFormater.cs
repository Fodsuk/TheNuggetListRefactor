using System;

namespace TheNuggetList.Util
{
    public class DateTimeFormater
    {
		private readonly DateTime _currentDateTime;
		private readonly DateTime _pastDateTime;
		private readonly TimeSpan _timeSpan;

		public DateTimeFormater(DateTime currentDateTime, DateTime pastDateTime)
		{
			_currentDateTime = currentDateTime;
			_pastDateTime = pastDateTime;
			TimeSpan timeSpan = _currentDateTime - _pastDateTime;
		}

        public static string GetReadableTimespan(DateTime date)
        {
			DateTimeFormater dateTimeFormater = new DateTimeFormater(DateTime.Now, date);
			return dateTimeFormater.GetSuitableReadableTimespan();
        }

		public string GetSuitableReadableTimespan()
		{
			if (_pastDateTime > _currentDateTime.AddMinutes(-5))
			{
				return "A moment ago.";
			}
			else if (_pastDateTime > _currentDateTime.AddHours(1))
			{
				return GetReadableTimespanInMinutes();
			}
			else if (_pastDateTime > _currentDateTime.AddHours(24))
			{
				return GetReadableTimespanInHours();
			}
			else if (_pastDateTime > _currentDateTime.AddDays(30))
			{
				return GetReadableTimespanInDays();
			}
			else if (_pastDateTime > _currentDateTime.AddMonths(12))
			{
				return GetReadableTimespanInMonths();
			}
			else
			{
				return GetReadableTimespanInYears();
			}
		}

		public string GetReadableTimespanInMinutes()
		{
			return GetPluralisedTimeUnitMessage(_timeSpan.Minutes, "minute");
		}

		public string GetReadableTimespanInHours()
		{
			return GetPluralisedTimeUnitMessage(_timeSpan.Hours, "hour");
		}

		public string GetReadableTimespanInDays()
		{
			return GetPluralisedTimeUnitMessage(_timeSpan.Days, "day");
		}

		public string GetReadableTimespanInMonths()
		{
			long months = _timeSpan.Days / 30;
			return GetPluralisedTimeUnitMessage(months, "month");
		}

		public string GetReadableTimespanInYears()
		{
			long years = _timeSpan.Days / 365;
			return GetPluralisedTimeUnitMessage(years, "year");
		}

		private string GetPluralisedTimeUnitMessage(long amount, string timeUnit)
		{
			if (amount == 1)
				return string.Format("{0} {1} ago", amount, timeUnit);
			else
				return string.Format("{0} {1}s ago", amount, timeUnit);
		}
    }
}