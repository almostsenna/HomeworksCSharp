//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace HomeworksCSharp.Inheritance.Task2
//{
//    public class Device
//    {
//        protected string Name;
//        protected string Characteristics;

//        public Device(string name, string characteristics)
//        {
//            Name = name;
//            Characteristics = characteristics;
//        }

//        public virtual void Sound()
//        {
//            Console.WriteLine("Generic device sound.");
//        }

//        public virtual void Show()
//        {
//            Console.WriteLine("Device name: " + Name);
//        }

//        public virtual void Desc()
//        {
//            Console.WriteLine("Description: " + Characteristics);
//        }
//    }

   
//    public class Kettle : Device
//    {
//        public Kettle(string name, string characteristics) : base(name, characteristics) { }

//        public override void Sound()
//        {
//            Console.WriteLine("Kettle sound: Whistle...");
//        }

//        public override void Show()
//        {
//            Console.WriteLine("Device name: " + Name + " (Kettle)");
//        }
//    }

//    public class Microwave : Device
//    {
//        public Microwave(string name, string characteristics) : base(name, characteristics) { }

//        public override void Sound()
//        {
//            Console.WriteLine("Microwave sound: Beep beep...");
//        }

//        public override void Show()
//        {
//            Console.WriteLine("Device name: " + Name + " (Microwave)");
//        }
//    }

//    public class Car : Device
//    {
//        public Car(string name, string characteristics) : base(name, characteristics) { }

//        public override void Sound()
//        {
//            Console.WriteLine("Car sound: Vroom vroom...");
//        }

//        public override void Show()
//        {
//            Console.WriteLine("Device name: " + Name + " (Car)");
//        }
//    }

//    public class Steamboat : Device
//    {
//        public Steamboat(string name, string characteristics) : base(name, characteristics) { }

//        public override void Sound()
//        {
//            Console.WriteLine("Steamboat sound: Toot toot...");
//        }

//        public override void Show()
//        {
//            Console.WriteLine("Device name: " + Name + " (Steamboat)");
//        }
//    }
//}
