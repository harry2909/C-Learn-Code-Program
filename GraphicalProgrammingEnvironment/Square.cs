using System.Drawing;

namespace GraphicalProgrammingEnvironment
{
    public class Square
    {
        private Graphics _myGraph;

        private int xPos, yPos;

        public Square(Graphics myGraph)
        {
            this._myGraph = myGraph; // this is referring to instance data
            xPos = yPos = 0;
            PenColourClass._myPen = new Pen(Color.Black, 1); // create a standard pen
        }

        public void DrawSquare(int width)
        {
            _myGraph.DrawRectangle(PenColourClass._myPen, xPos, yPos, xPos + width, yPos + width);
            using var brush = new SolidBrush(PenColourClass._myPen.Color);
            // if (_fill)
            // {
            //     _myGraph.FillRectangle(brush, _xPos, _yPos, _xPos + width, _yPos + width);
            // }
        }
    }
}