using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicalProgrammingEnvironment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /**
         * Creating method to handle enter key event
         */
        private void commandLine_KeyDown(object sender, KeyEventArgs e)
        {
            {
                Console.WriteLine("Hello");
                if (e.KeyCode == Keys.Enter)
                {
                    Console.WriteLine("You have pressed enter");
                }
            }
        }
    }
}