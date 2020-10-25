﻿using System.Drawing;

namespace GraphicalProgrammingEnvironment
{
    public class Circle
    {
        /// <summary>
        /// Define variables.
        /// </summary>
        private readonly Graphics _myGraph;

        private int _xPos;
        private int _yPos;

        /// <summary>
        /// Create class to initialise variables.
        /// </summary>
        /// <param name="myGraph">myGraph is equal to the graphics defined above.</param>
        public Circle(Graphics myGraph)
        {
            this._myGraph = myGraph; // this is referring to instance data
            _xPos = _yPos = 0; // set xpos and ypos to 0 to begin with
            PenColourClass.MyPen = new Pen(Color.Black, 1); // create a standard pen
        }

        /// <summary>
        /// Public method used to draw the line. Uses the xpos and ypos from moveto class.
        /// </summary>
        /// <param name="radius">Set radius of circle</param>
        public void DrawCircle(float radius)
        {
            if (Reset._reset) // if reset bool is set to true
            {
                MoveToClass._xPos = MoveToClass._yPos = 0; // set xpos and ypos to 0
                Reset._reset = false; // set reset bool back to false
            }

            _myGraph.DrawEllipse(PenColourClass.MyPen, MoveToClass._xPos, MoveToClass._yPos, radius + radius,
                radius + radius);
            using var brush = new SolidBrush(PenColourClass.MyPen.Color);
            if (Fill._fill) // if fill bool is set to true
            {
                // draw the shape but with the brush
                _myGraph.FillEllipse(brush, MoveToClass._xPos, MoveToClass._yPos, radius + radius, radius + radius);
            }
        }
    }
}