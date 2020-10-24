using System.Drawing;

namespace GraphicalProgrammingEnvironment
{
    public class Circle
    {
        private Graphics _myGraph;

        private int xPos, yPos;

        public Circle(Graphics myGraph)
        {
            this._myGraph = myGraph; // this is referring to instance data
            xPos = yPos = 0;
            PenColourClass._myPen = new Pen(Color.Black, 1); // create a standard pen
        }

        public void DrawCircle(float radius)
        {
            _myGraph.DrawEllipse(PenColourClass._myPen, xPos, yPos, radius + radius, radius + radius);
            using var brush = new SolidBrush(PenColourClass._myPen.Color);
            if (Fill._fill)
            {
                _myGraph.FillEllipse(brush, xPos, yPos, radius + radius, radius + radius);
            }
        }
    }
}