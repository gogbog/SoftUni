using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Average_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var studentData = new List<KeyValuePair<string,double>>();
             

            for (int i = 0; i < n; i++)
            {
                string[] inputedInfo = Console.ReadLine().Split();
                Student student = new Student();

                student.name = inputedInfo[0];

                for (int k = 1; k < inputedInfo.Length; k++)
                {
                    student.addGrade(double.Parse(inputedInfo[k]));
                }

                studentData.Add(new KeyValuePair<string, double>(student.name, student.getAvr()));
                
            }

            var studentList = studentData.Where(x => x.Value >= 5).OrderBy(x => x.Key).ThenByDescending(x => x.Value).ToList();

            foreach (var item in studentList)
            {

                Console.WriteLine("{0} -> {1:F2}", item.Key, item.Value);
            }
        }
    }

    class Student
    {
        public string name { get; set; }
        public List<double> gradesList = new List<double>();
        
        public void addGrade(double num)
        {
            gradesList.Add(num);
        }

        public double getAvr()
        {
            return gradesList.Average();
        }
    }
}
