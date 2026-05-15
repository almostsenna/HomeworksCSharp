//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace HomeworksCSharp.Interfaces.IRemoteControl
//{
//    public class Radio : Device // яка ж класна штука це успадкування))
//    {
//        public Radio(string name) : base(name) { }

//        public override void TurnOn()
//        {
//            IsOn = true;
//            Console.WriteLine($"{Name} Radio is now ON.");
//        }

//        public override void TurnOff()
//        {
//            IsOn = false;
//            Console.WriteLine($"{Name} Radio is now OFF.");
//        }

//        public override void SetChannel(int channel)
//        {
//            if (IsOn)
//            {
//                CurrentChannel = channel;
//                Console.WriteLine($"{Name} Radio tuned to frequency {channel}.");
//            }
//            else
//            {
//                Console.WriteLine($"{Name} Radio is OFF. Cannot tune frequency.");
//            }
//        }
//    }
//}
