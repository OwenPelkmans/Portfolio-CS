using System;

namespace CreateClassesObjs
{
    public class Course
    {
        private string name;  // Private field for course name

        // Method to set the course name
        public void SetName(string name)
        {
            this.name = name;
        }

        // Method to get the course name
        public string GetName()
        {
            return name;
        }

        // Override ToString() to display the course name in ComboBox and ListBox
        public override string ToString()
        {
            return name;
        }
    }
}