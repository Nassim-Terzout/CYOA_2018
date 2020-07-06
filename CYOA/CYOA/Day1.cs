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
    public partial class Day1 : Form
    {
        public Day1()
        {
            InitializeComponent();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            //close this form and show the next
            // Just a day reminder
            //tutorial is only for the first day so it is not recalled
            tutorial4.Visible = false;
            this.Hide();
            H.Pass1.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            //exit
            Environment.Exit(0);
        }
    }
}
