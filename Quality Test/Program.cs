using System;
using System.Collections.Generic;
using Quality_Test.Controllers;
using Quality_Test.Models;

namespace Quality_Test
{
    public class Program
    {
        public enum StudentStatus
        {
            Active = 1,
            Deactive = 0,
            Delected = 2
        }

        public static void Main(string[] args)
        {
           
            var s = new Student
            {
                RollNumber = "A01",
                FullName = "Nguyen Thi Linh",
                Birthday = DateTime.Parse("2002-04-10"),
                Email = "linh@gmail.com",
                Phone = "099834839",
                CreatedAt = DateTime.Now,
                Status = StudentStatus.Deactive,
            };
        // Console.WriteLine(s.ToString());
           /* if (s.IsNewStudent())
            {
                Console.WriteLine("This is new student");
            }
            else
            {
                Console.WriteLine("This is old student");
            }*/
           // Console.WriteLine(s.IsDeactive());
        
            void GenerateMenu()
            {
                var students = new List<Student>();
                var studentController = new StudentController();
                Console.WriteLine("Please option menu: ");
                Console.WriteLine("1. Create new student");
                Console.WriteLine("2. Show list student");
                var optionsMenu = Convert.ToInt32(Console.ReadLine());
                if (optionsMenu == 1)
                {
               
                    students.Add(studentController.CreateStudent());
                }else if (optionsMenu == 2)
                {
                    studentController.PrintListStudent(students);
                }
            }
            GenerateMenu();
            /**/
        }
    }
}