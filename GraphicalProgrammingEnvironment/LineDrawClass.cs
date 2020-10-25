using System.Drawing;

namespace GraphicalProgrammingEnvironment
{
    public class LineDrawClass
    {
        private readonly Graphics _myGraph;

        private int _xPos, _yPos;

        public LineDrawClass(Graphics myGraph)
        {
            this._myGraph = myGraph; // this is referring to instance data
            _xPos = _yPos = 0;
            PenColourClass.MyPen = new Pen(Color.Black, 1); // create a standard pen
        }
        
        public void DrawLine(int toX, int toY)
        {
            
            _myGraph.DrawLine(PenColourClass.MyPen, MoveToClass._xPos, MoveToClass._yPos, toX, toY);
            _xPos = toX; // current x position is updated to where the lined is drawn to
            _yPos = toY; // current y position is updated to where the lined is drawn to
        }
    }
}