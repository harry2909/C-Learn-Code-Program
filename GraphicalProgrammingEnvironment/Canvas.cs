using System;
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
        Graphics myGraph;

        Pen myPen;

        // the position of the pen when drawing
        int xPos, yPos;

        /// <summary>
        /// Constructor initialises canvas.
        /// </summary>
        /// <param name="myGraph">Graphics context</param>
        public Canvas(Graphics myGraph)
        {
            this.myGraph = myGraph; // this is referring to instance data
            xPos = yPos = 0;
            myPen = new Pen(Color.White, 1); // create a standard pen
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
            myGraph.DrawLine(myPen, xPos, yPos, toX, toY);
            xPos = toX; // current x position is updated to where the lined is drawn to
            yPos = toY; // current y position is updated to where the lined is drawn to
        }

        public void DrawSquare(int width)
        {
            myGraph.DrawRectangle(myPen, xPos, yPos, xPos + width, yPos + width);
        }

        public void DrawRectangle(int width, int height)
        {
            myGraph.DrawRectangle(myPen, xPos, yPos, xPos + width, yPos + height);
        }

        public void DrawCircle(float radius)
        {
            myGraph.DrawEllipse(myPen, xPos, yPos, radius + radius, radius + radius);
        }

        public void MoveTo(int toX, int toY)
        {
            xPos = toX;
            yPos = toY;
        }

        public void ResetPen(int toX, int toY)
        {
            xPos = toX;
            yPos = toY;
        }

        public void DrawTriangle(int xPos, int yPos, int xPos2, int yPos2, int xPos3, int yPos3)
        {
            Point[] pnt = new Point[3];

            pnt[0].X = xPos;
            pnt[0].Y = yPos;
            
            pnt[1].X = xPos2;
            pnt[1].Y = yPos2;
            
            pnt[2].X = xPos3;
            pnt[2].Y = yPos3;
            
            myGraph.DrawPolygon(myPen, pnt);
        }
    }
}