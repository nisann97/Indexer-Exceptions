using System;
namespace Classroom
{
	public class Classroom1
	{
		public int Id { get; set; }
		public string Name { get; set; }
		private Student[] _students;


		public Classroom1(int size = 100)
		{
			_students = new Student[size];
		}

		public Student this[int index]
		{
			get
			{
				return _students[index];
			}
			set
			{
				_students[index] = value;
			}
		}
	}
}

