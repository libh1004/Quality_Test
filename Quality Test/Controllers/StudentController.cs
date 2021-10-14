using System;
using System.Collections.Generic;
using Quality_Test.Models;

namespace Quality_Test.Controllers
{
    public class StudentController
    {
        public void PrintListStudent(List<Student> students)
        {
            Console.WriteLine("List student: ");
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
            Console.WriteLine(student);
            return null;
        } 
        
    }
}