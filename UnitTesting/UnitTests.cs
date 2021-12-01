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

        [Test]
        public void Test2()
        {

            Sheet sh = new(); 
            sh.addContainer("con1", true, false); sh.addContainer("con2", true, true);
            Container con1 = sh.containerList[0]; Container con2 = sh.containerList[1];
            
            Assert.IsFalse(con1.integer); Assert.IsTrue(con2.integer);
            Assert.AreNotEqual(con1.name, con2.name);
            Assert.AreEqual(con1.name, "con1"); Assert.AreEqual(con2.name, "con2");

        }// end test2

        [Test]
        public void Test3()
        {

            Sheet sh1 = new();
            Container con1 = new Container("con1"); Container con2 = new Container("con2"); Container con3 = new Container("con3");
            sh1.addContainer(con1.name, false, false); sh1.addContainer(con2.name, false, false); sh1.addContainer(con3.name, false, false);

            string test = "con1con2con3"; string modtest = "";

            foreach (Container ele1 in sh1.containerList)

            {

                modtest += ele1.name;

            }

            Assert.AreEqual(test, modtest);

        }// end test 3

    }

}