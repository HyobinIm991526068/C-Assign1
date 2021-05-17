using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HI_LAB1.Models
{
	public class StudentList
	{
		private static List<Student> students = new List<Student>();
		public static IEnumerable<Student> Students => students;

		public static void AddStudent(Student student)
		{
			students.Add(student);
		}

		public static void DeleteStudent(Student student)
		{
			students.Remove(student);
		}
	}
}
