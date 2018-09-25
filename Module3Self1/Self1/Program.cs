using System;

namespace Self1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            UProgram Technology = new UProgram("Technology");

            Student Student1 = new Student("S1");
            Student Student2 = new Student("S2");
            Student Student3 = new Student("S3");

            Student1.ReadDetails("file1.txt");
            Student1.WriteDetails("file1.txt");
            Student1.ReadDetails("file1.txt");

            Student1.Dispose();

            Course Course1 = new Course("Programming with C#");

            Teacher Teacher1 = new Teacher("T1");
            Teacher Teacher2 = new Teacher("T2");

            Course1.AddTeacher(Teacher1);
            Course1.AddAssistent(Teacher2);

            Course1.AddStudent(Student1);
            Course1.AddStudent(Student2);
            Course1.AddStudent(Student3);

            Degree Degree1 = new Degree("Bachelor");
            Degree1.AddCourse(Course1);

            Technology.AddDegree(Degree1);

            Console.WriteLine($"Teacher1 name: {Teacher1.PersonName()}");
            Console.WriteLine($"Teacher2 name: {Teacher2.PersonName()}");

            Console.WriteLine($"Student1 name: {Student1.PersonName()}");
            Console.WriteLine($"Student2 name: {Student2.PersonName()}");
            Console.WriteLine($"Student2 name: {Student3.PersonName()}");

            Console.WriteLine($"Program name: {Technology.Name()} and all the degrees it contains: {Technology.Degrees()}");

            Console.WriteLine($"Course name in Degree 1: {Degree1.AllCourses()}");

            Console.WriteLine($"Students in Course 1: {Course1.StudentCount()}");

        }
    }
}
