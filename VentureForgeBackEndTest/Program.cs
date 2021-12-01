using System;

namespace VentureForgeBackEndTest
{
    class Program
    {
        String reply;

        Module module;
        Sheet sheet;
        Container container;
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like to create a module?");
            Console.WriteLine("(Y/N)");
            
            Console.WriteLine("Would you like to create a sheet?");
            Console.WriteLine("(Y/N)");

            Console.WriteLine("Would you like to create a container?");
            Console.WriteLine("(Y/N)");

        }

        public void promptModule()
        {
            Console.WriteLine("Would you like to create a module?");
            Console.WriteLine("(Y/N)");
            if(Console.ReadLine() == "y" | Console.ReadLine() == "Y")
            {

            }
            else if(Console.ReadLine() == "n" | Console.ReadLine() == "N")
            {

            }
            else
            {
                Console.WriteLine("Incorrect input, try again");
                promptModule();
            }
        }

        public void fillModule()
        {
            module = new Module();
            Console.WriteLine("What's the name of the module?");
            module.setName(Console.ReadLine());
            promptSheet();
            
        }

        public void promptSheet()
        {
            Console.WriteLine("Would you like to create a sheet?");
            Console.WriteLine("(Y/N)");
            if (Console.ReadLine() == "y" | Console.ReadLine() == "Y")
            {

            }
            else if (Console.ReadLine() == "n" | Console.ReadLine() == "N")
            {
                promptModule();
            }
            else
            {
                Console.WriteLine("Incorrect input, try again");
                promptSheet();
            }
        }

        public void fillSheet()
        {
            sheet = new Sheet();
            Console.WriteLine("What's the name of the Sheet?");
            sheet.setName(Console.ReadLine());
            module.AddSheet
            promptContainer();

        }

        public void promptContainer()
        {
            Console.WriteLine("Would you like to create a container?");
            Console.WriteLine("(Y/N)");
            if (Console.ReadLine() == "y" | Console.ReadLine() == "Y")
            {

            }
            else if (Console.ReadLine() == "n" | Console.ReadLine() == "N")
            {
                promptSheet();
            }
            else
            {
                Console.WriteLine("Incorrect input, try again");
                promptContainer();
            }
        }

        public void fillContainer()
        {
            container = new Container();
            Console.WriteLine("What's the name of the Container?");
            container.setName(Console.ReadLine());
            promptContainer();

        }


    }
}
