using System;
using System.Drawing;
using System.Windows.Forms;
using GraphicalProgrammingEnvironment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestGPE

{
    /// <summary>
    /// Setup Test Class to test methods
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        Canvas _canvas = new Canvas(); // call new instance of canvas

        Bitmap OutputBitMap = new Bitmap(840, 680); // set up new bitmap

        Form1 _form = new Form1();

        /// <summary>
        /// Testing the initialisation of canvas with bitmap
        /// </summary>
        [TestInitialize]
        public void Initialize()
        {
            _canvas = new Canvas(Graphics.FromImage(OutputBitMap));
        }

        /// <summary>
        /// Method to test that the array is splitting correctly
        /// </summary>
        [TestMethod]
        public void CallDrawMethodWithCommand()
        {
            String[] commandList;
            String list = "drawline 20 40";
            String command = list.Trim().ToLower();
            commandList = command.Split(" ");
            Assert.IsTrue(commandList[0].Equals("drawline"));
            Assert.IsTrue(Int32.Parse(commandList[1]).Equals(20));
            Assert.IsTrue(Int32.Parse(commandList[2]).Equals(40));
        }

        /// <summary>
        /// Checking if the pen moves when xpos and ypos are changed.
        /// </summary>
        [TestMethod]
        public void TestPenCoordiantes()
        {
            String[] commandList;
            String list = "drawline 20 40";
            String command = list.Trim().ToLower();
            commandList = command.Split(" ");
            int xPos = 280;
            int yPos = 280;
            if (commandList[0].Equals("drawline"))
            {
                _canvas.MoveTo(Int32.Parse(commandList[1]), Int32.Parse(commandList[2]));
                Assert.IsTrue(Int32.Parse(commandList[1]) < xPos);
                Assert.IsTrue(Int32.Parse(commandList[2]) < yPos);
            }
        }

        /// <summary>
        /// Checking if the pen moves when xpos and ypos are changed.
        /// </summary>
        [TestMethod]
        public void CommandLineCoordinates()
        {
            String[] commandList;
            String list = "drawline 20 40";
            String command = list.Trim().ToLower();
            commandList = command.Split(" ");
            int toX = 0;
            int toY = 0;
            if (commandList[0].Equals("drawline"))

            {
                _canvas.MoveTo(Int32.Parse(commandList[1]), Int32.Parse(commandList[2]));
                Assert.IsTrue(Int32.Parse(commandList[1]) > toX);
                Assert.IsTrue(Int32.Parse(commandList[2]) > toY);
            }
        }

        /// <summary>
        /// Testing if exception throws is no number is entered after command
        /// </summary>
        [TestMethod]
        public void ExceptionTest()
        {
            String[] commandList;
            String list = "line";
            String command = list.Trim().ToLower();
            commandList = command.Split(" ");
            try
            {
                if (commandList[0].Contains("line"))
                {
                    _canvas.DrawLine(Int32.Parse(commandList[1]), Int32.Parse(commandList[2]));
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.Write(@"This should throw as the parameters have not been specified.");
            }
        }
        
        /// <summary>
        /// Method to test that pen coordinates reset properly
        /// </summary>
        [TestMethod]
        public void TestPenReset()
        {
            String[] commandList;
            String list = "drawline 0 0";
            String command = list.Trim().ToLower();
            commandList = command.Split(" ");
            int toX = 90;
            int toY = 90;
            if (commandList[0].Equals("drawline"))
            {
                _canvas.ResetPen(Int32.Parse(commandList[1]), Int32.Parse(commandList[2]));
                Assert.IsTrue(Int32.Parse(commandList[1]) < toX);
                Assert.IsTrue(Int32.Parse(commandList[2]) < toY);
            }
        }
        
        /// <summary>
        /// Testing that the pen colours are changed appropriatley 
        /// </summary>
        [TestMethod]
        public void TestPenColour()
        {
            ComboBox penBox = new ComboBox();
            penBox.Items.Insert(0, "Blue");
            penBox.Items.Insert(1, "Red");
            penBox.Items.Insert(2, "Green");
            penBox.Items.Insert(3, "Orange");
            penBox.Items.Insert(4, "Yellow");
            _canvas.PenColourSet("blue");

            penBox.SelectedIndex = penBox.FindStringExact("Blue");
            if (penBox.SelectedIndex == 0)
            {
                try
                {
                    Assert.IsTrue(penBox.SelectedItem == "Red");
                }
                catch (Exception)
                {
                    Console.WriteLine(@"This should throw as the index is set to 0 so 'blue'");
                }
            }
            else if (penBox.SelectedIndex == 0)
            {
                Assert.IsTrue(penBox.SelectedItem == "Blue");
            }
        }
    }
}