using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public abstract class Storage
    {

        abstract public string MediaName { get; set; }
        abstract public string Model { get; set; }

        public abstract void MediaTypeSize();
        public abstract void Copy();

        public abstract void FreeMemory();

        public abstract void PrintDeviceİnfo();


    }
}

