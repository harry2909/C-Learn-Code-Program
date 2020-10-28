using System.Drawing;

namespace GraphicalProgrammingEnvironment
{
    /// <summary>
    /// Class to create circle extends shape class
    /// </summary>
    public class Circle : Shape
    {
        /// <summary>
        /// Define variables.
        /// </summary>
        private readonly Graphics _myGraph;

        private int _xPos;
        private int _yPos;

        /// <summary>
        /// Method to initialise variables.
        /// </summary>
        /// <param name="myGraph">Equal to the graphics defined above. Set to bitmap on form.</param>
        public Circle(Graphics myGraph)
        {
            this._myGraph = myGraph; // this is referring to instance data
            _xPos = _yPos = 0; // set xpos and ypos to 0 to begin with
            PenColourClass.MyPen = new Pen(Color.Black, 1); // create a standard pen
        }
        
        public Circle()
        {
        }

        public override void DrawCircle(float radius)
        {
            if (Reset._reset) // if reset bool is set to true
            {
                MoveToClass._xPos = MoveToClass._yPos = 0; // set xpos and ypos to 0
                Reset._reset = false; // set reset bool back to false
            }

            _myGraph.DrawEllipse(PenColourClass.MyPen, MoveToClass._xPos, MoveToClass._yPos, radius + radius,
                radius + radius);
            using Brush brush = new SolidBrush(PenColourClass.MyPen.Color);
            if (Fill._fill) // if fill bool is set to true
            {
                // draw the shape but with the brush
                _myGraph.FillEllipse(brush, MoveToClass._xPos, MoveToClass._yPos, radius + radius, radius + radius);
            }
        }

        
    }
}