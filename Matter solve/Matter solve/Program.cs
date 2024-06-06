using Matter_solve;
using Matter_solve.Model;
using Matter_solve.Student;
using System.Collections;
/*
namespace Matter_solve
{
    public class Program
    {
        static void Main()
        {/*
            int n = 0, m = 10, count = 0;

            for (int i = n; i <= m; i++)
            {
                Console.Write(i + " ,");
                if (i % 2 != 0) count++;
            }
            Console.WriteLine("\ntoq sonlar: " + count);


            Random random = new Random();

            int[] array = new int[15];

            for (int i = 0; i < 15; i++)
            {
                array[i] = random.Next(-1000, 100000);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i > 15; i++)
            {
                if (array[i] > 0)
                {
                    Console.Write(array[i] + " ");
                }
            }

            List<Students> students = new List<Students>()
            {
                new Students() { Id = 1, Name = "Nodirbek", Resault = 30 },
                new Students() { Id = 2, Name = "Jasurbek", Resault = 25 },
                new Students() { Id = 3, Name = "Abdulla", Resault = 19}
            };
            var Passed = from std in students
                         orderby std.Resault descending
                         where std.Resault >= 20
                         select std.Name;
            foreach (var item in Passed)
            {
                Console.WriteLine(item);
            }

            List<Employee> employees = new List<Employee>()
            {
                new Employee() { Id = 1, LastName = "Abdulla", FirstName = "Qodiriy"},
                new Employee() { Id = 2, FirstName = "Umarxon", LastName = "Sobirov"},
                new Employee() { Id = 3,FirstName  = "Diyorbek", LastName = "Olimjonov"}
            };
            var QuerySyntax = from emp in employees
                              orderby emp.LastName,
                              emp.FirstName
                              select emp;
            foreach (var emp in QuerySyntax)
            {
                Console.WriteLine($" {emp.Id} {emp.LastName} {emp.FirstName}");
            }

            Console.WriteLine("=====================");

            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var MethodSyntax = numbers.Reverse<int>();
            foreach (var num in MethodSyntax)
            {
                Console.WriteLine(num);
            }




            Console.WriteLine("==============");

            List<int> number = new List<int>() { 1, 2, 7, 9, };

            Console.WriteLine("Boshlang'ich elementlar");
            foreach (var i in number)
            {
                Console.WriteLine(i + " ");
            }

            bool bor = number.Contains(7);
            Console.WriteLine("\nBirorta juft element bor yoki yoqligi tekshiramiz:");

            if (bor)
            {
                Console.WriteLine("Bor");
            }
            else
            {
                Console.WriteLine("Yoq");
            }
            Console.ReadKey();

            IList<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, };
            var maxElement = list.Max();
            Console.WriteLine("Maksimum Element: {0}", maxElement);

            var maxElement1 = list.Max(l =>
            {
                if (1 % 2 == 0)
                    return 1;
                return 0;
            });


            Console.WriteLine("Shartni qanoatlantirgan Maksimum Element: {0}", maxElement1);

            Console.ReadLine(); */

namespace maxMin
{
    class Program
   {
        static void Main()
        {
            IList<Students> studentList = new List<Students>()
            {

                new Students() { StudentID = 1, StudentName = "Jasur", Age = 26 } ,
                new Students() { StudentID = 2, StudentName = "Muhammad", Age = 16 } ,
                new Students() { StudentID = 3, StudentName = "Temurxon", Age = 16 } ,
                new Students() { StudentID = 4, StudentName = "Toxirxon", Age = 27 } ,
                new Students() { StudentID = 5, StudentName = "umarbek", Age = 23 } ,
                new Students() { StudentID = 6, StudentName = "MuhammadKarim", Age = 24 }

            };

            var maxAge = studentList.Max(s => s.Age);
            Console.WriteLine("Maksimal yoshli o'quvchi yoshi: {0}", maxAge);
            var maxValue = studentList.Max();
            Console.WriteLine("Ismi eng uzun o'quvchi: {0}", maxValue.StudentName);

            int[] sonlar = new int[] { 1, 2, 6, 5, 43, 37, 6, 91, 26, 77 };
            var takrorlanganSonlar = sonlar.Where(e => e < 50).Distinct();
            foreach (var item in takrorlanganSonlar)
            {
                Console.WriteLine(item + " ");
            }
            Console.ReadKey();

            Talaba[] Talabalar = { new Talaba { Name = "Ali", Weight = 50 } };
            new Talaba { Name = "Vali", Weight = 61 };
            new Talaba { Name = "Salim", Weight = 53 };
            new Talaba { Name = "Ali", Weight = 50 };
            new Talaba { Name = "Vali", Weight = 58 };

            var takrorlanmasToplam =
                Talabalar.Distinct();

            foreach (var talaba in takrorlanmasToplam)
                Console.WriteLine(talaba.Name + " " + talaba.Weight);

            Console.ReadKey();

            Car[] cars1 =
            {
                new Car{ Id = 1, Name ="RollsRoyse"},
                new Car{ Id = 2, Name = "BMW"},
                new Car{ Id = 3, Name = "Mersedez-Benz"}
            };

            Car[] cars2 =
            {
                new Car { Id = 1, Name = "Gentra" },
                new Car { Id = 2, Name = "BMW"}
            };
            IEnumerable<Car> result = cars1.Except(cars2, new CarComparer());

            foreach (var item in result)
                Console.WriteLine(item.Id +" " + item.Name);

            Console.ReadKey();

            int[] A = { 1, 2, 5, 13, 4, 7, 9, 11};
            int[] B = { 1, 0, 2, 5, 7, 8, 9, 10, 11 };
            int[] C = A.Intersect(B).ToArray();
            foreach (int item in C)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

            Console.WriteLine("=========");

            IList<Students> studentList1 = new List<Students>();
            {
                new Students() { StudentID = 1, StudentName = "John", Age = 18 };
                new Students() { StudentID = 2, StudentName = "Steve", Age = 21 };
                new Students() { StudentID = 3, StudentName = "Bill", Age = 19 };
                new Students() { StudentID = 5, StudentName = "Ron", Age = 15 };
            }

            IList<Students> studentList2 = new List<Students>();
            {
                new Students() { StudentID = 3, StudentName = "Bill", Age = 19 };
                new Students() { StudentID = 5, StudentName = "Ron", Age = 15 };
            }

            var resultedCol = studentList1.Union(studentList2, new StudentComparer());

            foreach (Students std in resultedCol)
                Console.WriteLine(std.StudentName);

            Console.ReadLine();

            List<int> sonlar1 = new List<int>() { 1, 2, 3, 4, 6, 7, 8, 9, 10, };

            List<int> yangisonlar1 = sonlar1.Take(7).ToList();

            Console.WriteLine("Boshlang'ich elementlar:");
            foreach(var i in sonlar)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\nAjratib olingan elementlar:");
            foreach (var i in yangisonlar1)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();

            ArrayList dasturlash = new ArrayList();
            dasturlash.Add("C#");
            dasturlash.Add("C++");
            dasturlash.Add("C");
            dasturlash.Add("Go");
            dasturlash.Add("Python");

            foreach (var dastur in dasturlash)
            {
                 Console.Write($"{dastur}");
            }
            dasturlash.Sort();

            System.Console.WriteLine();
            for (var i = 0; i < dasturlash.Count; i++)
            {
                Console.Write(dasturlash[i] + " ");
            }

        }
   }
 }

    


