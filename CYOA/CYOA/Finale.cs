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
    public partial class Finale : Form
    {
        public Finale()
        {
            InitializeComponent();
        }

        private void HUD_Tick(object sender, EventArgs e)
        {
                // This is basically stating the final HUD just ina different format as the final results of the game.
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
            Mscore.Text = "$" + H.M;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Finale_Load(object sender, EventArgs e)
        {

        }
    }
}
