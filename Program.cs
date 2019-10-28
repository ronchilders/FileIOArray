using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOArray
{
    class Program
    {
        static void Main(string[] args
        {
            string dataPath = @"Data\Students.txt";
            string[] students;

            //students = ReadAllStudent(dataPath);
            students = new string[3];
            students[0] = "Sue, McWatters, 34";
            students[1] = "Bill, Thompson, 23";
            students[2] = "Charlie, Velis, 22";

            WriteAllStudents(dataPath, students);

        }
        static string[] ReadAllStudent(string dataPath)
        {
            string[] students;

            students = File.ReadAllLines(dataPath);

            return students;
        }

        static void WriteAllStudents(string dataPath, string[] students)
        {
            File.WriteAllLines(dataPath, students);
        }

        static void DisplayAllStudents(string[] students)
        {
            Console.WriteLine();
            Console.WriteLine("All Students");
            Console.WriteLine();
            foreach (string student in students)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();

        }
    }
}
