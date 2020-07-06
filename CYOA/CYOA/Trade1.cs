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

    public partial class trade1 : Form
    {

        public trade1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            H.BuySell.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void loops_Tick(object sender, EventArgs e)
        {
            //Below is the code to reporesent current player status based on G variables
            //mood, money and name are all included and represented in the HUD
            //based on performance these fluctuate
            // adjust for day too
            daycount.Text = "Day " + H.day;
            Welcome.Text = H.Usern;
            money.Text = "$" +H.M;
            if (H.Mood == 3 || H.Mood == 4 || H.Mood == 5 || H.Mood == 6 || H.Mood == 7)
            {
                userimg.BackgroundImage = CYOA.Properties.Resources.Mild;
            }
            else if (H.Mood >= 8 )
            {
                userimg.BackgroundImage = CYOA.Properties.Resources.HAPPY;
            }
            else if (H.Mood <= 2)
            {
                userimg.BackgroundImage = CYOA.Properties.Resources.Sad;
            }
            

            // Below i will set up different charts and texts based on what day it is! - day variable!
            //essentially the day variable from H class is used to change the stock images and stock labels for the given day.
            if (H.day == 1)
            {
                stocknews1.Text = "Nvidia (NVDA)";
                stockl1.Text = "Nvidia (NVDA)";
                stock1.BackgroundImage = CYOA.Properties.Resources.good1;
                stocknews2.Text = "Micron (MU)";
                stockl2.Text = "Micron (MU)";
                stock2.BackgroundImage = CYOA.Properties.Resources.good2;
            }
            if (H.day == 2)
            {
                stocknews1.Text = "Advanced Micro Devices (AMD)";

                stockl1.Text = "Advanced Micro Devices (AMD)";
                stock1.BackgroundImage = CYOA.Properties.Resources.good3;
                stocknews2.Text = "Amazon (AMZN)";
                stockl2.Text = "Amazon (AMZN)";
                stock2.BackgroundImage = CYOA.Properties.Resources.good4;
            }
            if (H.day == 3)
            {
                stocknews1.Text = "Google (GOOGL)";
                stockl1.Text = "Google (GOOGL)";
                stock1.BackgroundImage = CYOA.Properties.Resources.good5;
                stocknews2.Text = "Best Buy CO (BBY)";
                stockl2.Text = "Best Buy CO (BBY)";
                stock2.BackgroundImage = CYOA.Properties.Resources.good6;
            }
            if (H.day == 4)
            {
                stocknews1.Text = "Nike Inc (NKE)";
                stockl1.Text = "Nike Inc (NKE)";
                stock1.BackgroundImage = CYOA.Properties.Resources.good7;
                stocknews2.Text = "Abercrombie & Fitch Co. (ANF)";
                stockl2.Text = "Abercrombie & Fitch Co. (ANF)";
                stock2.BackgroundImage = CYOA.Properties.Resources.good8;
            }
            if (H.day == 5)
            {
                stocknews1.Text = "Facebook, Inc. (FB)";
                stockl1.Text = "Facebook, Inc. (FB)";
                stock1.BackgroundImage = CYOA.Properties.Resources.good9;
                stocknews2.Text = "American Eagle Outfitters (AEO)";
                stockl2.Text = "American Eagle Outfitters (AEO)";
                stock2.BackgroundImage = CYOA.Properties.Resources.good10;
            }








        }

        private void stock1_Click(object sender, EventArgs e)
        {

        }

        private void closehelp_Click(object sender, EventArgs e)
        {
            //For tutorial day. Close all help to allow user to move on. Enable news too.
            closehelp.Visible = false;
            tutorial1.Visible = false;
            tutorial2.Visible = false;
            tutorial3.Visible = false;
            tutorial4.Visible = false;
            tutorial5.Visible = false;
            News.Enabled = true;
            news2.Enabled = true;

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void News_Click(object sender, EventArgs e)
        {
            //this substracts 1000 as the cost for using news.
            H.M = H.M - 1000;
            // Based on what day it is the news of the day will change
            // News labels and News text on the Newsform are set up here based on the day.
            if (H.day == 1)
            {
                H.NewsForm.Newssir.Text = "Nvidia has been outperforming many chip manyfacturers as of recent and are ranked very highly in the industry. They have hired a new CEO and are due to report quarterly earnings this evening. ";
                H.NewsForm.newsl.Text = "Nvidia News";
                Refresh();
                this.Hide();
                H.NewsForm.Show();
              
            }
            else if (H.day == 2)
            {
                H.NewsForm.Newssir.Text = "AMD has been an underdog and is considered underated by many analysts. This company is ranked below Nvdia, Micron and many others in the tech industry however it's latest patent is getting attention.";
                H.NewsForm.newsl.Text = "AMD News";
                this.Hide();
                H.NewsForm.Show();
            }
            else if (H.day == 3)
            {
                H.NewsForm.Newssir.Text = "Google has been doing very well this year but they are falling behind Amazon. They haven't made any moves lately, however Sergey Brin promises he is working on a new project that could be a hit.";
                H.NewsForm.newsl.Text = "Google News";

                this.Hide();
                H.NewsForm.Show();
            }
            else if (H.day == 4)
            {

                H.NewsForm.Newssir.Text = "Nike has been a slow moving stock this year and hasn't made any huge moves yet. Their new shoes have been receiving mixed reviews and they aren't looking like a good trade as of now.";
                H.NewsForm.newsl.Text = "Nike News";
                this.Hide();
                H.NewsForm.Show();
            }
            else if (H.day == 5)
            {
                H.NewsForm.Newssir.Text = "Facebook has been steady growing all year. They will be reporting tonight and the analysts seem to believe they are going to have solid scores just like previous quarters.";
                H.NewsForm.newsl.Text = "Facebook News";
                this.Hide();
                H.NewsForm.Show();
            }
        }

        private void news2_Click(object sender, EventArgs e)
        {
            // identical to the button above just different stocks. Same function for the second stock of the day news.
            H.M = H.M - 1000;

            if (H.day == 1)
            {
            
                H.NewsForm.Newssir.Text = "Micron has been a very steady bet this year. So far they have grew 20% over a 40 week period and don't seem to be slowing down. Although they seem to have some bad days they manage to recover.";
                H.NewsForm.newsl.Text = "Micron News";

                this.Hide();
                H.NewsForm.Show();
            }
            else if (H.day == 2)
            {
                H.NewsForm.Newssir.Text = "Amazon has been a tech giant this year. They have just created the first transportation drone capable of doing driveless deliveries across the country. Analysts suggest this is a very good trade";
                H.NewsForm.newsl.Text = "Amazon News";
                this.Hide();
                H.NewsForm.Show();
            }
            else if (H.day == 3)
            {
                H.NewsForm.Newssir.Text = "Best Buy has been in decline due to the addition of Amazon's driverless delivery drones. They seem to be in difficulty as of now and analysts suggest this is not the best trade";
                H.NewsForm.newsl.Text = "BBY News";
                this.Hide();
                H.NewsForm.Show();
            }
            else if (H.day == 4)
            {
                H.NewsForm.Newssir.Text = "Abercrombie has been on the rise this year growing their shares 110%. Analysts suggest this company will keep their growth and that it is a good trade.";
                H.NewsForm.newsl.Text = "ANF News";
                this.Hide();
                H.NewsForm.Show();
            }
            else if (H.day == 5)
            {
                H.NewsForm.Newssir.Text = "American Eagle has been on doing very well growing their shares by 100% this year. Analysts and traders believe this is a good trade as of now.";
                H.NewsForm.newsl.Text = "AEO News";
                this.Hide();
                H.NewsForm.Show();
            }
        }

        private void dollas_Tick(object sender, EventArgs e)
        {
          
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            //exit
            Environment.Exit(0);
        }

        private void top_Click(object sender, EventArgs e)
        {

        }
    }
}
