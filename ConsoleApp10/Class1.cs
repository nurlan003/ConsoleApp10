using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class HDD : Storage
    {

        public override string MediaName { get; set; }
        public override string Model { get; set; }
        public int USBSpeedMBMin { get; set; }
        public int CommonMemoryGB { get; set; }
        int a;

        public HDD(string mediaName, string model, int uSBSpeed, int commonMemory)
        {
            MediaName = mediaName;
            Model = model;
            USBSpeedMBMin = uSBSpeed;
            CommonMemoryGB = commonMemory;
            a=commonMemory;
        }

        public override void MediaTypeSize()
        {
            Console.WriteLine(CommonMemoryGB);
        }
        public override void Copy()
        {
            Console.WriteLine($"Butun filelari kocurmek ucun {(((565*1024)/780)/((a*1024)/780))+1} media lazimdir");
            Console.WriteLine($"Butun filelari kocurmek ucun {(565*1024)/USBSpeedMBMin} deqiqe lazimdir");
        }
        public override void FreeMemory()
        {
            Console.WriteLine($"Free Memory:{CommonMemoryGB}");

        }
        public override void PrintDeviceİnfo()
        {
            Console.WriteLine($"Media Name:{MediaName}\nModel:{Model}\nUSB Speed:{USBSpeedMBMin}\nCommon Memory:{a}\nFree Memory{CommonMemoryGB}");

        }


    }
}
