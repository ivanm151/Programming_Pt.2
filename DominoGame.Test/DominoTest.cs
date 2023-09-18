using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Domino_Game;
using System.Windows.Forms;
using cs_Lab1_Medvedev_8I21;

namespace DominoGame.Test
{
    [TestClass]
    public class DominoTest
    {
        Domino domino;
        Random rand;
       

        [TestInitialize]
        public void TestInitialize()
        {
            domino = new Domino();
        }

        [TestMethod]
        public void get_value_test()
        {
            int expected_range1 = 1;
            int expected_range2 = 6;
            int actual1 = domino.get_value()[0];
            int actual2 = domino.get_value()[1];
            Assert.IsTrue(expected_range1 <= actual1 && expected_range1 <= actual2 && expected_range2 >= actual1 && expected_range2 >= actual2);
        }
        public void set_user_value_test()
        {
            rand = new Random();
            int[] nums = new int[2] { rand.Next(1, 7), rand.Next(1, 7) };
            domino.set_user_value(nums);
            Assert.AreEqual(nums, domino.get_value());
        }      
    }
    /*
    [TestClass]
    public class ProgramTest
    {
        Domino domino;
        
        Form1 form1;

        [TestInitialize]
        public void TestInitialize()
        {
            domino = new Domino();
            form1 = new Form1();
        }
        [TestMethod]
        public void aa()
        {
            
            
        }
    }
    */
}
    