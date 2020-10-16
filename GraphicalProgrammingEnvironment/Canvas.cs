using System.Drawing;

namespace GraphicalProgrammingEnvironment

{
    /// <summary>
    /// Canvas class holds the data from the form in response to simple commands.
    /// </summary>
    class Canvas
    {
     // create variable for pen, position and graphics
     // the graphics context is the area of the form to draw on
     private Graphics graph;
     private Pen myPen;

     /// <summary>
     /// Creating getter and setter for pen
     /// </summary>
     public Pen MyPen
     {
         set => myPen = new Pen(Color.FromArgb(239, 236, 245));
         get => myPen;
         
     }

     /// <summary>
     /// Constructor initialises canvas
     /// </summary>
     /// <param name="graph">Graphics context of place to draw</param>
     public Canvas(Graphics graph)
     {
         this.graph = graph;
     }
     
     

     // the position of the pen when drawing
     private int xPos, yPos;
    }
}