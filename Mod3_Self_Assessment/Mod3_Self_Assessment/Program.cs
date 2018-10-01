using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3_Self_Assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            GetStudentInformation(out string studentFirstName, out string studentLastName, out DateTime studentBirthDate);
            try
            {
                BirthDateValidation();
            }
            catch (NotImplementedException notImp)
            {
                Console.WriteLine(notImp.Message);
            }
            PrintStudentDetails(studentFirstName, studentLastName, studentBirthDate);
            GetTeacherDetails(out string teacherFirstName, out string teacherLastName, out string teacherCourse);
            PrintTeacherDetails(teacherFirstName, teacherLastName, teacherCourse);
        }

        static void GetStudentInformation(out string studentFirstName, out string studentLastName, out DateTime studentBirthDate)
        {
            Console.WriteLine("Enter the student's first name: ");
            studentFirstName = Console.ReadLine();
            Console.WriteLine("Enter the student's last name: ");
            studentLastName = Console.ReadLine();

            // Code to finish getting the rest of the student data

            Console.WriteLine("Enter the student's birthdate using MM/DD/YYYY format: ");
            studentBirthDate = Convert.ToDateTime(Console.ReadLine());

            
        }

        static void GetTeacherDetails(out string teacherFirstName, out string teacherLastName, out string teacherCourse)
        {
            Console.WriteLine("Enter the teacher's first name: ");
            teacherFirstName = Console.ReadLine();
            Console.WriteLine("Enter the teacher's last name: ");
            teacherLastName = Console.ReadLine();
            Console.WriteLine("Enter the teacher's course: ");
            teacherCourse = Console.ReadLine();

        }


        static void PrintStudentDetails(string first, string last, DateTime birthday)
        {
            Console.WriteLine("{0} {1} was born on: {2}", first, last, birthday);
        }

        static void PrintTeacherDetails(string first, string last, string course)
        {
            Console.WriteLine("{0} {1} is teaching {2}", first, last, course);
        }

        static void BirthDateValidation()
        {
            // I's no's existy yet
            throw new NotImplementedException();
        }
    }
}
