using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matter_solve.Student
{
    public class Students : IComparable<Students>
    { 
        public int StudentID { get; set; } 

        public string StudentName  { get; set; }

        public int Age { get; set; }

        public int Resault {  get; set; }

        public int CompareTo(Students other)
        {
            if (this.StudentName.Length > other.StudentName.Length)
                return 1;

            return 0;
        }
    }
}
