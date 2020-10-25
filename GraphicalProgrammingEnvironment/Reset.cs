namespace GraphicalProgrammingEnvironment
{
    /// <summary>
    /// Class to reset pen position
    /// </summary>
    public static class Reset
    {
        /// <summary>
        /// Define variables
        /// </summary>
        public static bool _reset;

        /// <summary>
        /// resetCheck set to true or false based on command
        /// </summary>
        /// <param name="resetCheck"></param>
        public static void CheckReset(bool resetCheck)
        {
            _reset = resetCheck;
        }
    }
}