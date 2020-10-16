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
        Bitmap OutputBitMap = new Bitmap(640, 480);

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
                // splitting text on space
                String command = commandLine.Text.Trim().ToLower();

                // output array in loop
                Console.Write(command);
                if (command.Equals("line") == true)
                {
                    MyCanvas.DrawLine(160, 120);
                    Console.WriteLine("Line has been drawn");
                }

                commandLine.Text = "";
                Refresh();
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
    }
}