using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworksCSharp.Interfaces.IRemoteControl
{
    public interface IRemoteControl
    {
        void TurnOn();
        void TurnOff();
        void SetChannel(int channel);
    }
}

