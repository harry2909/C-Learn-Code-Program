using System.Drawing;

namespace GraphicalProgrammingEnvironment
{
    public class LineDrawClass
    {
        private Graphics _myGraph;

        private int xPos, yPos;

        public LineDrawClass(Graphics myGraph)
        {
            this._myGraph = myGraph; // this is referring to instance data
            xPos = yPos = 0;
            //a._myPen = new Pen(Color.Black, 1); // create a standard pen
        }
        
        public void DrawLine(int toX, int toY)
        {
            _myGraph.DrawLine(PenColourClass._myPen, xPos, yPos, toX, toY);
            xPos = toX; // current x position is updated to where the lined is drawn to
            yPos = toY; // current y position is updated to where the lined is drawn to
        }
    }
}