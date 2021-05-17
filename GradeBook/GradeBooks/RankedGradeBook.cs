using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            List<Student> students = Students;

            students.OrderBy(s => s.AverageGrade);



            if (students.Count < 5)
                throw new Exception("Too few students to calculate");

            else
                return 'F';
        }

    }
}
