using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class InstructorDal : IInstructorDal
    {
        List<Instructor> _instructors;
        public InstructorDal() 
        { 
            _instructors = new List<Instructor>
            {
                new Instructor { InstructorId = 1, Name = "Engin", Surname = "Demiroğ", ProfileImage = "engin.jpg"},
                new Instructor { InstructorId = 2, Name = "Halit Enes", Surname = "Kalaycı", ProfileImage = "halitenes.jpg" },
            };
        }
        public List<Instructor> GetAll()
        {
            return _instructors;
        }
        public void Add(Instructor instructor)
        {
            _instructors.Add(instructor);
        }
        public void Update(Instructor instructor)
        {
            Instructor instructorToUpdate = _instructors.SingleOrDefault(i => i.InstructorId == instructor.InstructorId);

            instructorToUpdate.Name = instructor.Name;
            instructorToUpdate.Surname = instructor.Surname;
            instructorToUpdate.ProfileImage = instructor.ProfileImage;
            instructorToUpdate.Biography = instructor.Biography;

            Console.WriteLine("Instructor Updated");
        }
        public void Delete(Instructor instructor)
        {
            Instructor instructorToDelete = _instructors.SingleOrDefault(i => i.InstructorId == instructor.InstructorId);

            _instructors.Remove(instructorToDelete);

            Console.WriteLine("Instructor Deleted");
        }

    }
}
