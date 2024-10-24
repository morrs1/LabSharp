using Lab4.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Classes
{
    internal class MotherBoard : IInnerBus, INetWork, IUsbBus, ISata
    {
        public double MaxTransferSpeedNetWork { get; } = 3000;
        public double MaxTransferSpeedUsb { get; } = 1000;
        public double MaxTransferSpeedInnerBus { get; } = 1000;
        public double MaxTransferSpeedSata { get; } = 7000;

        public delegate void TransferDataDelegate();
        public event TransferDataDelegate TransferDataNetWorkEvent;
        public event TransferDataDelegate TransferDataUsbEvent;
        public event TransferDataDelegate TransferDataInnerEvent;
        public event TransferDataDelegate TransferDataSataEvent;

        public void TransferDataNetWork()
        {
            TransferDataNetWorkEvent?.Invoke();
        }

        public void TransferDataUsb()
        {
            TransferDataUsbEvent?.Invoke();
        }

        public void TransferDataInner()
        {
            TransferDataInnerEvent?.Invoke();
        }

        public void TransferDataSata()
        {
            TransferDataSataEvent?.Invoke();
        }

        public MotherBoard()
        {
            TransferDataNetWorkEvent += () => Console.WriteLine($"Передаю информацию по сети со скоростью:{MaxTransferSpeedNetWork}");
            TransferDataUsbEvent += () => Console.WriteLine($"Передаю информацию по USB со скоростью:{MaxTransferSpeedUsb}");
            TransferDataInnerEvent += () => Console.WriteLine($"Передаю информацию по внутренней шине со скоростью:{MaxTransferSpeedInnerBus}");
            TransferDataSataEvent += () => Console.WriteLine($"Передаю информацию по SATA со скоростью:{MaxTransferSpeedSata}");
        }
    }
}