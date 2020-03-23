using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    public class Student : Person, IStudent
    {

        public string Course { get; set; }
        public int Hours { get; set; }
        public List<Subject> StudentSubjects { get; set; }

        public Student()
        {

        }

        public Student(string Course, int Hours, List<Subject> StudentSubjects)
        {
            this.Course = Course;
            this.Hours = Hours;
            this.StudentSubjects = StudentSubjects;
        }

        public void StudySubject()
        {

        }

        public void DoExam()
        {

        }

        public void DoPractice()
        {

        }

    }
}
