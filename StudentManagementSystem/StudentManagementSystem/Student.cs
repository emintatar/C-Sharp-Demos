using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    public class Student
    {
        private int studentId;
        private string firstName;
        private string lastName;
        private int firstExam;
        private int secondExam;
        private int finalExam;
        private string universityName;

        public Student(int studentId, string firstName, string lastName, int firstExam, int secondExam, int finalExam, string universityName)
        {
            this.studentId = studentId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.firstExam = firstExam;
            this.secondExam = secondExam;
            this.finalExam = finalExam;
            this.universityName = universityName;

        }

        public void showStudentInfos()
        {
            Console.WriteLine("Student ID: " + studentId);
            Console.WriteLine("Student Fullname: " + firstName + " " + lastName);
            Console.WriteLine("First Exam: " + firstExam);
            Console.WriteLine("Second Exam: " + secondExam);
            Console.WriteLine("Final Exam: " + finalExam);
            Console.WriteLine("University Name: " + universityName);
        }

        public void showUniversity()
        {
            Console.WriteLine("University Name: " + universityName);
        }

        public double showGpa()
        {
            double gpa = firstExam * 0.2 + secondExam * 0.2 + finalExam * 0.6;
            return gpa;
        }
    }
}
