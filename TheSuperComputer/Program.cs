using System;

namespace TheSuperComputer
{
    class Program
    {
        static void Main(string[] args)
        {
            Monitor lgMonitor = new Monitor("1920x1080", true, 32);
            Printer hpPrinter = new Printer("HP", "MP102", 50);

            Vga nvdiaVga = new Vga("Nvidia", 2054, 2054);
            Ram samsungRam = new Ram("DDR4", 5000, 8000);
            Processor intelProcessor = new Processor();
            intelProcessor.setCache(254);
            intelProcessor.setCore(10);
            intelProcessor.setSeries("CORE i9 10th Gen");

            Computer computer = new
 Computer.Builder(samsungRam, nvdiaVga, intelProcessor)//parameter wajib 
                .withMonitor(lgMonitor)//parameter opsional 
                .withPrinter(hpPrinter)//parameter opsional 
                .build();
            Console.WriteLine(computer.ToString());
        }
    }
}