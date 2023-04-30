using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Aggregation_and_Containment
{
	internal class Instructor
	{
		string _firstName;
		string _lastName;

		public Instructor(string firstName, string lastName)
		{
			_firstName = firstName;
			_lastName = lastName;
		}

		public string FirstName { get => _firstName; set => _firstName = value; }
		public string LastName { get => _lastName; set => _lastName = value; }

		public override string ToString()
		{
			return $"{_firstName} {_lastName}";
		}
	}
}
