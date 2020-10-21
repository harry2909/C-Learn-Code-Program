using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace GraphicalProgrammingEnvironment

{
    /// <summary>
    /// Canvas class holds the data from the form in response to simple commands.
    /// </summary>
    public class Canvas
    {
        // instance data for pen, position and graphics
        // the graphics context is the area of the form to draw on
        private readonly Graphics _myGraph;

        private Pen _myPen;

        // the position of the pen when drawing
        private int _xPos, _yPos;

        private ComboBox penBox;

        /// <summary>
        /// Constructor initialises canvas.
        /// </summary>
        /// <param name="myGraph">Graphics context</param>
        public Canvas(Graphics myGraph)
        {
            this._myGraph = myGraph; // this is referring to instance data
            _xPos = _yPos = 0;
            _myPen = new Pen(Color.Black, 1); // create a standard pen
        }

        /// <summary>
        /// Create new Canvas method to call in testing class
        /// </summary>
        public Canvas()
        {
        }

        /// <summary>
        /// Create a method to draw a line from current pen position
        /// </summary>
        /// <param name="toX">x position to draw to</param>
        /// <param name="toY">y position to draw to</param>
        public void DrawLine(int toX, int toY)
        {
            _myGraph.DrawLine(_myPen, _xPos, _yPos, toX, toY);
            _xPos = toX; // current x position is updated to where the lined is drawn to
            _yPos = toY; // current y position is updated to where the lined is drawn to
        }

        public void DrawSquare(int width)
        {
            _myGraph.DrawRectangle(_myPen, _xPos, _yPos, _xPos + width, _yPos + width);
        }

        public void DrawRectangle(int width, int height)
        {
            _myGraph.DrawRectangle(_myPen, _xPos, _yPos, _xPos + width, _yPos + height);
        }

        public void DrawCircle(float radius)
        {
            _myGraph.DrawEllipse(_myPen, _xPos, _yPos, radius + radius, radius + radius);
        }

        public void MoveTo(int toX, int toY)
        {
            _xPos = toX;
            _yPos = toY;
        }

        public void ResetPen(int toX, int toY)
        {
            _xPos = toX;
            _yPos = toY;
        }

        public void DrawTriangle(int xPos, int yPos, int xPos2, int yPos2, int xPos3, int yPos3)
        {
            var pnt = new Point[3];

            pnt[0].X = xPos;
            pnt[0].Y = yPos;

            pnt[1].X = xPos2;
            pnt[1].Y = yPos2;

            pnt[2].X = xPos3;
            pnt[2].Y = yPos3;

            _myGraph.DrawPolygon(_myPen, pnt);
        }


        public void PenColourSet(String penColour)
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