using System.Drawing;

namespace GraphicalProgrammingEnvironment
{
    public class Circle
    {
        private readonly Graphics _myGraph;

        private int _xPos;
        private int _yPos;

        public Circle(Graphics myGraph)
        {
            this._myGraph = myGraph; // this is referring to instance data
            _xPos = _yPos = 0;
            PenColourClass.MyPen = new Pen(Color.Black, 1); // create a standard pen
        }

        public void DrawCircle(float radius)
        {
            if(Reset._reset)
            {
                MoveToClass._xPos = MoveToClass._yPos = 0;
                Reset._reset = false;
            }
            _myGraph.DrawEllipse(PenColourClass.MyPen, MoveToClass._xPos, MoveToClass._yPos, radius + radius, radius + radius);
            using var brush = new SolidBrush(PenColourClass.MyPen.Color);
            if (Fill._fill)
            {
                _myGraph.FillEllipse(brush, MoveToClass._xPos, MoveToClass._yPos, radius + radius, radius + radius);
            }
        }
    }
}