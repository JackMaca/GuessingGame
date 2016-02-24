using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class GuessingGame : UserControl
    {
        //creates a random number between 1 and 100 and stores it in a global 
        //variable that can be used throughout the program 
        public static Random randNum = new Random();
        int rand = randNum.Next(1, 101);

        //# of guesses
        public static int guessnum = new Int32();

        //list of guesses
        public static List<int> guesses = new List<int>();

        //# of things in the list
        public GuessingGame()
        {
            InitializeComponent();
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            // get the users guess and place into a variable
            int guess = Convert.ToInt16(inputBox.Text);

            //adds users guess to list of guesses
            guesses.Add(guess);

            // check guess against the random value and output appropriate message
            if (guess < rand)
            {
                outputLabel.Text = "Too Low!";
            }
            else if (guess > rand)
            {
                outputLabel.Text = "Too High!";
            }
            else
            {
                outputLabel.Text = "You Got it!";

                //show you got it label for 2 seconds
                Refresh();
                Thread.Sleep(2000);

                //remove form and display results
                Form f = this.FindForm();
                f.Controls.Remove(this);

                Statistics st = new Statistics();
                f.Controls.Add(st);
                st.Location = new Point((this.Width - this.Width) / 2, (this.Height - this.Height) / 2);
                st.Show();
            }

            // clear out the input box 
            inputBox.Text = "";
        }
    }
}
