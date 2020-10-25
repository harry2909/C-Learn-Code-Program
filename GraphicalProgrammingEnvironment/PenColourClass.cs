using System;
using System.Drawing;

namespace GraphicalProgrammingEnvironment
{
    public static class PenColourClass
    {
        public static Pen MyPen;

        public static void PenColourSet(String penColour)
        {
            Pen[] pensArray = new[]
            {
                MyPen = new Pen(Color.Blue),
                MyPen = new Pen(Color.Red),
                MyPen = new Pen(Color.Green),
                MyPen = new Pen(Color.Orange),
                MyPen = new Pen(Color.Yellow),
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
        }
    }
}