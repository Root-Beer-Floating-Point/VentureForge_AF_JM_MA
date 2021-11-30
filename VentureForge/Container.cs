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
        public bool integer; //if true it's an integer data field
        public bool dataEntry; //if true it's a data entry container

        public Container()
        {
            name = "test";
        }

        public Container(String n, bool dType)
        {
            name = n;
            integer = dType;
            if(integer == true)
            {

            }
        }

        public Container(String n)
        {
            name = n;
        }

        
    }
}
