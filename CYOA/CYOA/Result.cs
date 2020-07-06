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
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            // simply reseting H.R values for the next day to reuse this form
            if (H.R == 6)
            {
                H.R = H.R - 6;
            }
            else if (H.R == 5)
            {
                H.R = H.R - 5;
            }
            else if (H.R == 4)
            {
                H.R = H.R - 4;
            }
            else if (H.R == 3)
            {
                H.R = H.R - 3;
            }
            else if (H.R == 2)
            {
                H.R = H.R - 2;
            }
            else if (H.R == 1)
            {
                H.R = H.R - 1;
            }
            //Show lifedecision form hide this one
            this.Hide();
            H.Lifedecision500.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            // exit
            Environment.Exit(0);
        }

        private void Result_Load(object sender, EventArgs e)
        {

        }
    }
}
