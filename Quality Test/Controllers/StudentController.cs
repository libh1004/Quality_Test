using System;
using System.Collections.Generic;
using System.Linq;
using Quality_Test.Models;

namespace Quality_Test.Controllers
{
    public class StudentController
    {
        public void PrintListStudent(List<Student> students)
        {
            Console.WriteLine("List student: ");
            Console.WriteLine($"{"RollNumber",-5} {"|",5} {"FullName",18} {"|",5} {"Birthday",18} {"|",5} {"Email",10} {"|",5} {"Phone",8} {"|",5} {"CreatedAt",15} {"|",5} {"Status",5}");
            Console.WriteLine("=======================================================================================================================================");
            foreach (var student in students)
            {
                Console.WriteLine(student.ToString());
            }
        }

        public Student CreateStudent()
        {
            Console.WriteLine("Enter student's information");
            Console.WriteLine("Enter roll number: ");
            var rollNumber = Console.ReadLine();
            Console.WriteLine("Enter full name: ");
            var fullName = Console.ReadLine();
            Console.WriteLine("Enter birthday: ");
            var birthday = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter email: ");
            var email = Console.ReadLine();
            Console.WriteLine("Enter phone: ");
            var phone = Console.ReadLine();
            Console.WriteLine("Enter status: ");
            var status = (Program.StudentStatus) int.Parse(Console.ReadLine());
            
            var student = new Student()
            {
                RollNumber = rollNumber,
                FullName = fullName,
                Birthday = birthday,
                Email = email,
                Phone = phone,
                CreatedAt = DateTime.Now,
                Status = status
            };
            return student;
        }

        public void DeleteStudent(List<Student> students)
        {
            Console.WriteLine("Please enter Roll number want to delete: ");
            var optionRollNumber = Console.ReadLine();
            foreach (var student in students.ToList())
            {
                if (optionRollNumber == student.RollNumber)
                {
                    students.Remove(student);
                    Console.WriteLine("Delete student successfully.");
                }
            }
            
        }

        public void EditStudent(List<Student> students)
        {
            Console.WriteLine("Please enter roll number want to edit: ");
            var optionRollNumber = Console.ReadLine();
            foreach (var student in students.ToList())
            {
                if (optionRollNumber == student.RollNumber)
                {
                    Console.WriteLine(student);
                   
                    Console.WriteLine("Enter roll number: ");
                    var rollNumber = Console.ReadLine();
                    Console.WriteLine("Enter fullname: ");
                    var fullName = Console.ReadLine();
                    Console.WriteLine("Enter birthday: ");
                    var birthday = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Enter email: ");
                    var email = Console.ReadLine();
                    Console.WriteLine("Enter phone: ");
                    var phone = Console.ReadLine();
                    Console.WriteLine("Enter status: ");
                    var status = (Program.StudentStatus) int.Parse(Console.ReadLine());
                    
                    var studentNew = new Student()
                    {
                        RollNumber = rollNumber,
                        FullName = fullName,
                        Birthday = birthday,
                        Email = email,
                        Phone = phone,
                        CreatedAt = DateTime.Now,
                        Status = status
                    };
                    students.Remove(student);
                    students.Add(studentNew);
                }
            }
        }
    }
}