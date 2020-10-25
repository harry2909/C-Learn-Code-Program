namespace GraphicalProgrammingEnvironment
{
    /// <summary>
    /// Class to move the pen with given x and y coordinates
    /// </summary>
    public static class MoveToClass
    {
        /// <summary>
        /// Define variables
        /// </summary>
        public static int _xPos, _yPos;

        /// <summary>
        /// Method to set the xpos and ypos to the ones entered by user
        /// </summary>
        /// <param name="toX">X position to move to</param>
        /// <param name="toY">Y position to move to</param>
        public static void MoveTo(int toX, int toY)
        {
            _xPos = toX;
            _yPos = toY;
        }
    }
}