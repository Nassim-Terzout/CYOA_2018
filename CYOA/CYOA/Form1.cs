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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            //Exit program upon click
            Environment.Exit(0);
        }

        private void Help_Click(object sender, EventArgs e)
        {
            // show first form
            this.Hide();
            H.intro.Show();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            
          

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
