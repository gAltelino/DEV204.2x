using System;

namespace Self1
{
    public class Student
    {
        private static int Increment = 0;
        string Name { get; set; }

        public Student(string name)
        {
            this.Name = name;
            Increment++;
        }

        public static int CountStudents()
        {
            return Increment;
        }

        public string StudentName(){
            return this.Name;
        }

    }
}