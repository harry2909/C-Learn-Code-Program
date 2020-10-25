using System;
using System.Drawing;

namespace GraphicalProgrammingEnvironment
{
    public class Triangle
    {
        private readonly Graphics _myGraph;

        private int _yPos;

        public Triangle(Graphics myGraph)
        {
            this._myGraph = myGraph; // this is referring to instance data
            _yPos = 0;
            PenColourClass.MyPen = new Pen(Color.Black, 1); // create a standard pen
        }


        public void DrawTriangle(int x, int y, int distance, float angle)
        {
            if(Reset._reset)
            {
                MoveToClass._xPos = MoveToClass._yPos = 0;
                Reset._reset = false;
            }
            
            PointF[] pnt = new PointF[3];

            pnt[0].X = x;
            pnt[0].Y = y;

            pnt[1].X = (float) (x + distance * Math.Cos(angle));
            pnt[1].Y = (float) (y + distance * Math.Sin(angle));

            pnt[2].X = (float) (x + distance * Math.Cos(angle + Math.PI / 3));
            pnt[2].Y = (float) (y + distance * Math.Sin(angle + Math.PI / 3));

            _myGraph.DrawPolygon(PenColourClass.MyPen, pnt);

            using var brush = new SolidBrush(PenColourClass.MyPen.Color);
            if (Fill._fill)
            {
                _myGraph.FillPolygon(brush, pnt);
            }
        }
    }
}