using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworksCSharp.Inheritance.Task5
{

    public class Course
    {
        public string Name { get; set; }
        public int Duration { get; set; } // Duration in hours

        public Course(string name, int duration)
        {
            Name = name;
            Duration = duration;
        }

        public override string ToString()
        {
            return $"Course: {Name}, Duration: {Duration} hours";
        }
    }

    public class OnlineCourse : Course
    {
        public string Platform { get; set; }

        public OnlineCourse(string name, int duration, string platform)
            : base(name, duration)
        {
            Platform = platform;
        }

        public override string ToString()
        {
            return $"Online Course: {Name}, Duration: {Duration} hours, Platform: {Platform}";
        }
    }
}