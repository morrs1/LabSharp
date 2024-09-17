
var motherboard = new Motherboard("ASUS ROG Strix", 1660);
var processor = new Processor("Intel Core i7");
var hardDisk = new HardDisk("Seagate 1TB");
var computer = new Computer("Gaming PC", motherboard, processor, hardDisk);

var printer = new Printer("HP LaserJet");
var monitor = new Monitor("Dell UltraSharp");
var keyboard = new Keyboard("Logitech K120");
var audioSpeakers = new AudioSpeakers("JBL Flip 5");

// Демонстрация работы классов
//List<ComputerEquipment> equipmentList = new List<ComputerEquipment>
//        {
//            computer,
//            printer,
//            monitor,
//            keyboard,
//            audioSpeakers
//        };

//foreach (var equipment in equipmentList)
//{
//    equipment.DisplayInfo();
//    Console.WriteLine();
//}

var motherBoard = new Motherboard("sss", 1660);
Vanamas.check(motherBoard);