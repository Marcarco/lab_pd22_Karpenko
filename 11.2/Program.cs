using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace __11_2
{

    static class Extension
    {
        public static List<Student> FindStudent(this List<Student> listSt)
        {

            StudentPredicateDelegate sDeleg1 = Student.Adult;
            StudentPredicateDelegate sDeleg2 = Student.Name;
            StudentPredicateDelegate sDeleg3 = Student.NameLength;

            List<Student> sortListSt = new List<Student>();
            for (int i = 0; i < listSt.Count; i++)
            {
                if (sDeleg1(listSt[i]) && sDeleg2(listSt[i]) && sDeleg3(listSt[i]))
                {
                    sortListSt.Add(listSt[i]);
                }
            }

            return sortListSt;
        }
        public static void GetInfo(this List<Student> sortListS)
        {
            int i = 0;
            foreach (Student uc in sortListS)
            {
                Console.WriteLine("Number: " + (++i));
                Console.WriteLine(uc);
                Console.WriteLine();
            }
        }

    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public static bool Adult(Student s)
        {
    
            if (s.Age >= 18)
                return true;
            else
                return false;
        }

        public static bool Name(Student s)
        {
            if (s.FirstName[0] == 'A')
                return true;
            else
                return false;
        }
        public static bool NameLength(Student s)
        {
            if (s.LastName.Length > 3)
                return true;
            else
                return false;
        }
        public override string ToString()
        {
            return "Name: " + FirstName + "\nLast name: " + LastName + "\nAge: " + Age;
        }

    }
    delegate bool StudentPredicateDelegate(Student st);
    class Program
    {

        static void Main(string[] args)
        {
            List<Student> listStud = new List<Student>();
            listStud.Add(new Student() { Age = 18, FirstName = "Mary", LastName = "Yurchenko" });
            listStud.Add(new Student() { Age = 19, FirstName = "Andrew", LastName = "Troelsen" });
            listStud.Add(new Student() { Age = 19, FirstName = "Anna", LastName = "Jeckson" });
            listStud.Add(new Student() { Age = 17, FirstName = "Donald", LastName = "Patterson" });
            listStud.Add(new Student() { Age = 19, FirstName = "Ric", LastName = "Troelsen" });
            listStud.Add(new Student() { Age = 20, FirstName = "Alex", LastName = "Smith" });
            listStud.Add(new Student() { Age = 17, FirstName = "Kate", LastName = "Wood" });
            listStud.Add(new Student() { Age = 19, FirstName = "Elle", LastName = "Clark" });
            listStud.Add(new Student() { Age = 18, FirstName = "Alla", LastName = "Ross" });
            listStud.Add(new Student() { Age = 22, FirstName = "Olga", LastName = "Verbutska" });


            List<Student> sortListS = listStud.FindStudent();

            sortListS.GetInfo();

            Console.ReadLine();
        }
    }
}
