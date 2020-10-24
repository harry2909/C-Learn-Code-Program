using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Linq;
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

        private Circle circleDraw;

        private Square squareDraw;

        private LineDrawClass lineDraw;

        private Fill fillShape;

        private Rectangle rectangleDraw;


        /// <summary>
        /// Array to hold list of commands
        /// </summary>
        private string[] _commandList;

        private string command;

        public Form1()
        {
            InitializeComponent();
            _myCanvas = new Canvas(Graphics.FromImage(_outputBitMap)); // class for handling drawing
            circleDraw = new Circle(Graphics.FromImage(_outputBitMap));
            squareDraw = new Square(Graphics.FromImage(_outputBitMap));
            lineDraw = new LineDrawClass(Graphics.FromImage(_outputBitMap));
            fillShape = new Fill();
            rectangleDraw = new Rectangle(Graphics.FromImage(_outputBitMap));
            
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
                if (commandLine.Text == @"run")
                {
                    try
                    {
                        //_commandList = command.Split(" ");
                        //int lineCount = 0;
                        String line;
                        using (StringReader programRead = new StringReader(programArea.Text))
                        {
                            while ((line = programRead.ReadLine()) != null)
                            {
                                _commandList = line.Split(" ");
                                //lineCount++;
                                ProcessCommands();
                            }
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(@"Input box empty");
                    }
                }
                else if (commandLine.Text == @"help")
                {
                    AllCommands();
                }
                else
                {
                    // try
                    // {
                    command = commandLine.Text.Trim().ToLower();
                    _commandList = command.Split(" ");
                    ProcessCommands();
                }

                // catch (Exception)
                // {
                //     MessageBox.Show(@"Command not recognised! Type help to list all commands.");
                // }
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

            if (_commandList[0].Equals("moveto")) // if match, call method
            {
                MoveTo();
            }
            else if (_commandList[0].Equals("drawline"))
            {
                try
                {
                    if (_commandList.Length > 3)
                    {
                        MessageBox.Show(@"Too many parameters.");
                    }
                    else
                    {
                        lineDraw.DrawLine(int.Parse(_commandList[1]),
                            int.Parse(_commandList[2])); // use the index to determine values for shape
                        //commandLine.Text = (@"Line has been drawn");
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show(@"Must enter 2 numbers after command.");
                }
            }
            else if (_commandList[0].Equals("square"))
            {
                try
                {
                    if (_commandList.Length > 2)
                    {
                        MessageBox.Show(@"Too many parameters.");
                    }
                    else
                    {
                        squareDraw.DrawSquare(int.Parse(_commandList[1]));
                        //commandLine.Text = (@"Square has been drawn");
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show(@"Must enter a number after command.");
                }
            }
            else if (_commandList[0].Equals("rectangle"))
            {
                try
                {
                    if (_commandList.Length > 3)
                    {
                        MessageBox.Show(@"Too many parameters.");
                    }
                    else
                    {
                        rectangleDraw.DrawRectangle(int.Parse(_commandList[1]),
                            int.Parse(_commandList[2]));
                        //commandLine.Text = (@"Rectangle has been drawn");
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show(@"Must enter 2 numbers after command.");
                }
            }
            else if (_commandList[0].Equals("circle"))
            {
                try
                {
                    if (_commandList.Length > 2)
                    {
                        MessageBox.Show(@"Too many parameters.");
                    }
                    else
                    {
                        circleDraw.DrawCircle(int.Parse(_commandList[1]));
                        //commandLine.Text = @"Circle has been drawn.";
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show(@"Must enter a number after command.");
                }
            }
            else if (_commandList[0].Equals("fill"))
            {
                fillShape.CheckFill(true);
            }
            else if (_commandList[0].Equals("filloff"))
            {
                fillShape.CheckFill(false);
            }
            else if (_commandList[0].Equals("triangle"))
            {
                DrawTriangle();
            }
            else if (_commandList[0].Equals("pencolour"))
            {
                PenColourClass.PenColourSet(_commandList[1]);
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
            else
            {
                MessageBox.Show(@"Command not recognised!.");
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
                if (_commandList.Length > 3)
                {
                    MessageBox.Show(@"Too many parameters.");
                }
                else
                {
                    _myCanvas.MoveTo(int.Parse(_commandList[1]),
                        int.Parse(_commandList[2]));
                }
            }
            catch (IndexOutOfRangeException) // catch if no number has been entered after command
            {
                MessageBox.Show(@"Must enter 2 numbers after command.");
            }
        }

        private void DrawTriangle()
        {
            try
            {
                if (_commandList.Length > 5)
                {
                    MessageBox.Show(@"Too many parameters.");
                }
                else
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
                    PenColourClass.PenColourSet("blue");
                    break;

                case 1:
                    PenColourClass.PenColourSet("red");
                    break;

                case 2:
                    PenColourClass.PenColourSet("green");
                    break;

                case 3:
                    PenColourClass.PenColourSet("orange");
                    break;

                case 4:
                    PenColourClass.PenColourSet("yellow");
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


        /// <summary>
        /// Create a method that opens up a save file dialogue and writes to that file using filestream
        /// </summary>
        /// <param name="sender">The object that will trigger event</param>
        /// <param name="e">Key event data</param>
        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                var saveFileDialog1 = new SaveFileDialog
                {
                    Filter = @"txt files (*.txt)|*.txt|All files (*.*)|*.*", FilterIndex = 2, RestoreDirectory = true
                };

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Stream myStream;
                    if ((myStream = saveFileDialog1.OpenFile()) != null)
                    {
                        myStream.Close();
                        using FileStream fs = File.Create(saveFileDialog1.FileName);
                        var info = new UTF8Encoding(true).GetBytes(programArea.Text);
                        // Add some information to the file.
                        fs.Write(info, 0, info.Length);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(@"Error with file.");
            }
        }


        /// <summary>
        /// Create method to load in a file using openfiledialogue and then use a stream reader to display in textbox
        /// </summary>
        /// <param name="sender">The object that will trigger event</param>
        /// <param name="e">Key event data</param>
        private void loadButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (programArea.Text == String.Empty)
                {
                    using (OpenFileDialog dlgOpen = new OpenFileDialog())
                    {
                        // Available file extensions
                        dlgOpen.Filter = @"All files(*.*)|*.*";
                        // Initial directory
                        dlgOpen.InitialDirectory = "D:";
                        // OpenFileDialog title
                        dlgOpen.Title = @"Open";
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
            catch (FileNotFoundException)
            {
                MessageBox.Show(@"No such file to load!");
            }
        }
    }
}