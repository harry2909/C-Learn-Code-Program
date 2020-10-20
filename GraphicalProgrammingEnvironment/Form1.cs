﻿using System;
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

        /// <summary>
        /// Call an instance of canvas
        /// </summary>
        Canvas MyCanvas;

        /// <summary>
        /// Array to hold list of commands
        /// </summary>
        private String[] commandList;

        public Form1()
        {
            InitializeComponent();
            MyCanvas = new Canvas(Graphics.FromImage(OutputBitMap)); // class for handling drawing
        }

        /// <summary>
        /// Creating method to handle enter key event
        /// </summary>
        /// <param name="sender">The object that will trigger event</param>
        /// <param name="e">Key event data</param>
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
        /// Method to process all possible commands
        /// </summary>
        private void ProcessCommands()
        {
            // split after trim and store in array with space delimiter
            String command = commandLine.Text.Trim().ToLower();
            commandList = command.Split(" ");

            if (commandList[0].Equals("moveto")) // if match, call method
            {
                MoveTo();
            }

            else if (commandList[0].Equals("line"))
            {
                DrawLine();
            }
            else if (commandList[0].Equals("square"))
            {
                DrawSquare();
            }
            else if (commandList[0].Equals("rectangle"))
            {
                DrawRectangle();
            }
            else if (commandList[0].Equals("circle"))
            {
                DrawCircle();
            }
            else if (commandList[0].Equals("clear"))
            {
                ClearImage();
                drawBox.Refresh();
            }
            else if (commandList[0].Equals("quit"))
            {
                Application.Exit();
            }

            commandLine.Text = "";
            Refresh();
        }

        /// <summary>
        /// Methods to draw shapes based on command input
        /// </summary>
        private void MoveTo()
        {
            try
            {
                MyCanvas.MoveTo(Int32.Parse(commandList[1]),
                    Int32.Parse(commandList[2]));
            }
            catch (IndexOutOfRangeException) // catch if no number has been entered after command
            {
                MessageBox.Show("Must enter a number after command.");
            }
        }

        private void DrawLine()
        {
            try
            {
                MyCanvas.DrawLine(Int32.Parse(commandList[1]),
                    Int32.Parse(commandList[2])); // use the index to determine values for shape
                commandLine.Text = ("Line has been drawn");
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Must enter a number after command.");
            }
        }

        private void DrawSquare()
        {
            try
            {
                MyCanvas.DrawSquare(Int32.Parse(commandList[1]));
                commandLine.Text = ("Square has been drawn");
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Must enter a number after command.");
            }
        }

        private void DrawRectangle()
        {
            try
            {
                MyCanvas.DrawRectangle(Int32.Parse(commandList[1]),
                    Int32.Parse(commandList[2]));
                commandLine.Text = ("Rectangle has been drawn");
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Must enter a number after command.");
            }
        }

        private void DrawCircle()
        {
            try
            {
                MyCanvas.DrawCircle(Int32.Parse(commandList[1]));
                commandLine.Text = "Circle has been drawn.";
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Must enter a number after command.");
            }
        }


        /// <summary>
        /// Method to clear the bitmap on command
        /// </summary>
        public void ClearImage()
        {
            Graphics myGraphics = Graphics.FromImage(OutputBitMap);
            myGraphics.Clear(Color.Teal);
        }
    }
}