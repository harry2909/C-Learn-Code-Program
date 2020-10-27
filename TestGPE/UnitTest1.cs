using System;
using System.Drawing;
using System.Windows.Forms;
using GraphicalProgrammingEnvironment;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rectangle = GraphicalProgrammingEnvironment.Rectangle;

namespace TestGPE

{
    /// <summary>
    /// Setup Test Class to test methods
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        private static readonly Bitmap OutputBitMap = new Bitmap(840, 680);
        Circle _circleDraw = new Circle(Graphics.FromImage(OutputBitMap));
        Square _squareDraw = new Square(Graphics.FromImage(OutputBitMap));
        LineDrawClass _lineDraw = new LineDrawClass(Graphics.FromImage(OutputBitMap));
        Rectangle _rectangleDraw = new Rectangle(Graphics.FromImage(OutputBitMap));
        Triangle _triangleDraw = new Triangle(Graphics.FromImage(OutputBitMap));

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
        public void CommandLineCoordinates()
        {
            const string list = "drawline 20 40";
            var command = list.Trim().ToLower();
            var commandList = command.Split(" ");
            const int toX = 0;
            const int toY = 0;
            if (commandList[0].Equals("drawline"))

            {
                MoveToClass.MoveTo(int.Parse(commandList[1]), int.Parse(commandList[2]));
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
                    _lineDraw.DrawLine(int.Parse(commandList[1]), int.Parse(commandList[2]));
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
            Reset.CheckReset(true);

            String a = "20 30";
            String[] _commandList = a.Split(" ");


            if (Reset._reset) // if reset bool is set to true
            {
                MoveToClass._xPos = 0;
                MoveToClass._yPos = 0; // set reset bool back to false
            }

            _rectangleDraw.DrawRectangle(int.Parse(_commandList[0]),
                int.Parse(_commandList[1]));
            Assert.IsTrue(MoveToClass._xPos == 0 && MoveToClass._yPos == 0);
            Assert.IsFalse(MoveToClass._xPos == 20 && MoveToClass._xPos == 30);
        }

        /// <summary>
        /// Testing that the pen colours are changed appropriately 
        /// </summary>
        [TestMethod]
        public void TestPenColourComboBox()
        {
            var penBox = new ComboBox();
            penBox.Items.Insert(0, "Blue");
            penBox.Items.Insert(1, "Red");
            penBox.Items.Insert(2, "Green");
            penBox.Items.Insert(3, "Orange");
            penBox.Items.Insert(4, "Yellow");
            PenColourClass.PenColourSet("blue");

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

        /// <summary>
        /// Testing that the pen colours are changed appropriately 
        /// </summary>
        [TestMethod]
        public void TestPenColourChange()
        {
            String a = "blue";
            PenColourClass.PenColourSet(a);
            Assert.IsTrue(PenColourClass.MyPen.Color.Equals(Color.Blue));

            try
            {
                String b = "red";
                PenColourClass.PenColourSet(b);
                Assert.IsTrue(PenColourClass.MyPen.Color.Equals(Color.Yellow));
            }
            catch
            {
                Console.WriteLine(@"This should throw as index is not set to yellow.");
            }
        }
    }
}