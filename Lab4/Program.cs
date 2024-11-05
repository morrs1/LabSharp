using Lab4;
using Lab4.Classes;
using Lab4.Interfaces;


var computerSystem = new ComputerSystem();

computerSystem.ComponentAdded += (component) =>
{
    if (component is HardDisk hardDisk && hardDisk.IsBroken)
    {
        Console.WriteLine("Жесткий диск не исправен.");
    }
    else if (component is KeyBoard keyboard && keyboard.IsBroken)
    {
        Console.WriteLine("Клавиатура не исправна.");
    }
    else if (component is MotherBoard motherBoard && motherBoard.IsBroken)
    {
        Console.WriteLine("Материнская плата не исправна.");
    }
    else if (component is NetworkCard networkCard && networkCard.IsBroken)
    {
        Console.WriteLine("Сетевая карта не исправна.");
    }
    else if (component is Printer printer && printer.IsBroken)
    {
        Console.WriteLine("Принтер не исправен.");
    }
    else if (component is RamMemory ramMemory && ramMemory.IsBroken)
    {
        Console.WriteLine("Оперативная память не исправна.");
    }
    else if (component is Scanner scanner && scanner.IsBroken)
    {
        Console.WriteLine("Сканер не исправен.");
    }
};

var scanner = new Scanner { IsBroken = true };
computerSystem.AddComponent(scanner);

var printer = new Printer { IsBroken = false };
computerSystem.AddComponent(printer);

var ramMemory = new RamMemory { IsBroken = true };
computerSystem.AddComponent(ramMemory);

var networkCard = new NetworkCard { IsBroken = false };
computerSystem.AddComponent(networkCard);

var motherBoard = new MotherBoard { IsBroken = false };
computerSystem.AddComponent(motherBoard);

var keyboard = new KeyBoard { IsBroken = true };
computerSystem.AddComponent(keyboard);

var hardDisk = new HardDisk { IsBroken = false };
computerSystem.AddComponent(hardDisk);

Console.WriteLine();

computerSystem.CheckMileage();
computerSystem.ConnectComponents();
