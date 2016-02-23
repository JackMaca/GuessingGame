using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class Statistics : UserControl
    {
        public Statistics()
        {
            InitializeComponent();

            guessnumLabel.Text = "Guesses made: " + GuessingGame.guessnum.ToString();
            ogOrder.Text = guesses;
            sortOrder.Text = "";
        }
    }
}
