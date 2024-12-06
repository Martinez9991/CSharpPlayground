using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQToObjectsAndQueryOperators
{
    internal class UniversityManager
    {
        public List<University> universities;
        public List<Student> students;

        //constructor
        public UniversityManager()
        {
            universities = new List<University>();
            students = new List<Student>();

            universities.Add(new University { Id = 1, Name = "Yale"});
            universities.Add(new University { Id = 2, Name = "IPCA" });

            students.Add(new Student { Id = 1, Name = "Carla", Gender = "female", Age = 17 , UniversityId = 1 });
            students.Add(new Student { Id = 2, Name = "Toni", Gender = "male", Age = 21, UniversityId = 1 });
            students.Add(new Student { Id = 3, Name = "Frank", Gender = "male", Age = 22, UniversityId = 2 });
            students.Add(new Student { Id = 4, Name = "Leyla", Gender = "female", Age = 19, UniversityId = 2 });
            students.Add(new Student { Id = 5, Name = "James", Gender = "trans-gender", Age = 25, UniversityId = 2 });
            students.Add(new Student { Id = 6, Name = "Linda", Gender = "female", Age = 22, UniversityId = 2 });
        }

        public void MaleStudents()
        {
            IEnumerable<Student> malestudents = from student in students where student.Gender == "male" select student;
            Console.WriteLine("Male - Students: ");
            foreach (Student student in malestudents)
            {
                student.Print();
            }
        }

        public void FemaleStudents()
        {
            IEnumerable<Student> femalestudents = from student in students where student.Gender == "female" select student;
            Console.WriteLine("Female - Students: ");
            foreach (Student student in femalestudents)
            {
                student.Print();
            }
        }

        public void SortStudentsByAge()
        {
            var sortedstudents = from student in students orderby student.Age select student;
            Console.WriteLine("Students sorted by Age: ");
            foreach (Student student in sortedstudents)
            {
                student.Print();
            }
        }

        public void AllStudentsFromIPCA()
        {
            IEnumerable<Student> ipcaStudents = from student in students
                                                join university in universities on student.UniversityId equals university.Id
                                                where university.Name == "IPCA"
                                                select student;
            Console.WriteLine("Students from IPCA: ");
            foreach (Student student in ipcaStudents)
            {
                student.Print();
            }
        }

        public void AllStudentsFromThatUni(int id)
        {
            IEnumerable<Student> myStudents = from student in students
                                                join university in universities on student.UniversityId equals university.Id
                                                where university.Id == id
                                                select student;
            Console.WriteLine($"Students from university: {id} ");
            foreach (Student student in myStudents)
            {
                student.Print();
            }
        }

        public void StudentAndUniversityCollection()
        {
            var newCollection = from student in students
                                join university in universities on student.UniversityId equals university.Id
                                orderby student.Name
                                select new { StudentName = student.Name, UniversityName = university.Name };
            Console.WriteLine("New Collection: ");
            foreach (var col in newCollection)
            {
                Console.WriteLine("Student {0} from University {1}", col.StudentName,col.UniversityName);
            }
        }

    }
}
