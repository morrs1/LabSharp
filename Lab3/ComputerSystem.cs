using System;
using System.Collections.Generic;
using Lab3.Interfaces;

namespace Lab3
{
    internal class ComputerSystem
    {
        private List<object> components = [];

        public void AddComponent(object component)
        {
            components.Add(component);
        }

        public void ConnectComponents()
        {
            foreach (var component1 in components)
            {
                foreach (var component2 in components)
                {
                    if (component1 != component2)
                    {
                        if (component1 is IUsbBus usbBus1 && component2 is IUsbBus usbBus2)
                        {
                            Console.WriteLine($"Соединяю компоненты по шине USB с максимальной скоростью передачи данных: {Math.Min(usbBus1.MaxTransferSpeedUsb, usbBus2.MaxTransferSpeedUsb)}");
                        }
                        if (component1 is ISata sata1 && component2 is ISata sata2)
                        {
                            Console.WriteLine($"Соединяю компоненты по шине SATA с максимальной скоростью передачи данных: {Math.Min(sata1.MaxTransferSpeedSata, sata2.MaxTransferSpeedSata)}");
                        }
                        if (component1 is INetWork network1 && component2 is INetWork network2)
                        {
                            Console.WriteLine($"Соединяю компоненты по сети с максимальной скоростью передачи данных: {Math.Min(network1.MaxTransferSpeedNetWork, network2.MaxTransferSpeedNetWork)}");
                        }
                        if (component1 is IInnerBus innerBus1 && component2 is IInnerBus innerBus2)
                        {
                            Console.WriteLine($"Соединяю компоненты по внутренней шине с максимальной скоростью передачи данных: {Math.Min(innerBus1.MaxTransferSpeedInnerBus, innerBus2.MaxTransferSpeedInnerBus)}");
                        }
                    }
                }
            }
        }
    }
}

