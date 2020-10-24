namespace GraphicalProgrammingEnvironment
{
    public class Fill
    {
        public static bool _fill;
        
        public void CheckFill(bool check)
        {
            if (check)
            {
                _fill = true;
            }
            else
            {
                _fill = false;
            }
        }
    }
}