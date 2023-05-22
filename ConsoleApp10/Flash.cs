using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public  class Flash:Storage
    {
        public override string MediaName { get; set; }
        public override string Model { get; set; }

        public int USB3SpeedMBMin { get; set; }
        public int CommonMemoryGB { get; set; }
        int a;

        public Flash(string mediaName, string model, int uSBSpeed, int commonMemory)
        {
            MediaName = mediaName;
            Model = model;
            USB3SpeedMBMin = uSBSpeed;
            CommonMemoryGB = commonMemory;
            a=commonMemory;
        }


        public override void MediaTypeSize()
        {
            Console.WriteLine($"Media Type Size:{a}");
        }
        public override void Copy()
        {
            Console.WriteLine($"Butun filelari kocurmek ucun {(((565*1024)/780)/((a*1024)/780))+1} media lazimdir");
            Console.WriteLine($"Butun filelari kocurmek ucun {(565*1024)/USB3SpeedMBMin} deqiqe lazimdir");
        }
        public override void FreeMemory()
        {
            Console.WriteLine($"Free Memory:{CommonMemoryGB}");

        }
        public override void PrintDeviceİnfo()
        {
            Console.WriteLine($"Media Name:{MediaName}\nModel:{Model}\nUSB 3.0 Speed:{USB3SpeedMBMin}\nCommon Memory:{a}\nFree Memory{CommonMemoryGB}");
        }


    }
}
