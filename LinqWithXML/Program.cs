using System.Xml.Linq;

namespace LinqWithXML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // we simply apply our student-structure to xml
            string studentsXML =
                @"<Students>
                    <Student>
                        <Name>Toni</Name>
                        <Age>21</Age>
                        <University>Yale</University>
                        <Semester>6</Semester>
                    </Student>
                    <Student>
                        <Name>Carla</Name>
                        <Age>17</Age>
                        <University>Yale</University>
                        <Semester>1</Semester>
                    </Student>
                    <Student>
                        <Name>Leyla</Name>
                        <Age>19</Age>
                        <University>IPCA</University>
                        <Semester>3</Semester>
                    </Student>
                    <Student>
                        <Name>Frank</Name>
                        <Age>25</Age>
                        <University>IPCA</University>
                        <Semester>10</Semester>
                    </Student>
                </Students>";

            XDocument studentsXdoc = new XDocument();
            studentsXdoc = XDocument.Parse(studentsXML);

            var students = from student in studentsXdoc.Descendants("Student")
                           select new
                           {
                               Name = student.Element("Name").Value,
                               Age = student.Element("Age").Value,
                               University = student.Element("University").Value,
                               Semester = student.Element("Semester").Value
                           };
            foreach (var student in students)
            {
                Console.WriteLine("Student {0} with age {1} from University {2} is in his/her Semester {3}", student.Name, student.Age , student.University, student.Semester);
            }
            
            var sortedStudents = from student in students
                                 orderby student.Age
                                 select student;

            foreach (var student in sortedStudents)
            {
                Console.WriteLine("Student {0} with age {1} from University {2} is in his/her Semester {3}", student.Name, student.Age, student.University, student.Semester);
            }
            Console.ReadLine();
        }
    }
}
