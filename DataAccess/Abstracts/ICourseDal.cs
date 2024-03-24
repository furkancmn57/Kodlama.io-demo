using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public interface ICourseDal
    {
        List<Course> GetAll();
        Course GetById(int courseId);
        public void Add(Course course);
        public void Update(Course course);
        public void Delete(Course course);
    }
}
