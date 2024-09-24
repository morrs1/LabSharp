using Lab3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Classes
{
    internal class MotherBoard : IInnerBus, INetWork, IUsbBus, ISata
    {
        public double MaxTransferSpeedNetWork { get; } = 3000;

        public double MaxTransferSpeedUsb { get; } = 1000;

        public double MaxTransferSpeedInnerBus { get; } = 1000;

        public double MaxTransferSpeedSata { get; } = 7000;

        public void TransferDataNetWork()
        {
            Console.WriteLine($"Передаю информацию по сети со скоростью:{MaxTransferSpeedNetWork}");
        }

        public void TransferDataUsb()
        {
            Console.WriteLine($"Передаю информацию по USB со скоростью:{MaxTransferSpeedUsb}");
        }


        public void TransferDataInner()
        {
            Console.WriteLine($"Передаю информацию по сети со скоростью:{MaxTransferSpeedNetWork}");
        }

        public void TransferDataSata()
        {
            Console.WriteLine($"Передаю информацию по USB со скоростью:{MaxTransferSpeedUsb}");
        }
    }
}
