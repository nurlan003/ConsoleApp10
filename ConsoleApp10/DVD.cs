using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class DVD : Storage
    {

        public override string MediaName { get; set; }
        public override string Model { get; set; }
        public int ReadandWriteSpeedMBMin { get; set; }
        public int Type { get; set; }
        int a;


        public DVD(string mediaName, string model, int readandWriteSpeed, int type)
        {
            MediaName = mediaName;
            Model = model;
            ReadandWriteSpeedMBMin = readandWriteSpeed;
            Type = type;
            a=type;
        }

        public override void MediaTypeSize()
        {
            Console.WriteLine(Type);

        }
        public override void Copy()
        {
            Console.WriteLine($"Butun filelari kocurmek ucun {(((565*1024)/780)/((a*1024)/780))+1} media lazimdir");
            Console.WriteLine($"Butun filelari kocurmek ucun {(565*1024)/ReadandWriteSpeedMBMin} deqiqe lazimdir");

        }
        public override void FreeMemory()
        {
            Console.WriteLine($"Free Memory:{Type}");

        }
        public override void PrintDeviceİnfo()
        {
            Console.WriteLine($"Media Name:{MediaName}\nModel:{Model}\nRead and Write Speed MB/Min:{ReadandWriteSpeedMBMin}\nCommon Memory:{a}\nFree Memory{Type}");

        }
    }
}
