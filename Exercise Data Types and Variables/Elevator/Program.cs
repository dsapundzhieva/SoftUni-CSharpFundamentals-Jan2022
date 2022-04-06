using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int courses = numberOfPeople / capacity;
            bool addCourses = numberOfPeople % capacity != 0;
            //courses = numberOfPeople % capacity == 0 ? courses : courses+1;
            if (addCourses)
            {
                courses++;
            }
            Console.WriteLine(courses);
        }
    }
}
