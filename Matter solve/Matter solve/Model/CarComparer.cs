using Matter_solve.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matter_solve
{
    public class CarComparer : IEqualityComparer<Car>
    {
        public bool Equals(Car x, Car y)
        {

            //Taqqoslangan objectlar bir xil ma'lumotlarga murojaat qilishini tekshirish.
            if (Object.ReferenceEquals(x, y)) return true;

            //Object larni null qiymatga tekshirish
            if (Object.ReferenceEquals(x, null) || Object.ReferenceEquals(y, null))
                return false;

            //Object larning xususiyatlarini taqqoslash
            return x.Id == y.Id && x.Name == y.Name;
        }

        public int GetHashCode(Car obj)
        {
            //Obyektni null qiymatga tekshirish
            if (Object.ReferenceEquals(obj, null)) return 0;

            //Obyektning Id xususiyati uchun HashCode ni hisoblash
            int hashCarId = obj.Id.GetHashCode();

            //Obyektning Name xususiyati uchun HashCode ni hisoblash
            int hashCarName = obj.Name == null ? 0 : obj.Name.GetHashCode();

            //Obyektning HashCode ni qaytarish 
            return hashCarName ^ hashCarId;
        }
    }
}
