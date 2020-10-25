using System.Drawing;

namespace GraphicalProgrammingEnvironment

{
    /// <summary>
    /// Canvas class holds the data from the form in response to simple commands.
    /// </summary>
    public class Canvas
    {
        public bool Fill;

        // instance data for pen, position and graphics
        // the graphics context is the area of the form to draw on
        private Graphics _myGraph;

        private static Pen _myPen;

        // the position of the pen when drawing
        private int _xPos;
        private int _yPos;

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
        

       
    }
}