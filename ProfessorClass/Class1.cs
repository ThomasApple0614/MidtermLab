using System;

namespace CollegeSystem
{
    public class Professor
    {
        private string lnumber;
        private string firstName;
        private string lastName;
        private string department;

        // Constructor
        public Professor(string lnumber, string firstName, string lastName, string department)
        {
            Lnumber = lnumber;
            FirstName = firstName;
            LastName = lastName;
            Department = department;
        }

        // Properties
        public string Lnumber
        {
            get { return lnumber; }
            set { lnumber = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set {firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        // ToString Method
        public override string ToString()
        {
            return $"Professor {FirstName} {LastName}, Department: {Department}, Lnumber: {Lnumber}";
        }
    }
}
