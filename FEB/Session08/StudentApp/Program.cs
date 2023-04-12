﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentApp.Model;

namespace StudentApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
            CaseStudy4();
            CaseStudy5();
            CaseStudy3();
        }
        private static void CaseStudy1()
        {
            Student student1 = new Student("Vikr", 12, 8.7f);
            PrintDetails(student1, "1.Details of Student 1");
        }
        private static void CaseStudy2()
        {
            Student student2 = new Student("Vikrant", 12, 5.9f, 0f);
            PrintDetails(student2, "2.Details of student 2");
        }
        private static void CaseStudy3()
        {
            Student student1 = new Student("Vikr", 12, 11f);
            PrintDetails(student1, "3.Details of Student 1 after giving invalid cgpa");
        }
        private static void CaseStudy4()
        {
            Student student2 = new Student("Vikrant", 12, 5.9f, 0f);
            student2.RollNo = 45;
            PrintDetails(student2, "4.Details of student 2 after changing roll number");
        }
        private static void CaseStudy5()
        {
            Student student2 = new Student("Vikrant", 12, 5.9f, 0f);
            student2.Cgpa = 9.8f;
            PrintDetails(student2, "5.Details of student 2 after changing their cgpa");
        }
        public static void PrintDetails(Student student, string message)
        {
            Console.WriteLine(message);
            Console.WriteLine($"Name of the Student :{student.Name}");
            Console.WriteLine($"Students Roll number :{student.RollNo}");
            Console.WriteLine($"Students CGPA :{student.Cgpa}");
            Console.WriteLine($"Students Percentage :{student.Percentage}\n");
        }
    }
}



