using System;
using System.Drawing;

namespace GraphicalProgrammingEnvironment
{
    public class PenColourClass
    {
        public static Pen _myPen;

        public static void PenColourSet(String penColour)
        {
            Pen[] pensArray = new[]
            {
                _myPen = new Pen(Color.Blue),
                _myPen = new Pen(Color.Red),
                _myPen = new Pen(Color.Green),
                _myPen = new Pen(Color.Orange),
                _myPen = new Pen(Color.Yellow),
            };

            if (penColour.Contains("blue"))
            {
                _myPen = pensArray[0];
            }
            else if (penColour.Contains("red"))
            {
                _myPen = pensArray[1];
            }
            else if (penColour.Contains("green"))
            {
                _myPen = pensArray[2];
            }
            else if (penColour.Contains("orange"))
            {
                _myPen = pensArray[3];
            }
            else if (penColour.Contains("yellow"))
            {
                _myPen = pensArray[4];
            }
        }
    }
}