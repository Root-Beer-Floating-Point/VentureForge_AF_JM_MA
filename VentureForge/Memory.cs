using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentureForge
{
    public class Memory
    {

        internal static Dictionary<string, Module> modList = new Dictionary<string, Module>();
        // this is the main memory for the program, allowing for us to keep track
        // of all the modules, which in turn contain all the sheets within
        public Memory()
        {

        }// probably won't need to make a memory object ever, we'll see


    }

    public class Module
    {

        public String name = "";
        public Dictionary<String, Sheet> SheetList = new Dictionary<string, Sheet>();
        
        int count = 0;


        public Module()
        {

        }// end empty argument constructor

        public Module(string name)
        {
            this.name = name;
        }// end Module Constructor

        public void AddSheet(String sheetName, Sheet sheet)
        {
            if (count == 0) { SheetList.Add(sheetName, sheet); }
            else { SheetList.Remove(sheetName); SheetList.Add(sheetName, sheet); }
            count++;
        }

    }// end class Module

    public class Sheet
    {

        public String name = "";


        public Sheet()
        {

        }// empty arg constructor

        public Sheet(String n)
        {
            this.name = n;
        }// Sheet constructor, might not be used???


    }// end Sheet object

    public class Container
    {

        public Container()
        {

        }// end empty argument constructor

    }
}
