﻿using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace GraphicalProgrammingEnvironment
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Bitmap to draw on which will be displayed in drawBox
        /// </summary>
        private readonly Bitmap _outputBitMap = new Bitmap(840, 680);

        /// <summary>
        /// Call an instance of canvas
        /// </summary>
        private readonly Canvas _myCanvas;

        /// <summary>
        /// Array to hold list of commands
        /// </summary>
        private string[] _commandList;

        public Form1()
        {
            InitializeComponent();
            _myCanvas = new Canvas(Graphics.FromImage(_outputBitMap)); // class for handling drawing
            PenColour();
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
                if (commandLine.Text == @"help")
                {
                    AllCommands();
                }
                else
                {
                    ProcessCommands();
                    commandLine.Text = "";
                }
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
            myGraph.DrawImageUnscaled(_outputBitMap, 0, 0); // put off screen bitmap on form
        }

        /// <summary>
        /// Method to process all possible commands
        /// </summary>
        private void ProcessCommands()
        {
            if (penBox.SelectedIndex > -1)
            {
                GetPenColour();
            }

            // split after trim and store in array with space delimiter
            String command = commandLine.Text.Trim().ToLower();
            _commandList = command.Split(" ");

            if (_commandList[0].Equals("moveto")) // if match, call method
            {
                MoveTo();
            }
            else if (_commandList[0].Equals("drawline"))
            {
                DrawLine();
            }
            else if (_commandList[0].Equals("square"))
            {
                DrawSquare();
            }
            else if (_commandList[0].Equals("rectangle"))
            {
                DrawRectangle();
            }
            else if (_commandList[0].Equals("circle"))
            {
                DrawCircle();
            }
            else if (_commandList[0].Equals("fill"))
            {
                _myCanvas.CheckFill(true);
            }
            else if (_commandList[0].Equals("filloff"))
            {
                _myCanvas.CheckFill(false);
            }
            else if (_commandList[0].Equals("triangle"))
            {
                DrawTriangle();
            }
            else if (_commandList[0].Equals("pencolour"))
            {
                _myCanvas.PenColourSet(_commandList[1]);
            }
            else if (_commandList[0].Equals("reset"))
            {
                ResetPen();
            }
            else if (_commandList[0].Equals("clear"))
            {
                ClearImage();
                drawBox.Refresh();
            }
            else if (_commandList[0].Equals("quit"))
            {
                Application.Exit();
            }


            Refresh();
        }

        /// <summary>
        /// Methods to draw shapes based on command input
        /// </summary>
        private void MoveTo()
        {
            try
            {
                _myCanvas.MoveTo(int.Parse(_commandList[1]),
                    int.Parse(_commandList[2]));
            }
            catch (IndexOutOfRangeException) // catch if no number has been entered after command
            {
                MessageBox.Show(@"Must enter 2 numbers after command.");
            }
        }

        private void DrawLine()
        {
            try
            {
                _myCanvas.DrawLine(int.Parse(_commandList[1]),
                    int.Parse(_commandList[2])); // use the index to determine values for shape
                commandLine.Text = (@"Line has been drawn");
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show(@"Must enter 2 numbers after command.");
            }
        }

        private void DrawSquare()
        {
            try
            {
                _myCanvas.DrawSquare(int.Parse(_commandList[1]));
                commandLine.Text = (@"Square has been drawn");
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show(@"Must enter a number after command.");
            }
        }

        private void DrawRectangle()
        {
            // try
            // {
            _myCanvas.DrawRectangle(int.Parse(_commandList[1]),
                int.Parse(_commandList[2]));
            commandLine.Text = (@"Rectangle has been drawn");

            // catch (IndexOutOfRangeException)
            // {
            //     MessageBox.Show(@"Must enter 2 numbers after command.");
            // }
        }


        private void DrawCircle()
        {
            try
            {
                _myCanvas.DrawCircle(int.Parse(_commandList[1]));
                commandLine.Text = @"Circle has been drawn.";
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show(@"Must enter a number after command.");
            }
        }

        private void DrawTriangle()
        {
            try
            {
                {
                    _myCanvas.DrawTriangle(int.Parse(_commandList[1]), int.Parse(_commandList[2]),
                        int.Parse(_commandList[3]), int.Parse(_commandList[4]));
                }
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show(@"Must enter 4 numbers after command.");
            }
        }

        /// <summary>
        /// Method to clear the bitmap on command
        /// </summary>
        private void ClearImage()
        {
            var myGraphics = Graphics.FromImage(_outputBitMap);
            myGraphics.Clear(Color.AliceBlue);
        }

        private void ResetPen()
        {
            _myCanvas.ResetPen(0, 0);
        }

        private void PenColour()
        {
            penBox.Items.Insert(0, "Blue");
            penBox.Items.Insert(1, "Red");
            penBox.Items.Insert(2, "Green");
            penBox.Items.Insert(3, "Orange");
            penBox.Items.Insert(4, "Yellow");
        }

        private void GetPenColour()
        {
            switch (penBox.SelectedIndex)
            {
                case 0:
                    _myCanvas.PenColourSet("blue");
                    break;

                case 1:
                    _myCanvas.PenColourSet("red");
                    break;

                case 2:
                    _myCanvas.PenColourSet("green");
                    break;

                case 3:
                    _myCanvas.PenColourSet("orange");
                    break;

                case 4:
                    _myCanvas.PenColourSet("yellow");
                    break;
            }
        }

        /// <summary>
        /// Method to list all commands
        /// </summary>
        private void AllCommands()
        {
            const string a = "\n|moveto" + " " + " 'number 1' " + " " + " 'number 2' " + " " + " => " + " " +
                             " moves pen position \n|reset" + " " + " => Resets pen position " +
                             "\n|drawline" + " " + " 'number 1'" + " " + " " +
                             "'number 2'" + " " + " =>" + " " + " Draws a line to given position \n|square" + " " +
                             " 'number 1'" + " " + " => " + " " + " " +
                             "Draws a square with given width \n|rectangle" + " " + "  'number 1'" + " " +
                             "  'number 2'" + " " + "  =>" + " " + "  Draws a rectangle" +
                             " with given" +
                             " width and height \n|circle" + " " + "  =>" + " " +
                             "  Draws a circle with given radius  \n|triangle" + " " + "  'number 1'" + " " + "  " +
                             "'number 2'" + " " + "  " +
                             "'number 3'" + " " + "  'number 4'" + " " + "  =>" + " " +
                             "  Draws a triangle with given" +
                             " 2 points, distance and angle \n|pencolour " + " " + " " +
                             "'colour' " + " " + " =>" + " " +
                             "  Changes pen colour to those listed in combobox  \n|clear" + " " + "  =>" + " " +
                             "  Clears " +
                             "canvas\n|quit" + " " + "  =>" + " " + "  " +
                             "Exits program";
            commandLine.Text = a;
        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    myStream.Close();
                    using (FileStream fs = File.Create(saveFileDialog1.FileName))
                    {
                        Byte[] info = new UTF8Encoding(true).GetBytes(programArea.Text);
                        // Add some information to the file.
                        fs.Write(info, 0, info.Length);
                    }
                }
            }
        }


        private void loadButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (programArea.Text == String.Empty)
                {
                    using (OpenFileDialog dlgOpen = new OpenFileDialog())
                    {
                        // Available file extensions
                        dlgOpen.Filter = "All files(*.*)|*.*";
                        // Initial directory
                        dlgOpen.InitialDirectory = "D:";
                        // OpenFileDialog title
                        dlgOpen.Title = "Open";
                        // Show OpenFileDialog box
                        if (dlgOpen.ShowDialog() == DialogResult.OK)
                        {
                            StreamReader sr = new StreamReader(dlgOpen.FileName, Encoding.Default);
                            // Get all text from the file
                            string str = sr.ReadToEnd();
                            // Close the StreamReader
                            sr.Close();
                            // Show the text in the rich textbox rtbMain
                            programArea.Text = str;
                        }
                    }
                }
            }
            catch (IOException)
            {
                MessageBox.Show(@"No such file to load!");
            }
        }
    }
}