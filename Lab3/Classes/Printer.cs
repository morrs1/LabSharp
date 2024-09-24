using Lab3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Classes
{
    internal class Printer : IUsbBus, INetWork
    {
        public double MaxTransferSpeedNetWork { get; } = 1000;

        public double MaxTransferSpeedUsb { get; } = 500;

        public void TransferDataNetWork()
        {
            Console.WriteLine($"Передаю информацию по сети со скоростью:{MaxTransferSpeedNetWork}");
        }

        public void TransferDataUsb()
        {
            Console.WriteLine($"Передаю информацию по USB со скоростью:{MaxTransferSpeedUsb}");
        }
    }
}
