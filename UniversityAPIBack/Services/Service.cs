using UniversityAPIBack.DataAccess;
using UniversityAPIBack.Models.DataModel;

namespace UniversityAPIBack.Services
{
    public class Service
    {
        private readonly UniversityDbContext _context;

        public Service(UniversityDbContext context)
        {
            _context = context;
        }

        //Buscar usuarios por email
        public User GetUserByEmail(string email) 
        {
            return _context.Users.Where(x => x.EmailAddress == email).FirstOrDefault();
        }

        //Buscar alumnos que tengan al menos un curso
        public List<Student> GetStudents()
        {
            return _context.Students.Where(x => x.Courses.Any()).ToList();
        }

        //Buscar cursos de un nivel determinado que al menos tengan un alumno inscrito
        public List<Course> GetCourses()
        {
            return _context.Courses.Where(x => x.Level == Level.Intermediate && x.Students.Any()).ToList();
        }

        //Buscar cursos de un nivel determinado que sean de una categoría determinada
        public List<Course> GetCourses2(string name)
        {

            return _context.Courses.Where(x => x.Level == Level.Intermediate && x.Categories.Any(y => y.Name==name)).ToList();
        }

        //Buscar cursos sin alumnos
        public List<Course> GetCourses3()
        {
            return _context.Courses.Where(x => !x.Students.Any()).ToList();
        }


    }
}
