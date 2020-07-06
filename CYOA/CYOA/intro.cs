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
    public partial class intro : Form
    {
        public intro()
        {
            InitializeComponent();
        }


        private void Next_Click(object sender, EventArgs e)
        {
            // setting up users desired name...
            //If user does not input anything show Messagebox!
            //hide this form show the next.
            if (input.Text == "")
            {
                MessageBox.Show("You need a name first!");
            }
            else
            {
                //also set day as 1 to begin game and set up all other timers to work accordingly
                H.day = 1;
                H.Usern = input.Text;
                this.Hide();
                H.Day1.Show();
            }
    }

        private void Exit_Click(object sender, EventArgs e)
        {
            // exit on click
            Environment.Exit(0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void intro_Load(object sender, EventArgs e)
        {

        }
    }
}
