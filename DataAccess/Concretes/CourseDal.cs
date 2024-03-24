using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class CourseDal : ICourseDal
    {
        List<Course> _courses;
        public CourseDal() 
        {
            // Constructor
            Course course1 = new Course();
            course1.CourseId = 1;
            course1.CategoryId = 1;
            course1.InstructorId = 1;
            course1.CourseName = "C#";
            course1.CourseDescription = "C# Course";
            course1.CourseImage = "csharp.jpg";
            course1.CoursePrice = 0;
            course1.CourseStatus = true;

            Course course2 = new Course();
            course2.CourseId = 2;
            course2.CategoryId = 2;
            course2.InstructorId = 1;
            course2.CourseName = "Java";
            course2.CourseDescription = "Java Course";
            course2.CourseImage = "java.jpg";
            course2.CoursePrice = 0;
            course2.CourseStatus = true;

            _courses = new List<Course> { course1, course2 };
        }
        public List<Course> GetAll()
        {
            return _courses;
        }
        public void Add(Course course)
        {
            _courses.Add(course);

            Console.WriteLine("Course Added");
        }
        public void Update(Course course)
        {
            Course courseToUpdate = _courses.SingleOrDefault(c => c.CourseId == course.CourseId);

            courseToUpdate.InstructorId = course.InstructorId;
            courseToUpdate.CourseName = course.CourseName;
            courseToUpdate.CourseDescription = course.CourseDescription;
            courseToUpdate.CourseImage = course.CourseImage;
            courseToUpdate.CoursePrice = course.CoursePrice;
            courseToUpdate.CourseStatus = course.CourseStatus;

            Console.WriteLine("Course Updated");
        }
        public void Delete(Course course)
        {

            Course courseToDelete = _courses.SingleOrDefault(c => c.CourseId == course.CourseId);

            _courses.Remove(courseToDelete);

            Console.WriteLine("Course Deleted");
        }

        public Course GetById(int courseId)
        {
            Course course = _courses.SingleOrDefault(c => c.CourseId == courseId);

            return course;
        }
    }
}
