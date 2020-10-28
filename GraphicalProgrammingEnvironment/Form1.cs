using System;
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
        private static readonly Bitmap OutputBitMap = new Bitmap(840, 680);

        private readonly Circle _circleDraw;

        private readonly Square _squareDraw;

        private readonly LineDrawClass _lineDraw;

        private readonly Rectangle _rectangleDraw;

        private readonly Triangle _triangleDraw;

        /// <summary>
        /// Array to hold list of commands
        /// </summary>
        private static string[] _commandList;

        private string _command;

        /// <summary>
        /// Method to initialise all variables.
        /// </summary>
        public Form1()
        {
            
            InitializeComponent();
            _circleDraw = new Circle(Graphics.FromImage(OutputBitMap));
            _squareDraw = new Square(Graphics.FromImage(OutputBitMap));
            _lineDraw = new LineDrawClass(Graphics.FromImage(OutputBitMap));
            _rectangleDraw = new Rectangle(Graphics.FromImage(OutputBitMap));
            _triangleDraw = new Triangle(Graphics.FromImage(OutputBitMap));
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
                switch (commandLine.Text)
                {
                    case @"run":
                        if (programArea.Text == String.Empty)
                        {
                            MessageBox.Show(@"Program area empty!");
                        }
                        try
                        {
                            //_commandList = command.Split(" ");
                            using (StringReader programRead = new StringReader(programArea.Text))
                            {
                                String line;
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

                        break;
                    case @"help":
                        const string a = "\n|moveto" + " " + " 'number 1' " + " " + " 'number 2' " + " " + " => " +
                                         " " +
                                         " moves pen position \n|reset" + " " + " => Resets pen position " +
                                         "\n|drawline" + " " + " 'number 1'" + " " + " " +
                                         "'number 2'" + " " + " =>" + " " +
                                         " Draws a line to given position \n|square" + " " +
                                         " 'number 1'" + " " + " => " + " " + " " +
                                         "Draws a square with given width \n|rectangle" + " " + "  'number 1'" + " " +
                                         "  'number 2'" + " " + "  =>" + " " + "  Draws a rectangle" +
                                         " with given" +
                                         " width and height \n|circle" + " " + "  =>" + " " +
                                         "  Draws a circle with given radius  \n|triangle" + " " + "  'number 1'" +
                                         " " + "  " +
                                         "'number 2'" + " " + "  " +
                                         "'number 3'" + " " + "  'number 4'" + " " + "  =>" + " " +
                                         "  Draws a triangle with given" +
                                         " 2 points, distance and angle \n|pencolour " + " " + " " +
                                         "'colour' " + " " + " =>" + " " +
                                         "  Changes pen colour to those listed in combobox  \n|clear" + " " + "  =>" +
                                         " " +
                                         "  Clears " +
                                         "canvas\n|quit" + " " + "  =>" + " " + "  " +
                                         "Exits program";
                        programArea.Text = a;
                        commandLine.Text = "";
                        break;
                    default:
                        _command = commandLine.Text.Trim().ToLower();
                        _commandList = _command.Split(" ");
                        ProcessCommands();
                        break;
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
            myGraph.DrawImageUnscaled(OutputBitMap, 0, 0); // put off screen bitmap on form
        }

        /// <summary>
        /// Method to process all possible commands entered along with error handling for empty box and unregistered commands
        /// </summary>
        private void ProcessCommands()
        {
            // if combo box is selected, get the colour
            if (penBox.SelectedIndex > -1)
            {
                GetPenColour();
            }

            // move to command
            if (_commandList[0].Equals("moveto"))
            {
                try
                {
                    if (_commandList.Length > 3)
                    {
                        MessageBox.Show(@"Too many parameters.");
                    }
                    else
                    {
                        MoveToClass.MoveTo(int.Parse(_commandList[1]),
                            int.Parse(_commandList[2]));
                    }
                }
                catch (IndexOutOfRangeException) // catch if no number has been entered after command
                {
                    MessageBox.Show(@"Must enter 2 numbers after command.");
                }
            }
            // draw line commands
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
                        _lineDraw.DrawLine(int.Parse(_commandList[1]),
                            int.Parse(_commandList[2]));
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show(@"Must enter 2 numbers after command.");
                }
            }
            // draw square command
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
                        _squareDraw.DrawSquare(int.Parse(_commandList[1]));
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show(@"Must enter a number after command.");
                }
            }
            // draw rectangle command
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
                        _rectangleDraw.DrawRectangle(int.Parse(_commandList[1]),
                            int.Parse(_commandList[2]));
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show(@"Must enter 2 numbers after command.");
                }
            }
            // draw circle command
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
                        _circleDraw.DrawCircle(int.Parse(_commandList[1]));
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show(@"Must enter a number after command.");
                }
            }
            // set fill true command
            else if (_commandList[0].Equals("fill"))
            {
                Fill.CheckFill(true);
                fillCheckBox.Checked = true;
            }
            // set fill false command
            else if (_commandList[0].Equals("filloff"))
            {
                Fill.CheckFill(false);
                fillCheckBox.Checked = false;
            }
            // draw triangle command
            else if (_commandList[0].Equals("triangle"))
            {
                try
                {
                    if (_commandList.Length > 5)
                    {
                        MessageBox.Show(@"Too many parameters.");
                    }
                    else
                    {
                        _triangleDraw.DrawTriangle(int.Parse(_commandList[1]), int.Parse(_commandList[2]),
                            int.Parse(_commandList[3]), int.Parse(_commandList[4]));
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show(@"Must enter 4 numbers after command.");
                }
            }
            // change pen colour command
            else if (_commandList[0].Equals("pencolour"))
            {
                PenColourClass.PenColourSet(_commandList[1]);
            }
            // reset pen position command
            else if (_commandList[0].Equals("reset"))
            {
                Reset.CheckReset(true);
            }
            // clear bitmap
            else if (_commandList[0].Equals("clear"))
            {
                ClearImage();
                drawBox.Refresh();
            }
            // leave application
            else if (_commandList[0].Equals("quit"))
            {
                Application.Exit();
            }
            // if nothing entered throw message
            else if (_commandList[0] == String.Empty)
            {
                MessageBox.Show(@"No command entered!");
            }
            // if no command recognised show error 
            else
            {
                MessageBox.Show(@"Command not recognised!");
            }

            commandLine.Text = "";
            Refresh();
        }

        /// <summary>
        /// Method to clear the bitmap on command
        /// </summary>
        private void ClearImage()
        {
            Graphics myGraphics = Graphics.FromImage(OutputBitMap);
            myGraphics.Clear(Color.AliceBlue);
        }

        /// <summary>
        /// Set pen colours into the combobox with respective index value
        /// </summary>
        private void PenColour()
        {
            penBox.Items.Insert(0, "Blue");
            penBox.Items.Insert(1, "Red");
            penBox.Items.Insert(2, "Green");
            penBox.Items.Insert(3, "Orange");
            penBox.Items.Insert(4, "Yellow");
        }

        /// <summary>
        /// Method to get the colour of the pen based on the combobox value
        /// </summary>
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
        /// <param name="e">Event data</param>
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

        /// <summary>
        /// Method to change fill to true or false depending on checkbox state.
        /// </summary>
        /// <param name="sender">The object that will trigger event (checkbox)</param>
        /// <param name="e">Event data</param>
        private void fillCheckBox_Click(object sender, EventArgs e)
        {
            Fill.CheckFill(fillCheckBox.Checked);
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (programArea.Text == String.Empty)
                {
                    MessageBox.Show(@"Program area empty!");
                }
                //_commandList = command.Split(" ");
                using (StringReader programRead = new StringReader(programArea.Text))
                {
                    String line;
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
    }
}