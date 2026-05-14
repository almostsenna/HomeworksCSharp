using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworksCSharp.Interfaces.IRemoteControl
{
    public abstract class Device : IRemoteControl
    {
        public string Name { get; set; }
        protected bool IsOn { get; set; }
        protected int CurrentChannel { get; set; }

        public Device(string name)
        {
            Name = name;
            IsOn = false;
            CurrentChannel = 1;
        }

        public abstract void TurnOn();
        public abstract void TurnOff();
        public abstract void SetChannel(int channel);
    }
}
