namespace GraphicalProgrammingEnvironment
{
    /// <summary>
    /// Class to set boolean true or false depending on user input
    /// </summary>
    public class Fill
    {
        /// <summary>
        /// Define variable
        /// </summary>
        public static bool _fill;
        
        /// <summary>
        /// Method to check if bool is set
        /// </summary>
        /// <param name="check">Set to true or false based on command</param>
        public static void CheckFill(bool check)
        {
            _fill = check;
        }
    }
}