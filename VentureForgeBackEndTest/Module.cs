using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentureForgeBackEndTest
{
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

        public void addSheet(String s, Sheet sheet)
        {
            SheetList.Add(s, sheet);
        }

        public void setName(String n)
        {
            name = n;
        }

        public String getName()
        {
            return name;
        }

    }// end class Module
}
