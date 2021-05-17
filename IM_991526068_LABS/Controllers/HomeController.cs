using HI_LAB1.Models;
using IM_991526068_LABS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace IM_991526068_LABS.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public ViewResult Index()
		{
			return View("HomePage");
		}


		public ActionResult EditCourse(string id)
		{
			Course course = CourseList.Courses.Where(c => c.CourseCode == id).FirstOrDefault();
			ViewBag.Course = course;
			return View();
		}

		[HttpPost]
		public ViewResult EditCourse(Course course)
		{
			Student student = StudentList.Students.Where(s => s.StudentNumber == course.StudentNumber).FirstOrDefault();
			CourseList.Courses.Where(c => c.CourseCode == course.CourseCode).FirstOrDefault().SList.Remove(student);
			return View("HomePage");
		}

		public ViewResult Summary()
		{
			ViewBag.Courses = CourseList.Courses;
			ViewBag.Students = StudentList.Students;
			return View();
		}

		[HttpGet]
		public ViewResult CourseForm()
		{
			ViewBag.Students = StudentList.Students;
			return View();
		}

		[HttpPost]
		public ViewResult CourseForm(Course course)
		{
			if (ModelState.IsValid)
			{
				CourseList.AddCourse(course);
				
				return View("ThankYouCourse", course);
			}
			else
			{
				return View();
			}
		}

		public ViewResult CourseLists()
		{
			return View(CourseList.Courses);
		}

		[HttpGet]
		public ViewResult StudentForm()
		{
			ViewBag.Courses = CourseList.Courses;
			return View();
		}

		[HttpPost]
		public ViewResult StudentForm(Student student)
		{
			Course course = CourseList.Courses.Where(c => c.CourseName == student.SelectedCourse).FirstOrDefault();
			course.SList.Add(student);
			if (ModelState.IsValid)
			{
				StudentList.AddStudent(student);
				return View("ThankYou", student);
			}
			else
			{
				return View();
			}
		}

		public ViewResult StudentLists()
		{
			return View(StudentList.Students);
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
