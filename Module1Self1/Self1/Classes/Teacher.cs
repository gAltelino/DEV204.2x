using System;

namespace Self1
{
    public class Teacher
    {
        public static int Increment = 0;
        string Name { get; set; }

        public Teacher(string name)
        {
            this.Name = name;
            Increment++;
        }

        public static int CountTeacher()
        {
            return Increment;
        }

        public string TeacherName()
        {
            return this.Name;
        }

    }
}