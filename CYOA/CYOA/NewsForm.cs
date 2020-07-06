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
    public partial class NewsForm : Form
    {
        public NewsForm()
        {
            InitializeComponent();
        }

        private void Firstnext_Click(object sender, EventArgs e)
        {
            // hide and return to trade1
            this.Hide();
            H.Trade1.Show();
        }

        private void textloops_Tick(object sender, EventArgs e)
        {
           
            {

            }
        }

        private void Newssir_Click(object sender, EventArgs e)
        {

        }
    }
}
