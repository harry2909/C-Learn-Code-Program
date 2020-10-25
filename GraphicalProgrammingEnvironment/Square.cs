using System.Drawing;

namespace GraphicalProgrammingEnvironment
{
    public class Square
    {
        private readonly Graphics _myGraph;

        private readonly int _xPos;
        private readonly int _yPos;

        public Square(Graphics myGraph)
        {
            this._myGraph = myGraph; // this is referring to instance data
            _xPos = _yPos = 0;
            PenColourClass.MyPen = new Pen(Color.Black, 1); // create a standard pen
        }

        public void DrawSquare(int width)
        {if(Reset._reset)
            {
                MoveToClass._xPos = MoveToClass._yPos = 0;
                Reset._reset = false;
            }
            _myGraph.DrawRectangle(PenColourClass.MyPen, MoveToClass._xPos, MoveToClass._yPos, MoveToClass._xPos + width, MoveToClass._yPos + width);
            using var brush = new SolidBrush(PenColourClass.MyPen.Color);
            if (Fill._fill)
            {
                _myGraph.FillRectangle(brush, MoveToClass._xPos, MoveToClass._yPos, MoveToClass._xPos + width, MoveToClass._yPos + width);
            }
        }
    }
}