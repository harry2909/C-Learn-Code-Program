using System;
using System.Drawing;
using System.Windows.Forms;
using GraphicalProgrammingEnvironment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestGPE

{
    [TestClass]
    
    public class UnitTest1
    {
        Canvas _canvas = new Canvas();
        
        Bitmap OutputBitMap = new Bitmap(840, 680);
        
        [TestInitialize]
        public void Initialize()
        {
            _canvas = new Canvas(Graphics.FromImage(OutputBitMap));
        }

        [TestMethod]
        public void CallDrawMethodWithCommand()
        {
            String[] commandList;
            String list = "line 20 40";
            String list2 = "line";
            String reset = "reset";
            String command = list.Trim().ToLower(); 
            commandList = command.Split(" ");
            Assert.IsTrue(commandList[0].Equals("line"));
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
            String list = "line 20 40";
            String list2 = "line";
            String command = list.Trim().ToLower(); 
            commandList = command.Split(" ");
            int xPos = 280;
            int yPos = 280;
            if (commandList[0].Equals("line"))
            {
                _canvas.MoveTo(xPos, yPos);
                Assert.IsTrue(xPos > 0);
                Assert.IsTrue(yPos > 0);
            }
            

        }
        
        /// <summary>
        /// Checking if the pen moves when xpos and ypos are changed.
        /// </summary>
        [TestMethod]
        public void CommandLineCoordinates()
        {
            String[] commandList;
            String list = "line 20 40";
            String list2 = "line";
            String command = list.Trim().ToLower(); 
            commandList = command.Split(" ");
            int toX = 0;
            int toY = 0;
            if (commandList[0].Equals("line"))
                
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
                Console.Write("This should throw");
            }
            
            

        }
        
        

       
        
        
    }
    
    
}

