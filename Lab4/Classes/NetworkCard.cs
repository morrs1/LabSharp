using Lab4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Classes
{
    internal class NetworkCard : INetWork
    {
        public double MaxTransferSpeedNetWork { get; } = 5000;

        public delegate void TransferDataDelegate();
        public event TransferDataDelegate TransferDataNetWorkEvent;

        public void TransferDataNetWork()
        {
            TransferDataNetWorkEvent?.Invoke();
        }

        public NetworkCard()
        {
            TransferDataNetWorkEvent += () => Console.WriteLine($"Передаю информацию по сети со скоростью:{MaxTransferSpeedNetWork}");
        }
    }
}
