using Lab4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Classes
{
    internal class KeyBoard : IUsbBus
    {
        public double MaxTransferSpeedUsb { get; } = 500;

        public delegate void TransferDataDelegate();
        public event TransferDataDelegate TransferDataUsbEvent;

        public void TransferDataUsb()
        {
            TransferDataUsbEvent?.Invoke();
        }

        public KeyBoard()
        {
            TransferDataUsbEvent += () => Console.WriteLine($"Передаю информацию по USB со скоростью:{MaxTransferSpeedUsb}");
        }
    }
}