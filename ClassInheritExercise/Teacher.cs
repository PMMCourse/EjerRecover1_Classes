using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    public class Teacher : Person, ITeacher
    {

        public string Department { get; set; }
        public int Hours { get; set; }
        public List<Subject> TeacherSubjects { get; set; }

        public Teacher()
        {

        }

        public Teacher(string Department, int Hours, List<Subject> TeacherSubjects)
        {
            this.Department = Department;
            this.Hours = Hours;
            this.TeacherSubjects = TeacherSubjects;
        }

        public void TeachSubject()
        {

        }

        public void CorrectExam()
        {

        }

        public void CorrectPractice()
        {
            
        }

    }
}
