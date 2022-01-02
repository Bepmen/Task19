using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task19._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            
            Модель  компьютера  характеризуется  кодом  и  названием  марки компьютера,  типом  процессора,  
            частотой  работы  процессора,  объемом оперативной памяти, объемом жесткого диска, объемом памяти
            видеокарты, стоимостью компьютера в условных единицах и количеством экземпляров, имеющихся в наличии. 
            Создать список, содержащий 6-10 записей с различным набором значений характеристик.

            Определить:

            - все компьютеры с указанным процессором. Название процессора запросить у пользователя;
            - все компьютеры с объемом ОЗУ не ниже, чем указано. Объем ОЗУ запросить у пользователя;
            - вывести весь список, отсортированный по увеличению стоимости;
            - вывести весь список, сгруппированный по  частоте работы процессора;
            - найти самый дорогой и самый бюджетный компьютер;

            - есть ли хотя бы один компьютер в количестве не менее 30 штук?
             
            */

            List<ComputerElements> list = new List<ComputerElements>()
            {
                new ComputerElements(){Code = 1, Name = "Acer", TypeProcessor = "Intel Xeon", ProcessorFrequency = 2.3, AmoutRAM= 4 , VolumeHD= 128, AmountMemoryVC= 2, Cost =20000, NumberInstanse =  50},
                new ComputerElements(){Code = 2, Name = "Asus", TypeProcessor = "Intel Core i3", ProcessorFrequency = 2.3, AmoutRAM= 16, VolumeHD= 500, AmountMemoryVC= 3, Cost =30000, NumberInstanse =  25},
                new ComputerElements(){Code = 3, Name = "HP", TypeProcessor = "Intel Core i3", ProcessorFrequency = 2.6, AmoutRAM= 8, VolumeHD= 250, AmountMemoryVC= 6, Cost =60000, NumberInstanse =  10},
                new ComputerElements(){Code = 4, Name = "Lenovo", TypeProcessor = "AMD FX", ProcessorFrequency = 2.5, AmoutRAM= 32, VolumeHD= 2000, AmountMemoryVC= 4, Cost =35000, NumberInstanse = 10 },
                new ComputerElements(){Code = 5, Name = "Apple", TypeProcessor = "Apple M1", ProcessorFrequency = 2.6, AmoutRAM= 64, VolumeHD= 1000, AmountMemoryVC= 8, Cost =100000, NumberInstanse =  5},
                new ComputerElements(){Code = 6, Name = "Dell", TypeProcessor = "AMD Ryzen 7", ProcessorFrequency = 3.0, AmoutRAM= 128, VolumeHD= 4000, AmountMemoryVC= 16, Cost =150000, NumberInstanse =  2},
            };

            //Console.Write("Введите название процессора: ");
            //string amountCompProc = Console.ReadLine();
            //List<ComputerElements> computers = list.Where(x => x.TypeProcessor == amountCompProc).ToList();
            //Print(computers);

            //Console.Write("Введите название элемента компьютера: ");
            //int amountCompRAM = Convert.ToInt32(Console.ReadLine());
            //List<ComputerElements> computers1 = list.Where(x => x.AmoutRAM >= amountCompRAM).ToList();
            //Print(computers1);

            //List<ComputerElements> sortUp = list.OrderBy(x => x.Cost).ToList();
            //Print(sortUp);

            //IEnumerable<IGrouping<double, ComputerElements>> groupSort = list.GroupBy(x => x.ProcessorFrequency);
            //foreach (IGrouping<double, ComputerElements> gr in groupSort)
            //{
            //    Console.WriteLine(gr.Key + " ГГц");
            //    foreach (ComputerElements c in gr)
            //    {
            //        Console.WriteLine($"{c.Name}\t{c.Cost}");
            //    }
            //}

            //ComputerElements exspensive = list.OrderByDescending(x => x.Cost).FirstOrDefault();
            //Console.WriteLine($"{exspensive.Name} {exspensive.Cost}");

            //ComputerElements cheap = list.OrderBy(x => x.Cost).FirstOrDefault();
            //Console.WriteLine($"{cheap.Name} {cheap.Cost}");

            //Console.WriteLine(list.Any(x => x.NumberInstanse >= 30));

            Console.ReadKey();

        }
        static void Print(List<ComputerElements> list)
        {
            foreach (ComputerElements c in list)
            {
                Console.WriteLine($"{c.Name}\t{c.Cost}");
            }
            Console.WriteLine();
        }
    }
}
