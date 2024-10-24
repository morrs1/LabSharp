using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Interfaces
{
    internal interface IInnerBus
    {
        public double MaxTransferSpeedInnerBus { get; }
        public void TransferDataInner();
    }
}
