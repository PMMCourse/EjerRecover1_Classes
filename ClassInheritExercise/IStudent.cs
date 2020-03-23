using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    public interface IStudent
    {

        string Course { get; set; }
        int Hours { get; set; }
        List<Subject> StudentSubjects { get; set; }

        void StudySubject();
        void DoExam();
        void DoPractice();

    }
}
