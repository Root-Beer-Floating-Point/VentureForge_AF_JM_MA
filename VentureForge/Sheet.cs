using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace VentureForge
{
    public class Sheet
    {

        public String name = "";
        public Button addButton;
        public Border sheetBorder;
        public double width;
        public double height;
        public Dictionary<string, Container> containerList = new Dictionary<string, Container>();
        public int counter = 0;
        

        public Sheet()
        {

        }// empty arg constructor

        public Sheet(Button b)
        {

        }

        public Sheet(string n)
        {
            this.name = n;
        }// Sheet constructor, might not be used???

        public void addContainer(String n, bool cType, bool dType)
        {
            if(cType == false)//not a data input
            {
                Container con = new Container(n);
                containerList.Add(con.name,con);
            }
            else//is a data input
            {
                Container con = new Container(n, dType);
                containerList.Add(con.name, con);
              
            }
            counter++;
            
        }

        public Container getContainer(string conName)
        {
            return containerList[conName];
        }


    }// end Sheet object
}
