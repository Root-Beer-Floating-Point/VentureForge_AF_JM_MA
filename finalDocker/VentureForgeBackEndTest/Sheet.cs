using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
//using System.Windows.Controls;

namespace VentureForgeBackEndTest
{
    public class Sheet
    {
        int count = 0;
        public String name = "";
        // public Button addButton;
        // public Border sheetBorder;
        //public double width;
        //public double height;
        public Dictionary<String, Container> containerList = new Dictionary<String, Container> ();
        //public int counter = 0;
        

        public Sheet()
        {

        }// empty arg constructor

        /*public Sheet(Button b)
        {

        }*/

        

        public Sheet(string n)
        {
            this.name = n;
        }// Sheet constructor, might not be used???

       /* public void addContainer(String n, bool cType, bool dType)
        {
            if(cType == false)//not a data input
            {
                Container con = new Container(n);
                con.setData(cType);
                containerList.Add(n, con);
            }
            else//is a data input
            {
                Container con = new Container(n, dType);
                containerList.Add(n, con);
              
            }
            //counter++;
            
        }*/

            public void addContainer(String n, Container container)
        {

            if (count == 0) { containerList.Add(n, container); }
            else { containerList.Remove(n); containerList.Add(n, container); }
            count++;
        }

        /*public Container getContainer()
        {
            return containerList.Last();
        }
        */
        public void setName(String n)
        {
            name = n;
        }

        public String getName()
        {
            return name;
        }

        public void getAllContainers()
        {
            //iterate through list of containers
        }


    }// end Sheet object
}
