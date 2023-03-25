using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = Enums.GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if(Students.Count < 5)
            {
                throw new InvalidOperationException();
            }
            int licznik = 0;
            

            for (int i = 0; i < Students.Count; i++)
            {
                if (Students[i].AverageGrade > averageGrade)
                {
                    licznik++;
                }

            }

            double procent_uczniow = (double)licznik / Students.Count * 100;

            if (procent_uczniow <20)
                return 'A';
            else if (procent_uczniow < 40)
                return 'B';
            else if (procent_uczniow < 60)
                return 'C';
            else if (procent_uczniow < 80)
                return 'D';
            else
                return 'F';
        }

    }
}
