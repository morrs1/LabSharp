using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Interfaces
{
    internal interface IUsbBus
    {
        public double MaxTransferSpeedUsb { get; }
        public void TransferDataUsb();
    }
}
