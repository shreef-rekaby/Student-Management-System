using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System
{

    public enum Department { IT, CS, IS, SE }
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Grade { get; set; }
        public Department Department { get; set; }
        public Address Address { get; set; }

        public Student() : this(0, "anonymous", 0, Department.CS, new Address())
        {
        }

        public Student(int id, string name, double grade, Department department, Address address)
        {
            this.Id = id;
            this.Name = name;
            this.Grade = grade;
            this.Department = department;
            this.Address = address;
        }

        public void DisplayStudentInfo()
        {
            Console.WriteLine($"ID: {this.Id}");
            Console.WriteLine($"Name: {this.Name}");
            Console.WriteLine($"Department: {this.Department}");
            Console.WriteLine($"Grade: {this.Grade}");
            Console.WriteLine($"Address: {this.Address}");
            Console.WriteLine("-----------------------------------");
        }
    }
}
