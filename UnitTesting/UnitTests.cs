using NUnit.Framework;

using System.Collections.Generic;

using System.Windows;

using VentureForge;



namespace UnitTesting

{

    public class UnitTests

    {





        [SetUp]

        public void Setup()

        {



        }



        [Test]

        public void Test1()

        {

            string modtest = "";
            
            Sheet sh1 = new(); sh1.name = "sheet1";
            Sheet sh2 = new(); sh2.name = "sheet2";

            Module mod = new Module("mod1");



            mod.AddSheet("sheet1", sh1); mod.AddSheet("sheet2", sh2);

            string test = "sheet1sheet2";





            Assert.IsTrue(mod.name == "mod1");

            Assert.AreNotSame(test, modtest);



            foreach (KeyValuePair<string, Sheet> ele1 in mod.SheetList)

            {

                modtest += ele1.Key;

            }

            Assert.AreEqual(test, modtest);

        }// end test1

        public void Test2()
        {



        }// end test2

    }

}