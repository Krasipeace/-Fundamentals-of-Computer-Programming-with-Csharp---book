﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Filter_Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            Console.WriteLine("Enter first last name and age (interval splitter), write end to stop adding students to the list: ");
            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string firstName = tokens[0];
                string lastName = tokens[1];
                int age = int.Parse(tokens[2]);

                Student student = new Student();
                {
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                }
                students.Add(student);
                command = Console.ReadLine();
            }

            List<Student> orderByFirstName = students.OrderByDescending(x => x.FirstName).ThenByDescending(y => y.LastName).ToList();

            Console.WriteLine("Descending Order of student names: ");
            foreach (Student student in orderByFirstName)
            {
                Console.WriteLine($"Name: {student.FirstName} {student.LastName} Age: {student.Age}");
            }
        }
    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}