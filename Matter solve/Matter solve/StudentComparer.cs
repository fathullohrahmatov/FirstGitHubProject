using Matter_solve.Student;
using System.Diagnostics.CodeAnalysis;

namespace maxMin
{
    public class StudentComparer : IEqualityComparer<Students>
    {
        public bool Equals(Students? x, Students? y)
        {
           if (x.StudentID == y.StudentID && x.StudentName.ToLower() == y.StudentName.ToLower()) 
                return true;
           return false;
        }

        public int GetHashCode( Students obj)
        {
            return obj.StudentID.GetHashCode();
        }
    }
}