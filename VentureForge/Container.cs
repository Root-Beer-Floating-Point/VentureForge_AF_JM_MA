using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentureForge
{
    public class Container
    {
        public String name;
        public bool Integer; //if true it's an integer data field
        public bool DataEntry; //if true it's a data entry container

        public Container()
        {
            name = "test";
        }
    }
}
