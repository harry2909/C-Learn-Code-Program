using System.Drawing;

namespace GraphicalProgrammingEnvironment
{
    public class Circle
    {
        private Graphics _myGraph;
        
        Canvas a = new Canvas();
        
        public Circle(Graphics myGraph)
        {
            this._myGraph = myGraph; // this is referring to instance data
            a._xPos = a._yPos = 0;
            //a._myPen = new Pen(Color.Black, 1); // create a standard pen
        }
        
        public void DrawCircle(float radius)
        {
            _myGraph.DrawEllipse(PenColourClass._myPen, a._xPos, a._yPos, radius + radius, radius + radius);
            using var brush = new SolidBrush(PenColourClass._myPen.Color);
            if (a._fill)
            {
                _myGraph.FillEllipse(brush, a._xPos, a._yPos, radius + radius, radius + radius);
            }
        }
    }
}