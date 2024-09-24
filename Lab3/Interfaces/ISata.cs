using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Interfaces
{
    internal interface ISata
    {
        public double MaxTransferSpeedSata { get; }

        public void TransferDataSata();
    }
}
