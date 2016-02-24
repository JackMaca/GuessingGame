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

            //display guesses in original order
            guessnumLabel.Text = "Guesses made: " + GuessingGame.guesses.Count();
            for (int i = 0; i < GuessingGame.guesses.Count(); i++)
            {
                ogOrder.Text += GuessingGame.guesses[i].ToString() + " ";
            }

            //sort and display guesses            
            for (int i = 0; i < GuessingGame.guesses.Count(); i++)
            {
                GuessingGame.guesses.Sort();
                sortOrder.Text += GuessingGame.guesses[i].ToString() + " ";
            }
        }
    }
}
