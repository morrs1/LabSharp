using Lab3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Classes
{
    internal class RamMemory : IInnerBus
    {
        public double MaxTransferSpeedInnerBus { get; } = 10.000;

        public void TransferDataInner()
        {
            Console.WriteLine($"Передаю информацию по сети со скоростью:{MaxTransferSpeedInnerBus}");
        }

    }
}
