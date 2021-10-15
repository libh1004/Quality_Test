using System;
using System.Threading.Channels;

namespace Quality_Test.Models
{
    public class Student
    {
        public string RollNumber { get; set; }
        public string FullName { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime CreatedAt { get; set; }
        public Program.StudentStatus Status { get; set; }

        public override string ToString()
        {
            Console.WriteLine($"{RollNumber, -10} {"|", 5} {FullName, 20} {"|" ,5} {Birthday, 22} {"|" ,0} {Email, 12} {"|" ,0} {Phone, 7} {"|" ,0} {CreatedAt, 12} {"|" ,0} {Status, 5}");
            return null;
        }

            public bool IsNewStudent()
            {
                return DateTime.Now.CompareTo(CreatedAt.AddMonths(2)) <= 0;
            }
    
            public bool IsDeactive()
            {
                return Status == Program.StudentStatus.Deactive;
            }
    }
}