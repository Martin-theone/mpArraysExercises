using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mp.arrays___exercises
{
    // Define the Student class
    class Student
    {
        // Properties for student's details
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Hometown { get; set; }

        // Constructor to initialize the student
        public Student(string firstName, string lastName, int age, string hometown)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Hometown = hometown;
        }

        // Static Run method to handle the program logic
        public static void Run()
        {
            // List to store student objects
            List<Student> students = new List<Student>();

            string input;
            Console.WriteLine("Enter student details (first name, last name, age, hometown), type 'end' to finish:");

            // Read student data until the "end" command
            while ((input = Console.ReadLine()) != "end")
            {
                string[] studentData = input.Split();  // Split input by spaces

                // Make sure there are exactly 4 parts to the input
                if (studentData.Length == 4)
                {
                    string firstName = studentData[0];
                    string lastName = studentData[1];
                    int age = int.Parse(studentData[2]);
                    string hometown = studentData[3];

                    // Add the student to the list
                    students.Add(new Student(firstName, lastName, age, hometown));
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter exactly first name, last name, age, and hometown.");
                }
            }

            // Read city name to filter students by city
            Console.WriteLine("Enter city to filter students by:");
            string city = Console.ReadLine();

            // Print students from the given city
            foreach (var student in students)
            {
                if (student.Hometown == city)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old");
                }
            }
        }
    }

    // Main class to start the application
    class Program1
    {
        static public void Run(string[] args)
        {
            // Call the Run method from the Student class
            Student.Run();
        }
    }
}