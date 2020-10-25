using System.Drawing;

namespace GraphicalProgrammingEnvironment
{
    public class Rectangle
    {
        
        private readonly Graphics _myGraph;

        private readonly int _xPos;
        private readonly int _yPos;

        public Rectangle(Graphics myGraph)
        {
            this._myGraph = myGraph; // this is referring to instance data
            _xPos = _yPos = 0;
            PenColourClass.MyPen = new Pen(Color.Black, 1); // create a standard pen
        }
        
        public void DrawRectangle(int width, int height)
        {if(Reset._reset)
            {
                MoveToClass._xPos = MoveToClass._yPos = 0;
                Reset._reset = false;
            }
            _myGraph.DrawRectangle(PenColourClass.MyPen, MoveToClass._xPos, MoveToClass._yPos, MoveToClass._xPos + width, MoveToClass._yPos + height);


            using var brush = new SolidBrush(PenColourClass.MyPen.Color);
            if (Fill._fill)
            {
                _myGraph.FillRectangle(brush, MoveToClass._xPos, MoveToClass._yPos, MoveToClass._xPos + width, MoveToClass._yPos + height);
            }
        }
    }
}