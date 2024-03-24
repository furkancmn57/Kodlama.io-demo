using Business.Concretes;
using DataAccess.Concretes;
using Entities.Concretes;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("-------------------Instructor-----------------");
        InstructorManager instructorManager = new InstructorManager(new InstructorDal());
        //instructorManager.Add(new Instructor { InstructorId = 3, Name = "Furkan", Surname = "Çimen", ProfileImage = "furkan.jpg"});
        //instructorManager.Update(new Instructor { InstructorId = 1, Name = "Engin", Surname = "Demiroğ", ProfileImage = "engin.jpg", Biography= "Savunma Sanayisi, Bankacılık sektörlerine kurumsal yazılım geliştirme süreçleri konusunda danışmanlık veriyorum." });
        //instructorManager.Delete(new Instructor { InstructorId = 2 });
        var resultInstructor = instructorManager.GetAll();

        foreach (var instructor in resultInstructor)
        {

            Console.WriteLine("InstructorId : "+instructor.InstructorId);
            Console.WriteLine("InstructorName : "+instructor.Name);
            Console.WriteLine("InstructorSurname : "+instructor.Surname);
            Console.WriteLine("InstructorProfileImage : " + instructor.ProfileImage);
            Console.WriteLine("InstructorBiography : " + instructor.Biography);
            Console.WriteLine("-----------------");
        }

        Console.WriteLine("-------------------------Course------------------");

        CourseManager courseManager = new CourseManager(new CourseDal());
        //courseManager.Add(new Course { CourseId = 3, CategoryId = 1, InstructorId = 1, CourseName = "Python Programming", CourseImage = "python.jpg", CoursePrice = 0, CourseStatus = true });
        //courseManager.Update(new Course { CourseId = 2, CategoryId = 2, InstructorId = 1, CourseName = "Dart Programming", CourseImage = "dart.jpg", CoursePrice = 0, CourseStatus = true });
        //courseManager.Delete(new Course { CourseId = 2});
        //var result = courseManager.GetById(1);
        var resultCourse = courseManager.GetAll();
        
        foreach (var course in resultCourse)
        {
            Console.WriteLine("CourseId : "+course.CourseId);
            Console.WriteLine("CategoryId : "+course.CategoryId);
            Console.WriteLine("InstructorId : "+course.InstructorId);
            Console.WriteLine("CourseName : "+course.CourseName);
            Console.WriteLine("CourseImage : "+course.CourseImage);
            Console.WriteLine("CoursePrice : "+course.CoursePrice);
            Console.WriteLine("CourseStatus : "+course.CourseStatus);
            Console.WriteLine("-------------------------");
        }
        

        Console.WriteLine("-------------------------Category------------------");

        CategoryManager categoryManager = new CategoryManager(new CategoryDal());
        //categoryManager.Add(new Category { CategoryId = 3, CategoryName = "Music" });
        //categoryManager.Update(new Category { CategoryId = 2, CategoryName = "Music" });
        //categoryManager.Delete(new Category { CategoryId = 2});
        var resultCategory = categoryManager.GetAll();

        foreach (var category in resultCategory)
        {
            Console.WriteLine("CategoryId : "+category.CategoryId);
            Console.WriteLine("CategoryName : "+category.CategoryName);
            Console.WriteLine("-------------------------");
        }
    }
}