using System.Drawing;

namespace GraphicalProgrammingEnvironment
{
    /// <summary>
    /// Class to draw a square
    /// </summary>
    public class Square
    {
        /// <summary>
        /// Define variables
        /// </summary>
        private readonly Graphics _myGraph;

        private readonly int _xPos;
        private readonly int _yPos;

        /// <summary>
        /// Method to initialise variables
        /// </summary>
        /// <param name="myGraph">Equal to the graphics defined above. Set to bitmap on form.</param>
        public Square(Graphics myGraph)
        {
            this._myGraph = myGraph; // this is referring to instance data
            _xPos = _yPos = 0;
            PenColourClass.MyPen = new Pen(Color.Black, 1); // create a standard pen
        }

        /// <summary>
        /// Method to draw square
        /// </summary>
        /// <param name="width">Specify width of square</param>
        public void DrawSquare(int width)
        {
            if (Reset._reset) // if reset bool is set to true
            {
                MoveToClass._xPos = MoveToClass._yPos = 0; // set xpos and ypos to 0
                Reset._reset = false; // set reset bool back to false
            }

            _myGraph.DrawRectangle(PenColourClass.MyPen, MoveToClass._xPos, MoveToClass._yPos,
                MoveToClass._xPos + width, MoveToClass._yPos + width);
            using Brush brush = new SolidBrush(PenColourClass.MyPen.Color);
            if (Fill._fill) // if fill bool is set to true
            {
                _myGraph.FillRectangle(brush, MoveToClass._xPos, MoveToClass._yPos, MoveToClass._xPos + width,
                    MoveToClass._yPos + width); // draw the shape but with the brush
            }
        }
    }
}