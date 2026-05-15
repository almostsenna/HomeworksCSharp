//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace HomeworksCSharp.Interfaces.IRemoteControl
//{
//    public class Television : Device
//    {
//        public Television(string name) : base(name) { }

//        public override void TurnOn()
//        {
//            IsOn = true;
//            Console.WriteLine($"{Name} TV is now ON.");
//        }

//        public override void TurnOff()
//        {
//            IsOn = false;
//            Console.WriteLine($"{Name} TV is now OFF.");
//        }

//        public override void SetChannel(int channel)
//        {
//            if (IsOn)
//            {
//                CurrentChannel = channel;
//                Console.WriteLine($"{Name} TV switched to channel {channel}.");
//            }
//            else
//            {
//                Console.WriteLine($"{Name} TV is OFF. Cannot change channel.");
//            }
//        }
//    }
//}
