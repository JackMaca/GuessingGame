/// Description: The program generates a random number between 1-100 which
///              the user must guess
/// Author:      Mr. T

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class Form1 : Form
    {
        ////creates a random number between 1 and 100 and stores it in a global 
        ////variable that can be used throughout the program 
        //public static Random randNum = new Random();
        //int rand = randNum.Next(1, 101);
        public Form1()
        {
            InitializeComponent();
            GuessingGame gg = new GuessingGame();
            this.Controls.Add(gg);
            gg.Location = new Point((this.Width - gg.Width) / 2, (this.Height - gg.Height) / 2);
            gg.Show();

        }
    }
}
