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
        public List<Container> containerList = new List<Container>();
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
                containerList.Add(con);
            }
            else//is a data input
            {
                Container con = new Container(n, dType);
                containerList.Add(con);
              
            }
            counter++;
            
        }

        public Container getContainer()
        {
            return containerList.Last();
        }


    }// end Sheet object
}
