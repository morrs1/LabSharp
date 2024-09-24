using System;
using System.Collections.Generic;

// Базовый класс для всей компьютерной техники
public class ComputerEquipment
{
    public string Name { get; private set; }

    public ComputerEquipment(string name)
    {
        Name = name;
    }

    // Виртуальный метод для отображения информации
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Устройство: {Name}");
    }
}

// Класс для компьютеров
public class Computer : ComputerEquipment
{
    public Motherboard Motherboard { get; private set; }
    public Processor Processor { get; private set; }
    public StorageDevice StorageDevice { get; private set; }

    public Computer(string name, Motherboard motherboard, Processor processor, StorageDevice storageDevice)
        : base(name)
    {
        Motherboard = motherboard;
        Processor = processor;
        StorageDevice = storageDevice;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Материнская плата: {Motherboard.Name}");
        Console.WriteLine($"Процессор: {Processor.Name}");
        Console.WriteLine($"Запоминающее устройство: {StorageDevice.Name}");
        StorageDevice.GetReadSpeed();
    }
}

// Класс для принтеров
public class Printer : ComputerEquipment
{
    public Printer(string name) : base(name) { }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Принтер: {Name}");
    }
}

// Класс для мониторов
public class Monitor : ComputerEquipment
{
    public Monitor(string name) : base(name) { }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Монитор: {Name}");
    }
}

// Класс для клавиатур
public class Keyboard : ComputerEquipment
{
    public Keyboard(string name) : base(name) { }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Клавиатура: {Name}");
    }
}

// Базовый класс для запоминающих устройств
public class StorageDevice : ComputerEquipment
{
    public StorageDevice(string name) : base(name) { }
    public virtual void GetReadSpeed()
    {

    }
}

// Класс для материнских плат
public class Motherboard : ComputerEquipment
{
    public Int32 GPU;
    public Motherboard(string name, Int32 GPU) : base(name) 
    {
    this.GPU = GPU;
    }

   
}

// Класс для процессоров
public class Processor : ComputerEquipment
{
    public Processor(string name) : base(name) { }
}

// Класс для жестких дисков
public class HardDisk : StorageDevice
{
    public HardDisk(string name) : base(name) { }
    public override void GetReadSpeed()
    {
        Console.WriteLine("Скорость чтения 2500 мб/с");
    }
}

// Класс для съемных дисков
public class RemovableDisk : StorageDevice
{
    public RemovableDisk(string name) : base(name) { }
    public override void GetReadSpeed()
    {
        Console.WriteLine("Скорость чтения 500 мб/с");
    }
}

// Класс для аудиоколонок
public class AudioSpeakers : ComputerEquipment
{
    public AudioSpeakers(string name) : base(name) { }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Аудиоколонки: {Name}");
    }
}

public class Vanamas
{
    public static void check(Motherboard motherboard)
    {
        if(motherboard.GPU < 4090)
        {
            Console.WriteLine("Глаза вытекли");
        }
    }
} 

