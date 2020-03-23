using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    public interface ITeacher
    {

        string Department { get; set; }
        int Hours { get; set; }
        List<Subject> TeacherSubjects { get; set; }

        void TeachSubject();
        void CorrectExam();
        void CorrectPractice();

    }
}
