using System;
using System.Drawing;

namespace GraphicalProgrammingEnvironment

{
    /// <summary>
    /// Canvas class holds the data from the form in response to simple commands.
    /// </summary>
    public class Canvas
    {
        public bool _fill;

        // instance data for pen, position and graphics
        // the graphics context is the area of the form to draw on
        public Graphics _myGraph;

        public static Pen _myPen;

        // the position of the pen when drawing
        public int _xPos, _yPos;

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
            using var brush = new SolidBrush(_myPen.Color);
            if (_fill)
            {
                _myGraph.FillRectangle(brush, _xPos, _yPos, _xPos + width, _yPos + width);
            }
        }

        public void DrawRectangle(int width, int height)
        {
            _myGraph.DrawRectangle(_myPen, _xPos, _yPos, _xPos + width, _yPos + height);


            using var brush = new SolidBrush(_myPen.Color);
            if (_fill)
            {
                _myGraph.FillRectangle(brush, _xPos, _yPos, _xPos + width, _yPos + height);
            }
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

        public void DrawTriangle(int x, int y, int distance, float angle)
        {
            PointF[] pnt = new PointF[3];

            pnt[0].X = x;
            pnt[0].Y = y;

            pnt[1].X = (float) (x + distance * Math.Cos(angle));
            pnt[1].Y = (float) (y + distance * Math.Sin(angle));

            pnt[2].X = (float) (x + distance * Math.Cos(angle + Math.PI / 3));
            pnt[2].Y = (float) (y + distance * Math.Sin(angle + Math.PI / 3));

            _myGraph.DrawPolygon(_myPen, pnt);

            using var brush = new SolidBrush(_myPen.Color);
            if (_fill)
            {
                _myGraph.FillPolygon(brush, pnt);
            }
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
                Canvas._myPen = pensArray[0];
            }
            else if (penColour.Contains("red"))
            {
                Canvas._myPen = pensArray[1];
            }
            else if (penColour.Contains("green"))
            {
                Canvas._myPen = pensArray[2];
            }
            else if (penColour.Contains("orange"))
            {
                Canvas._myPen = pensArray[3];
            }
            else if (penColour.Contains("yellow"))
            {
                Canvas._myPen = pensArray[4];
            }
        }

       

        public void CheckFill(bool check)
        {
            if (check)
            {
                _fill = true;
            }
            else
            {
                _fill = false;
            }
        }
    }
}