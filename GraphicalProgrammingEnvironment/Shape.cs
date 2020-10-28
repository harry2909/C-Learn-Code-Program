namespace GraphicalProgrammingEnvironment
{
    public class Shape
    {
        public virtual void DrawCircle(float radius)
        {
            radius = 0;
        }

        public virtual void DrawLine(int toX, int toY)
        {
            toX = 0;
            toY = 0;
        }

        public virtual void DrawRectangle(int width, int height)
        {
            width = 0;
            height = 0;
        }

        public virtual void DrawSquare(int width)
        {
            width = 0;
        }

        public virtual void DrawTriangle(int x, int y, int distance, float angle)
        {
            x = y = distance = 0;
            angle = 0;
        }
        
    }
}