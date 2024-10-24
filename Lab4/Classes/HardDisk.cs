using Lab4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Classes
{
    internal class HardDisk : ISata, IMileage
    {
        private double mileage = 2222;
        public double MaxTransferSpeedSata { get; } = 1000;

        public double GetMileage() => mileage;

        public delegate void TransferDataDelegate();
        public event TransferDataDelegate TransferDataSataEvent;

        public void TransferDataSata()
        {
            TransferDataSataEvent?.Invoke();
        }

        public HardDisk()
        {
            TransferDataSataEvent += () => Console.WriteLine($"Передаю информацию по SATA со скоростью:{MaxTransferSpeedSata}");
        }
    }
}


