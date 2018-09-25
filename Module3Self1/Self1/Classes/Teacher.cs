using System;

namespace Self1
{
    public class Teacher : Person
    {
        public static int Increment = 0;

        public Teacher(string name) : base(name)
        {
            Increment++;
        }

        public static int CountTeacher()
        {
            return Increment;
        }
    }
}