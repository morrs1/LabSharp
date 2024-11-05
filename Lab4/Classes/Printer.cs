using Lab4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Classes
{
    internal class Printer : IUsbBus, INetWork
    {
        public Boolean IsBroken { get; set; } = false;
        public double MaxTransferSpeedNetWork { get; } = 1000;
        public double MaxTransferSpeedUsb { get; } = 500;

        public delegate void TransferDataDelegate();
        public event TransferDataDelegate TransferDataNetWorkEvent;
        public event TransferDataDelegate TransferDataUsbEvent;

        public void TransferDataNetWork()
        {
            TransferDataNetWorkEvent?.Invoke();
        }

        public void TransferDataUsb()
        {
            TransferDataUsbEvent?.Invoke();
        }

        public Printer()
        {
            TransferDataNetWorkEvent += () => Console.WriteLine($"Передаю информацию по сети со скоростью:{MaxTransferSpeedNetWork}");
            TransferDataUsbEvent += () => Console.WriteLine($"Передаю информацию по USB со скоростью:{MaxTransferSpeedUsb}");
        }
    }
}
