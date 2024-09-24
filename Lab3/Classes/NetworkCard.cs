using Lab3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Classes
{
    internal class NetworkCard : INetWork
    {
        public double MaxTransferSpeedNetWork { get; } = 5000;

        public void TransferDataNetWork()
        {
            Console.WriteLine($"Передаю информацию по сети со скоростью:{MaxTransferSpeedNetWork}");
        }

    }
}
