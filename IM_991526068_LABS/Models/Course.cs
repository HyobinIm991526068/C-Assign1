using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HI_LAB1.Models
{
	public class Course
	{
		[Required(ErrorMessage = "Please Enter The Course Code")]
		public string CourseCode { get; set; }

		[Required(ErrorMessage = "Please Enter The Course Name")]
		public string CourseName { get; set; }

		[Required(ErrorMessage = "Please Enter The Weight Of The Course")]
		public int Credit { get; set; }

		public List<Student> SList = new List<Student>();

		public string StudentNumber { get; set; }
		

	}
}
