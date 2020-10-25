using System;
using System.Drawing;
using System.Windows.Forms;

namespace GraphicalProgrammingEnvironment
{
    /// <summary>
    /// Class to set the pen colour
    /// </summary>
    public static class PenColourClass
    {
        /// <summary>
        /// Define new pen
        /// </summary>
        public static Pen MyPen;

        /// <summary>
        /// This method defines array of pen colours, then gets the correct index from array based on user input
        /// </summary>
        /// <param name="penColour">A colour entered in form of string is then checked in the method and if
        /// registered sets the corresponding index.</param>
        public static void PenColourSet(String penColour)
        {
            Pen[] pensArray = new[]
            {
                MyPen = new Pen(Color.Blue),
                MyPen = new Pen(Color.Red),
                MyPen = new Pen(Color.Green),
                MyPen = new Pen(Color.Orange),
                MyPen = new Pen(Color.Yellow),
                MyPen = new Pen(Color.Magenta),
            };

            if (penColour.Contains("blue"))
            {
                MyPen = pensArray[0];
            }
            else if (penColour.Contains("red"))
            {
                MyPen = pensArray[1];
            }
            else if (penColour.Contains("green"))
            {
                MyPen = pensArray[2];
            }
            else if (penColour.Contains("orange"))
            {
                MyPen = pensArray[3];
            }
            else if (penColour.Contains("yellow"))
            {
                MyPen = pensArray[4];
            }
            else if (penColour.Contains("magenta"))
            {
                MyPen = pensArray[5];
            }
            // if no colour recognised show error
            else
            {
                MessageBox.Show(@"Pen colour not recognised.");
            }
        }
    }
}