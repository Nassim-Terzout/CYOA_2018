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
    public partial class path2 : Form
    {
        public path2()
        {
            InitializeComponent();
        }

        private void HUD_Tick(object sender, EventArgs e)
        {
            //HUD again
            Welcome.Text = H.Usern;
            money.Text = "" + H.M;
            if (H.Mood == 3 || H.Mood == 4 || H.Mood == 5 || H.Mood == 6 || H.Mood == 7)
            {
                userimg.BackgroundImage = CYOA.Properties.Resources.Mild;
            }
            else if (H.Mood >= 8)
            {
                userimg.BackgroundImage = CYOA.Properties.Resources.HAPPY;
            }
            else if (H.Mood <= 2)
            {
                userimg.BackgroundImage = CYOA.Properties.Resources.Sad;
            }
        }

        private void next5_Click(object sender, EventArgs e)
        {
            // essentially doing the exact same thing as in path1 
            this.Hide();
            H.finale.Show();
        }

        private void next1_Click(object sender, EventArgs e)
        {
            r3.Visible = false;
            next1.Visible = false;
            H.day++;
            this.Hide();
            H.Pass1.Show();
        }

        private void next2_Click(object sender, EventArgs e)
        {
            pizzag.Visible = false;
            next2.Visible = false;
            H.day++;
            this.Hide();
            H.Pass1.Show();
        }

        private void next3_Click(object sender, EventArgs e)
        {
            AMD.Visible = false;
            next3.Visible = false;
            H.day++;
            this.Hide();
            H.Pass1.Show();
        }

        private void next4_Click(object sender, EventArgs e)
        {
            dog.Visible = false;
            next4.Visible = false;
            H.day++;
            H.M++;
            this.Hide();
            H.Pass1.Show();
        }

        private void friends_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            //exit
            Environment.Exit(0);
        }

        private void path2_Load(object sender, EventArgs e)
        {

        }
    }
}
