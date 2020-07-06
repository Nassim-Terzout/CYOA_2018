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
    public partial class path1 : Form
    {
        public path1()
        {
            InitializeComponent();
        }

        private void HUD_Tick(object sender, EventArgs e)
        {
            //setting up HUD again
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

        private void next3_Click(object sender, EventArgs e)
        {
            // based on what the day is either this or path 2 will be chosen...
            // the lifedecision form did most of the work... the buttons and labels have already been adjusted for in previous form
            // The next button of the day will be present therefore.... hide all current labels buttons etc... for the day and 1 to the day.
            //Hide and show the pass form to start the next day
            //repeat this until reaching next5 where it leads to the results form
            NVDA.Visible = false;
            next3.Visible = false;
            H.day++;
            this.Hide();
            H.Pass1.Show();
        }

        private void next1_Click(object sender, EventArgs e)
        {
            //
            corolla.Visible = false;
            next1.Visible = false;
            H.day++;
            this.Hide();
            H.Pass1.Show();
        }

        private void next2_Click(object sender, EventArgs e)
        {
            pizzab.Visible = false;
            next2.Visible = false;
            H.day++;
            this.Hide();
            H.Pass1.Show();
        }

        private void next4_Click(object sender, EventArgs e)
        {
            cat.Visible = false;
            next4.Visible = false;
            H.day++;
            H.M++;
            this.Hide();
            H.Pass1.Show();
        }

        private void next5_Click(object sender, EventArgs e)
        {
            this.Hide();
            H.finale.Show();
        }

        private void path1_Load(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            //exit
            Environment.Exit(0);
        }
    }
}
