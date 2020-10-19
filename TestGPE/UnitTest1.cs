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
        private Canvas _canvas;
        
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

        [TestMethod]
        public void TestCanvas()
        {
            _canvas.DrawLine(1000, 1000);
            _canvas.DrawRectangle(10, 20);
            
        }
        
        
    }
    
    
}

