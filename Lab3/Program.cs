// See https://aka.ms/new-console-template for more information
using Lab3;
using Lab3.Classes;
using Lab3.Interfaces;

Console.WriteLine("Hello, World!");
var scanner = new Scanner();

scanner.TransferDataNetWork();
scanner.TransferDataUsb();

var printer = new Printer();

printer.TransferDataNetWork();
printer.TransferDataUsb();

var ramMemory = new RamMemory();

ramMemory.TransferDataInner();

var networkCard = new NetworkCard();

networkCard.TransferDataNetWork();

var motherBoard = new MotherBoard();

motherBoard.TransferDataNetWork();
motherBoard.TransferDataUsb();
motherBoard.TransferDataInner();
motherBoard.TransferDataSata();

var keyboard = new KeyBoard();

keyboard.TransferDataUsb();

var hardDisk = new HardDisk();

hardDisk.TransferDataSata();

Console.WriteLine();

ComputerSystem computerSystem = new ComputerSystem();


computerSystem.AddComponent(motherBoard);
computerSystem.AddComponent(ramMemory);
computerSystem.AddComponent(hardDisk);
computerSystem.AddComponent(printer);
computerSystem.AddComponent(scanner);
computerSystem.AddComponent(networkCard);
computerSystem.AddComponent(keyboard);

computerSystem.ConnectComponents();


