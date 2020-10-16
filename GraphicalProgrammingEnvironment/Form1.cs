using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicalProgrammingEnvironment
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Bitmap to draw on which will be displayed in drawBox
        /// </summary>
        Bitmap OutputBitMap = new Bitmap(840, 680);

        Canvas MyCanvas;

        public Form1()
        {
            InitializeComponent();
            MyCanvas = new Canvas(Graphics.FromImage(OutputBitMap)); // class for handling drawing
        }

        /// <summary>
        /// Creating method to handle enter key event
        /// </summary>
        /// <param name="sender">The object that will trigger event</param>
        /// <param name="e">Event data</param>
        private void commandLine_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ProcessCommands();
            }
        }

        /// <summary>
        /// Create method to draw to bitmap on picture vent
        /// </summary>
        /// <param name="sender">Object to trigger event</param>
        /// <param name="e">Event data</param>
        private void drawBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics myGraph = e.Graphics; // get graphics context of form
            myGraph.DrawImageUnscaled(OutputBitMap, 0, 0); // put off screen bitmap on form
        }

        /// <summary>
        /// Method to draw a line
        /// </summary>
        private void DrawLine()
        {
            MyCanvas.DrawLine(160, 120);
            commandLine.Text = ("Line has been drawn");
        }

        /// <summary>
        /// Method to draw a square
        /// </summary>
        private void DrawSquare()
        {
            MyCanvas.DrawSquare(50);
            commandLine.Text = ("Square has been drawn");
        }
        
        /// <summary>
        /// Method to draw a rectangle
        /// </summary>
        private void DrawRectangle()
        {
            MyCanvas.DrawRectangle(60, 25);
             commandLine.Text = ("Rectangle has been drawn");
        }

        /// <summary>
        /// Method to process all possible commands
        /// </summary>
        private void ProcessCommands()
        {
            // array to for possible splits on command names
            string[] delimiterChars = { 
                "line",
                "square",
                "rectangle",
                "circle"
            };
                
            // split after trim and store in array
            String command = commandLine.Text.Trim().ToLower();
            String[] commandList = command.Split(delimiterChars.ToString(), StringSplitOptions.None);

            // loop through array of commands
            for (int i = 0; i < commandList.Length; i++)
            {
                if (commandList[i].Equals("line")) // if match, call method
                {
                    DrawLine();
                }
                else if (commandList[i].Equals("square"))
                {
                    DrawSquare();
                }
                else if (commandList[i].Equals("rectangle"))
                {
                    DrawRectangle();
                }
                else if (commandList[i].Equals("circle"))
                {
                    DrawSquare();
                }
               
            }

            commandLine.Text = "";
            Refresh();
        }
    }
}