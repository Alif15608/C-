using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Lab_Task
{
    class Course
    {
        private string courseName;
        private string courseCode;
        private int courseCredit;

        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }

        public string CourseCode
        {
            get { return courseCode; }
            set { courseCode = value; }
        }

        public int CourseCredit
        {
            get { return courseCredit; }
            set { courseCredit = value; }
        }

        public Course() { }
        public Course(string courseName,string courseCode,int courseCredit)
        {
            this.courseName = courseName;
            this.CourseCode = courseCode;
            this.courseCredit = courseCredit;
        }

        public void ShowCourseInfo()
        {
            Console.WriteLine("Course Name is :" + courseName);
            Console.WriteLine("Course Code :" + courseCode);
            Console.WriteLine("Course Credit :" + courseCredit);
        }
    }
}
