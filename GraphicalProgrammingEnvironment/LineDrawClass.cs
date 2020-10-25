using System.Drawing;

namespace GraphicalProgrammingEnvironment
{
    public class LineDrawClass
    {
        /// <summary>
        /// Define variables to be used in class.
        /// </summary>
        private readonly Graphics _myGraph;

        private int _xPos, _yPos;

        /// <summary>
        /// Public class to initialise the variables.
        /// </summary>
        /// <param name="myGraph">myGraph is equal to the graphics defined above.</param>
        public LineDrawClass(Graphics myGraph)
        {
            this._myGraph = myGraph; // this is referring to instance data
            _xPos = _yPos = 0; // set xpos and ypos to 0 to begin with
            PenColourClass.MyPen = new Pen(Color.Black, 1); // create a standard pen
        }

        /// <summary>
        /// Public method used to draw the line. Uses the xpos and ypos from moveto class.
        /// </summary>
        /// <param name="toX">The x pos to move to</param>
        /// <param name="toY">The y pos to move to</param>
        public void DrawLine(int toX, int toY)
        {
            if (Reset._reset) // if reset bool is set to true
            {
                MoveToClass._xPos = MoveToClass._yPos = 0; // set xpos and ypos to 0
                Reset._reset = false; // set reset bool back to false
            }

            _myGraph.DrawLine(PenColourClass.MyPen, MoveToClass._xPos, MoveToClass._yPos, toX, toY);
            _xPos = toX; // current x position is updated to where the lined is drawn to
            _yPos = toY; // current y position is updated to where the lined is drawn to
        }
    }
}