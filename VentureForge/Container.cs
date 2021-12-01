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
        public bool dataEntry = false; //if true it's a data entry container
        public string label = "";
        public string data = "";

        public Container()
        {
            name = "test";
        }

        public Container(String n, bool dType)
        {
            dataEntry = true;
            name = n;
            integer = dType;
            
        }

        public Container(String n)
        {
            name = n;
        }

        
    }
}
