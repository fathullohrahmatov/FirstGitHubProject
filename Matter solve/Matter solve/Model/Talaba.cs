using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matter_solve.Model
{
    public class Talaba : IEquatable<Talaba>
    {
        public string Name { get; set; }

        public int Weight { get; set; }

        public bool Equals(Talaba talaba)
        {
            if (Object.ReferenceEquals( talaba,null)) return false;
            if (Object.ReferenceEquals( talaba,this)) return true;
            return Weight.Equals( talaba.Weight ) && Name.Equals( talaba.Name );
        }

        public override int GetHashCode()
        {
           int hashProductname = Name == null ? 0 : Name.GetHashCode();
            int hashProductCode = Weight.GetHashCode();
            return hashProductname ^ hashProductCode;
        }
    }
}
