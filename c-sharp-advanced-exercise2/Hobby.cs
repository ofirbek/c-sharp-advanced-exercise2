using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_advanced_exercise2
{
	public class Hobby
	{
		public string HobbyName { get; set; }
		double _hoursPerWeek;

		public double HoursPerWeek
		{
			get { return _hoursPerWeek; }
			set { if (value > 0 && value < 168) _hoursPerWeek = value; }
		}

		public Hobby(string name, double hoursPerWeek)
		{
			HobbyName = name;
			_hoursPerWeek = hoursPerWeek;
		}
	}
}
