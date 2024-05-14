using System;

namespace CollegeSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            TestConstructor();
            TestGettersAndSetters();
            TestToStringMethod();
            // TestErrorHandling();
        }

        static void TestConstructor()
        {
            Console.WriteLine("Testing Constructor:");
            Professor professor = new Professor("L12345", "John", "Doe", "Mathematics");

            Console.WriteLine("Expecting: Professor created: Professor John Doe, Department: Mathematics, Lnumber: L12345");
            Console.WriteLine($"Result: Professor created: {professor}\n");
        }

        static void TestGettersAndSetters()
        {
            Console.WriteLine("Testing Getters and Setters:");
            Professor professor = new Professor("L12345", "John", "Doe", "Mathematics");

            Console.WriteLine($"Original Professor: {professor}");

            // Test setters
            professor.Lnumber = "L54321";
            professor.FirstName = "Lindy";
            professor.LastName = "Stewart";
            professor.Department = "Computer Science";

            // Test getters
            Console.WriteLine("Expecting:");
            Console.WriteLine("Updated Lnumber: L54321");
            Console.WriteLine("Updated First Name: Lindy");
            Console.WriteLine("Updated Last Name: stewart");
            Console.WriteLine("Updated Department: Computer Science");
            Console.WriteLine($"Result:");
            Console.WriteLine($"Updated Lnumber: {professor.Lnumber}");
            Console.WriteLine($"Updated First Name: {professor.FirstName}");
            Console.WriteLine($"Updated Last Name: {professor.LastName}");
            Console.WriteLine($"Updated Department: {professor.Department}\n");
        }

        static void TestToStringMethod()
        {
            Console.WriteLine("Testing ToString Method:");
            Professor professor = new Professor("L12345", "John", "Doe", "Computer Science");

            Console.WriteLine("Expecting: Professor: John Doe, Department: Computer Science, Lnumber: L12345");
            Console.WriteLine($"Result: {professor}\n");
        }

        static void TestErrorHandling()
        {
            Console.WriteLine("Testing Error Handling:");
            // This will throw an exception due to invalid Lnumber
            Professor invalidProfessor = new Professor("", "Lindy", "Stewart", "Computer Science");
        }
    }
}
