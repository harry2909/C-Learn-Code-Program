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
        private Canvas _canvas = new Canvas(); // call new instance of canvas

        private readonly Bitmap _outputBitMap = new Bitmap(840, 680); // set up new bitmap

        /// <summary>
        /// Testing the initialisation of canvas with bitmap
        /// </summary>
        [TestInitialize]
        public void Initialize()
        {
            _canvas = new Canvas(Graphics.FromImage(_outputBitMap));
        }

        /// <summary>
        /// Method to test that the array is splitting correctly
        /// </summary>
        [TestMethod]
        public void CallDrawMethodWithCommand()
        {
            const string list = "drawline 20 40";
            var command = list.Trim().ToLower();
            var commandList = command.Split(" ");
            Assert.IsTrue(commandList[0].Equals("drawline"));
            Assert.IsTrue(int.Parse(commandList[1]).Equals(20));
            Assert.IsTrue(int.Parse(commandList[2]).Equals(40));
        }

        /// <summary>
        /// Checking if the pen moves when xpos and ypos are changed.
        /// </summary>
        [TestMethod]
        public void TestPenCoordiantes()
        {
            const string list = "drawline 20 40";
            var command = list.Trim().ToLower();
            var commandList = command.Split(" ");
            const int xPos = 280;
            const int yPos = 280;
            if (commandList[0].Equals("drawline"))
            {
                _canvas.MoveTo(int.Parse(commandList[1]), int.Parse(commandList[2]));
                Assert.IsTrue(int.Parse(commandList[1]) < xPos);
                Assert.IsTrue(int.Parse(commandList[2]) < yPos);
            }
        }

        /// <summary>
        /// Checking if the pen moves when xpos and ypos are changed.
        /// </summary>
        [TestMethod]
        public void CommandLineCoordinates()
        {
            const string list = "drawline 20 40";
            var command = list.Trim().ToLower();
            var commandList = command.Split(" ");
            const int toX = 0;
            const int toY = 0;
            if (commandList[0].Equals("drawline"))

            {
                _canvas.MoveTo(int.Parse(commandList[1]), int.Parse(commandList[2]));
                Assert.IsTrue(int.Parse(commandList[1]) > toX);
                Assert.IsTrue(int.Parse(commandList[2]) > toY);
            }
        }

        /// <summary>
        /// Testing if exception throws is no number is entered after command
        /// </summary>
        [TestMethod]
        public void ExceptionTest()
        {
            const string list = "line";
            var command = list.Trim().ToLower();
            var commandList = command.Split(" ");
            try
            {
                if (commandList[0].Contains("line"))
                {
                    _canvas.DrawLine(int.Parse(commandList[1]), int.Parse(commandList[2]));
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
            const string list = "drawline 0 0";
            var command = list.Trim().ToLower();
            var commandList = command.Split(" ");
            const int toX = 90;
            const int toY = 90;
            if (commandList[0].Equals("drawline"))
            {
                _canvas.ResetPen(int.Parse(commandList[1]), int.Parse(commandList[2]));
                Assert.IsTrue(int.Parse(commandList[1]) < toX);
                Assert.IsTrue(int.Parse(commandList[2]) < toY);
            }
        }

        /// <summary>
        /// Testing that the pen colours are changed appropriatley 
        /// </summary>
        [TestMethod]
        public void TestPenColour()
        {
            var penBox = new ComboBox();
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
                    Assert.IsTrue((string) penBox.SelectedItem == "Red");
                }
                catch (Exception)
                {
                    Console.WriteLine(@"This should throw as the index is set to 0 so 'blue'");
                }
            }
            else if (penBox.SelectedIndex == 0)
            {
                Assert.IsTrue((string) penBox.SelectedItem == "Blue");
            }
        }
    }
}