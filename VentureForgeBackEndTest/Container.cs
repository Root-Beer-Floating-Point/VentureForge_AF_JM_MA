using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentureForgeBackEndTest
{
    public class Container
    {
        public String name;
        public bool integer; //if true it's an integer data field
        public bool dataEntry = false; //if true it's a data entry container

        public Container()
        {
            //name = "test";
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

        public void setName(String n)
        {
            name = n;
        }

        public String getName()
        {
            return name;
        }

        public void setInteger(bool i)
        {
            integer = i;
        }

        public bool getInteger()
        {
            return integer;
        }
        public void setdata(bool d)
        {
            dataEntry = d;
        }

        public bool getData()
        {
            return dataEntry;
        }
    }
}
