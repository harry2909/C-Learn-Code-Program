using System.Drawing;

namespace GraphicalProgrammingEnvironment
{
    public class Rectangle
    {
        
        private Graphics _myGraph;

        private int xPos, yPos;

        public Rectangle(Graphics myGraph)
        {
            this._myGraph = myGraph; // this is referring to instance data
            xPos = yPos = 0;
            PenColourClass._myPen = new Pen(Color.Black, 1); // create a standard pen
        }
        
        public void DrawRectangle(int width, int height)
        {
            _myGraph.DrawRectangle(PenColourClass._myPen, xPos, yPos, xPos + width, yPos + height);


            using var brush = new SolidBrush(PenColourClass._myPen.Color);
            if (Fill._fill)
            {
                _myGraph.FillRectangle(brush, xPos, yPos, xPos + width, yPos + height);
            }
        }
    }
}