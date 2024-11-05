using Lab4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Classes
{
    internal class RamMemory : IInnerBus
    {
        public Boolean IsBroken { get; set; } = false;
        public double MaxTransferSpeedInnerBus { get; } = 10000;

        public delegate void TransferDataDelegate();
        public event TransferDataDelegate TransferDataInnerEvent;

        public void TransferDataInner()
        {
            TransferDataInnerEvent?.Invoke();
        }

        public RamMemory()
        {
            TransferDataInnerEvent += () => Console.WriteLine($"Передаю информацию по внутренней шине со скоростью:{MaxTransferSpeedInnerBus}");
        }
    }
}