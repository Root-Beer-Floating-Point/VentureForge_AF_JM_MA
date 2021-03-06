using System;
using System.Collections.Generic;

namespace VentureForgeBackEndTest
{
    class Program
    {
        static String reply;
        static Memory memory = new Memory();
        static Module module;
        static Sheet sheet;
        static Container container;
        static String dataType;
        static String inputType;
        static void Main(string[] args)
        {
            promptModule();

        }


        public static void promptModule()
        {
            Console.WriteLine("Would you like to create a module?");
            Console.WriteLine("(Y/N)");
            reply = Console.ReadLine();
            if(reply == "y" || reply == "Y")
            {
                fillModule();
            }
            else if(reply == "n" || reply == "N")
            {
                showAll();
            }
            else
            {
                Console.WriteLine("Incorrect input, try again");
                promptModule();
            }
        }

        public static void fillModule()
        {
            module = new Module();
            module.setName("");
            Console.WriteLine("What's the name of the module?");
            module.setName(Console.ReadLine());
            memory.addModule(module.name, module);
            promptSheet();
            
        }

        public static void promptSheet()
        {
            Console.WriteLine("Would you like to create a sheet?");
            Console.WriteLine("(Y/N)");
            reply = Console.ReadLine();
            if (reply == "y" || reply == "Y")
            {
                fillSheet();
            }
            else if (reply == "n" || reply == "N")
            {
                promptModule();
            }
            else
            {
                Console.WriteLine("Incorrect input, try again");
                promptSheet();
            }
        }

        public static void fillSheet()
        {
            sheet = new Sheet();
            Console.WriteLine("What's the name of the sheet?");
            sheet.setName(Console.ReadLine());
            module.AddSheet(sheet.getName(), sheet);
            promptContainer();

        }

        public static void promptContainer()
        {
            Console.WriteLine("Would you like to create a container?");
            Console.WriteLine("(Y/N)");
            reply = Console.ReadLine();
            if (reply == "y" || reply == "Y")
            {
                fillContainer();
            }
            else if (reply == "n" || reply == "N")
            {
                promptSheet();
            }
            else
            {
                Console.WriteLine("Incorrect input, try again");
                promptContainer();
            }
        }
        public static void fillContainer()
        {
            container = new Container();
            Console.WriteLine("What's the name of the container?");
            container.setName(Console.ReadLine());
            Console.WriteLine("Does the container have an input field? (Y/N)");
            reply = Console.ReadLine();
            if(reply == "y" || reply == "Y")
            {
                container.setData(true);
                Console.WriteLine("Is the input field an integer? (Y/N)");
                reply = Console.ReadLine();
                if (reply == "y" || reply == "Y")
                {
                    container.setInteger(true);

                }
                else
                {
                    container.setInteger(false);
                }
                
            }

            else
            {
                container.setData(false);
                
            }
            sheet.addContainer(container.getName(), container);
            promptContainer();

        }

        public static void showAll()
        {
            foreach (KeyValuePair<String, Module> ele1 in Memory.modList)
            {
                Console.WriteLine("Module: "+ele1.Value.name);
                foreach (KeyValuePair<String, Sheet> ele2 in Memory.modList[ele1.Key].SheetList)
                {
                    Console.WriteLine("Sheet: " + ele2.Value.name);
                    foreach (KeyValuePair<string, Container> ele3 in Memory.modList[ele1.Key].SheetList[ele2.Key].containerList)
                    {
                        if (ele3.Value.dataEntry == true)
                        {
                            inputType = "input";
                            if (ele3.Value.integer == true)
                            {
                                dataType = "integers";
                            }
                            else
                            {
                                dataType = "strings";
                            }
                            Console.WriteLine("Container: " + ele3.Value.name + " designed for " + inputType + " using " + dataType);
                        }
                        else
                        {
                            inputType = "labels";
                            Console.WriteLine("Container: " + ele3.Value.name + " designed for " + inputType);
                        }
                        
                        
                    }
                }
            }       
            
        }

    }
}
