﻿using System;
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

        public Sheet(String n)
        {
            this.name = n;
        }// Sheet constructor, might not be used???

        public void addContainer()
        {

            containerList.Add(new Container());
        }


    }// end Sheet object
}