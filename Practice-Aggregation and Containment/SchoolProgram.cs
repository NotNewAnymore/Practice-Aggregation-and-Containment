using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Aggregation_and_Containment
{
	internal class SchoolProgram
	{
		string _className;
		string _classNumber;
		string _roomNumber;
		Instructor _instructor;
		List<Student> _classRoster;

		public SchoolProgram(string className, string classNumber, string roomNumber, Instructor instructor)
		{
			_className = className;
			_classNumber = classNumber;
			_roomNumber = roomNumber;
			_instructor = instructor;
			_classRoster = new List<Student>();
		}

		public void AddStudent(Student student)
		{
			_classRoster.Add(student);
		}
		public void AddStudent(string firstName, string lastName, int csiGrade, int genEdGrade)
		{
			Student student = new Student(firstName, lastName, csiGrade, genEdGrade);
			_classRoster.Add(student);
		}

		public override string ToString()
		{
			return $"{_className}, {_classNumber}, instructor: {_instructor.FirstName} {_instructor.LastName}, has {_classRoster.Count} students.";
		}

		public string ClassName { get => _className; set => _className = value; }
		public string ClassNumber { get => _classNumber; set => _classNumber = value; }
		public string RoomNumber { get => _roomNumber; set => _roomNumber = value; }
		internal Instructor Instructor { get => _instructor; set => _instructor = value; }
		internal List<Student> ClassRoster { get => _classRoster; }
	}
}
