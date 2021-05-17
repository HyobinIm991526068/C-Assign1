using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HI_LAB1.Models
{
	public class Student
	{
		[Required(ErrorMessage = "Please Enter Your First Name")]
		public string FirstName { get; set; }

		[Required(ErrorMessage = "Please Enter Your Last Name")]
		public string LastName { get; set; }

		[Required(ErrorMessage = "Please Enter Your Student Number")]
		public string StudentNumber { get; set; }

		[Required(ErrorMessage = "Please Select A Course")]
		public string SelectedCourse { get; set; }

	
	}
}
