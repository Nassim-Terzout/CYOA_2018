using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CYOA
{
    public partial class Passit : Form
    {
        
        public Passit()
        {
            InitializeComponent();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            // Check all passwords and what day it is to allow user to pass or not.
            // user messagebox to tell them when they're wrong.
            // if correct.... add to day count before showing next form to ensure that the riddles for the next day are ready.
            // show next form but only if correct for that day hence the && H.daycount == "x"
            if (password.Text == "Envelope" || password.Text == "envelope" && H.daycount == 0)
            {

                H.daycount++;
                this.Hide();
                H.Trade1.Show();
            }
            else if (password.Text == "B" || password.Text == "b" && H.daycount == 1)
            {
                
                H.daycount++;
                this.Hide();
                H.Trade1.Show();
            }
            else if (password.Text == "Rain" || password.Text == "rain" && H.daycount == 2)
            {
                
                H.daycount++;
                this.Hide();
                H.Trade1.Show();
            }
            else if (password.Text == "Short" || password.Text == "short" && H.daycount == 3)
            {
                
                H.daycount++;
                this.Hide();
                H.Trade1.Show();
            }
            else if (password.Text == "Silence" || password.Text == "silence" && H.daycount == 4)
            {
                
                H.daycount++;
                this.Hide();
                H.Trade1.Show();
            }
            else
            {
                MessageBox.Show("Wrong answer! Try again.");
            }
        }

        private void Passit_Load(object sender, EventArgs e)
        {

        }

        private void daycounter_Tick(object sender, EventArgs e)
        {
            // Keeping up to date with the day label "dayx"
            // Also welcoming the user by using the stored name in usern.
            //Change the hint/riddle based on what day it is daycount.
            //daycount is a global variable set specifically for this form.
            // based on daycount the riddles will change.


            Dayx.Text = "Day " + H.day; // LOOK HERE!
            UserName.Text = "Welcome " + H.Usern;
            //-----------------------------------------------------------------------
            if (H.daycount == 0)
            {
                hint.Text = "Name a single word that starts with e, ends with e, and has a letter inside?";
            }
            else if (H.daycount == 1)
            {
                hint.Text = "How would you spell a bear without an ear";
            }
            else if (H.daycount == 2)
            {
                hint.Text = "What comes down but never goes up?";
            }
            else if (H.daycount == 3)
            {
                hint.Text = "What word becomes shorter when you add 2 letters to it?";
            }
            else if (H.daycount == 4)
            {
                hint.Text = "When you say it you break it";
            }


        }

        private void Exit_Click(object sender, EventArgs e)
        {
            // exit on click
            Environment.Exit(0);
        }

        private void hint_Click(object sender, EventArgs e)
        {

        }

        private void Explanation_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // disable all help present
            // add to daycount to start up the first riddle for the first day.
            //change up colors and visibility to create an allusion
            H.daycount++;
            Firstnext.Visible = false;
            Next.Visible = true;
            Explanation.Visible = false;
            password.Enabled = true;
            hint.ForeColor = Color.Yellow;
            hint.BackColor = Color.Transparent;

            
           // this.Hide();
           // H.Day1.Show();
            
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void userimg_Click(object sender, EventArgs e)
        {

        }
    }
}
