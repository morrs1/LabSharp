using Lab3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Classes
{
    internal class HardDisk : ISata
    {
        public double MaxTransferSpeedSata { get; } = 1000;


        public void TransferDataSata()
        {
            Console.WriteLine($"Передаю информацию по USB со скоростью:{MaxTransferSpeedSata}");
        }
    }
}
