using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HI_LAB1.Models
{
	public class CourseList
	{
		private static List<Course> courses = new List<Course>();

		public static IEnumerable<Course> Courses => courses;

		public static void AddCourse(Course course)
		{
			courses.Add(course);
		}
	}
}
