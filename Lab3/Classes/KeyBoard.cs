using Lab3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab3.Classes;

internal class KeyBoard : IUsbBus
{

    public double MaxTransferSpeedUsb { get; } = 500;

    public void TransferDataUsb()
    {
        Console.WriteLine($"Передаю информацию по USB со скоростью:{MaxTransferSpeedUsb}");
    }

}
