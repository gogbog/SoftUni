using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Groups
{
    class Program
    {
        public static object Cultureinfo { get; private set; }

        static void Main(string[] args)
        {
            List<Town> result = ReadTownsAndStudents();
            List<Group> groups = DestriubteStudentsIntoGroups(result);


            //Created 8 groups in 3 towns:
            Console.WriteLine($"Created {groups.Count} groups in {result.Count} towns:");

            foreach (var group in groups.OrderBy(x => x.Town.Name))
            {
                Console.Write($"{group.Town.Name} => ");

                foreach (var student in group.Students)
                {
                    if (student != group.Students[group.Students.Count - 1])
                    {
                        Console.Write($"{student.Email}, ");
                    }
                    else
                    {
                        Console.Write($"{student.Email}");
                    }
                }
                Console.WriteLine();
            }
           
        }

        private static List<Group> DestriubteStudentsIntoGroups(List<Town> towns)
        {
            List<Group> groups = new List<Group>();
            

            foreach (var town in towns)
            {
                List<Student> students = town.Students;

                students = town.Students
                    .OrderBy(x => x.RegistrationDate)
                    .ThenBy(x => x.Name)
                    .ThenBy(x => x.Email)
                    .ToList();

                while (students.Any())
                {
                    Group group = new Group();

                    group.Town = town;
                    group.Students = students.Take(town.SeatsCount).ToList();
                    students = students.Skip(town.SeatsCount).ToList();

                    groups.Add(group);

                }
            }

            return groups;
        }

        static List<Town> ReadTownsAndStudents()
        {
            var towns = new List<Town>();
            string inputedInfo = Console.ReadLine();

            while (!inputedInfo.Equals("End"))
            {
                if (inputedInfo.Contains("=>"))
                {
                    //Town1 => X seats
                    string[] townInfo = inputedInfo.Split(new string[] { "=>" }, StringSplitOptions.None);
                    string townName = townInfo[0].Trim();
                    string[] seats  = townInfo[1].Trim().Split();
                    

                    Town town = new Town();
                    town.Name = townName;
                    town.SeatsCount = int.Parse(seats[0]);
                    town.Students = new List<Student>();
                    towns.Add(town);
                }
                else
                {
                    //Student1 Name | student1_email@somewhere.com | day-month-year

                    Student student = new Student();

                    string[] studentInfo = inputedInfo.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                    string studentName = studentInfo[0].Trim();
                    string studentEmail = studentInfo[1].Trim();
                    DateTime studentDate = DateTime.ParseExact(studentInfo[2].Trim(), "d-MMM-yyyy", CultureInfo.InvariantCulture);

                    student.Name = studentName;
                    student.Email = studentEmail;
                    student.RegistrationDate = studentDate;

                    var lastInsertedTown = towns[towns.Count - 1];
                    lastInsertedTown.Students.Add(student);
                    
                }

                inputedInfo = Console.ReadLine();
            }

            return towns;
        }
    }

    class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { set; get; }
    }

    class Town
    {
        public string Name { get; set; }
        public int SeatsCount { get; set; }
        public List<Student> Students { get; set; }
    }

    class Group
    {
        public Town Town { get; set; }
        public List<Student> Students { get; set; }
    }
}
