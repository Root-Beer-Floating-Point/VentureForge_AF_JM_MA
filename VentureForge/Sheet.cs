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
        public List<Container> containerList;
        

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
                containerList.Add(new Container(n));
            }
            else//is a data input
            {
                containerList.Add(new Container(n, dType));
            }
            
        }


    }// end Sheet object
}
