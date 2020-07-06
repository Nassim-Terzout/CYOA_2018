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
    public partial class BuySell : Form
    {
        public BuySell()
        {

            InitializeComponent();

        }

        private void closehelp_Click(object sender, EventArgs e)
        {
            //This will close the tutorial labels allowing for user to trade. Also enable certain objects in form to continue.
            tutorial4.Visible = false;
            tutorial5.Visible = false;
            closehelp.Visible = false;
            symbol1.Enabled = true;
            t1.Enabled = true;
            t2.Enabled = true;
            quantity1.Enabled = true;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void loops_Tick(object sender, EventArgs e)
        {
            // begin by setting up the Users name in the top right.
            Welcome.Text = H.Usern;
        





            // Based on which day it is allow for that combobox with the two companies to be accesible. Disable all others.

            if (H.day == 1)
            {
                symbol1.Visible = true;
                symbol2.Visible = false;
                symbol3.Visible = false;
                symbol4.Visible = false;
                symbol5.Visible = false;
            }
            if (H.day == 2)
            {
                symbol1.Visible = false;
                symbol2.Visible = true;
                symbol3.Visible = false;
                symbol4.Visible = false;
                symbol5.Visible = false;
            }
            if (H.day == 3)
            {
                symbol1.Visible = false;
                symbol2.Visible = false;
                symbol3.Visible = true;
                symbol4.Visible = false;
                symbol5.Visible = false;
            }
            if (H.day == 4)
            {
                symbol1.Visible = false;
                symbol2.Visible = false;
                symbol3.Visible = false;
                symbol4.Visible = true;
                symbol5.Visible = false;
            }
            if (H.day == 5)
            {
                symbol1.Visible = false;
                symbol2.Visible = false;
                symbol3.Visible = false;
                symbol4.Visible = false;
                symbol5.Visible = true;
            }





            //---------------------------------------------------------------

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // if (t1.Text = "Buy") - ignore this 


            //Below is lengthy code that is very repetitive...
            // I will describe the function of every if statement and why it's present as this is a tree statement that checks for ALL possible trades user might want.
            // I begin by restating the Randomizer in this button to continuesly generate new numbers when user wants to trade. Note in the H class this doesn't occur.
            // The first statement scans for the day... It is probably not necessary however i felt like including the day to keep it organized instead of efficient... - Not the best coder for doing this but i didn't want to risk messing up
            // The next statement is essentiel, t1 vs t2 is scanning wether the user checked buy(t1) or short(t2)... Based on what the user selects it will lead to the next if statement under that category.
            //based on what day it is the stock symbols will change (visibility code above this button)... That's why i said that the day statement isnt needed... anyways the next if statement will check which symbol has been selected and lead to the next if statement
            // In the next if statement user will select from the different risk amounts. The if statement that follows will conclude whether the user profits or loses
            // In the final statement the code relates back to the Randomizer number. I chose different odds for each possible combination so that the user will have different odds based on the trade he has crafted.
            // I basically broke down the trade button into this order of checking: Days -> Buy/Short -> Stock choice -> risk amount = odds of profit/loss -> results form shows what happened.
            // Forgot to mention the H.rng also determines wether the users mood goes up or down and also it adds to H.R which i will discuss at the bottom of this lengthy code...
            //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            // ===================================>>                                       HAVE FUN SCROLLING!!                                               <<========================================
            {
                {
                    {
                        {
                            {
                                H.rng = H.Randomizer.Next(1, 20);
                                


                                if (H.day == 1)  //&& t1.Checked == true && symbol1.Text == "MU" && quantity1.Text == "$2000")
                                {
                                    if (t1.Checked == true)
                                    {
                                        if (symbol1.Text == "MU")
                                        {
                                            if (quantity1.Text == "$2000")
                                            {
                                                if (H.rng >= 1 && H.rng <= 11)
                                                {
                                                    H.M = H.M + 2000;
                                                    H.Mood = H.Mood + 1;
                                                    H.R = H.R + 1;

                                                }
                                                else
                                                {
                                                    H.M = H.M - 2000;
                                                    H.Mood = H.Mood - 1;
                                                    H.R = H.R + 2;

                                                }
                                            }
                                            else if (quantity1.Text == "$5000")
                                            {
                                                if (H.rng >= 1 && H.rng <= 11)
                                                {
                                                    H.M = H.M + 5000;
                                                    H.Mood = H.Mood + 1;
                                                    H.R = H.R + 3;

                                                }
                                                else
                                                {
                                                    H.M = H.M - 5000;
                                                    H.Mood = H.Mood - 1;
                                                    H.R = H.R + 4;
                                                }
                                            }
                                            else if (quantity1.Text == "$10000")
                                            {
                                                if (H.rng >= 1 && H.rng <= 11)
                                                {
                                                    H.M = H.M + 10000;
                                                    H.Mood = H.Mood + 1;
                                                    H.R = H.R + 5;
                                                }
                                                else
                                                {
                                                    H.M = H.M - 10000;
                                                    H.Mood = H.Mood - 1;
                                                    H.R = H.R + 6;
                                                }
                                            }
                                        }
                                        else if (symbol1.Text == "NVDA")
                                        {
                                            if (quantity1.Text == "$2000")
                                            {
                                                if (H.rng >= 1 && H.rng <= 5)
                                                {
                                                    H.M = H.M + 2000;
                                                    H.Mood = H.Mood + 1;
                                                    H.R = H.R + 1;
                                                }
                                                else
                                                {
                                                    H.M = H.M - 2000;
                                                    H.Mood = H.Mood - 1;
                                                    H.R = H.R + 2;
                                                }
                                            }
                                            else if (quantity1.Text == "$5000")
                                            {
                                                if (H.rng >= 1 && H.rng <= 55)
                                                {
                                                    H.M = H.M + 5000;
                                                    H.Mood = H.Mood + 1;
                                                    H.R = H.R + 3;
                                                }
                                                else
                                                {
                                                    H.M = H.M - 5000;
                                                    H.Mood = H.Mood - 1;
                                                    H.R = H.R + 4;
                                                }
                                            }
                                            else if (quantity1.Text == "$10000")
                                            {
                                                if (H.rng >= 1 && H.rng <= 5)
                                                {
                                                    H.M = H.M + 10000;
                                                    H.Mood = H.Mood + 1;
                                                    H.R = H.R + 5;
                                                }
                                                else
                                                {
                                                    H.M = H.M - 10000;
                                                    H.Mood = H.Mood - 1;
                                                    H.R = H.R + 6;
                                                }
                                            }
                                        }
                                    }




                                    else if (t2.Checked == true)
                                    {
                                        if (symbol1.Text == "MU")
                                        {
                                            if (quantity1.Text == "$2000")
                                            {
                                                if (H.rng >= 1 && H.rng <= 9)
                                                {
                                                    H.M = H.M + 2000;
                                                    H.Mood = H.Mood + 1;
                                                    H.R = H.R + 1;
                                                }
                                                else
                                                {
                                                    H.M = H.M - 2000;
                                                    H.Mood = H.Mood - 1;
                                                    H.R = H.R + 2;
                                                }
                                            }
                                            else if (quantity1.Text == "$5000")
                                            {
                                                if (H.rng >= 1 && H.rng <= 9)
                                                {
                                                    H.M = H.M + 5000;
                                                    H.Mood = H.Mood + 1;
                                                    H.R = H.R + 3;
                                                }
                                                else
                                                {
                                                    H.M = H.M - 5000;
                                                    H.Mood = H.Mood - 1;
                                                    H.R = H.R + 4;
                                                }
                                            }
                                            else if (quantity1.Text == "$10000")
                                            {
                                                if (H.rng >= 1 && H.rng <= 9)
                                                {
                                                    H.M = H.M + 10000;
                                                    H.Mood = H.Mood + 1;
                                                    H.R = H.R + 5;
                                                }
                                                else
                                                {
                                                    H.M = H.M - 10000;
                                                    H.Mood = H.Mood - 1;
                                                    H.R = H.R + 6;
                                                }
                                            }
                                        }
                                        else if (symbol1.Text == "NVDA")
                                        {
                                            if (quantity1.Text == "$2000")
                                            {
                                                if (H.rng >= 1 && H.rng <= 15)
                                                {
                                                    H.M = H.M + 2000;
                                                    H.Mood = H.Mood + 1;
                                                    H.R = H.R + 1;
                                                }
                                                else
                                                {
                                                    H.M = H.M - 2000;
                                                    H.Mood = H.Mood - 1;
                                                    H.R = H.R + 2;
                                                }
                                            }
                                            else if (quantity1.Text == "$5000")
                                            {
                                                if (H.rng >= 1 && H.rng <= 15)
                                                {
                                                    H.M = H.M + 5000;
                                                    H.Mood = H.Mood + 1;
                                                    H.R = H.R + 3;
                                                }
                                                else
                                                {
                                                    H.M = H.M - 5000;
                                                    H.Mood = H.Mood - 1;
                                                    H.R = H.R + 4;
                                                }
                                            }
                                            else if (quantity1.Text == "$10000")
                                            {
                                                if (H.rng >= 1 && H.rng <= 15)
                                                {
                                                    H.M = H.M + 10000;
                                                    H.Mood = H.Mood + 1;
                                                    H.R = H.R + 5;
                                                }
                                                else
                                                {
                                                    H.M = H.M - 10000;
                                                    H.Mood = H.Mood - 1;
                                                    H.R = H.R + 6;
                                                }
                                            }
                                        }
                                    }
                                }



                                else if (H.day == 2)
                                {
                                    if (t1.Checked == true)
                                    {
                                        if (symbol2.Text == "AMD")
                                        {
                                            if (quantity1.Text == "$2000")
                                            {
                                                if (H.rng >= 1 && H.rng <= 12)
                                                {
                                                    H.M = H.M + 2000;
                                                    H.Mood = H.Mood + 1;
                                                    H.R = H.R + 1;
                                                }
                                                else
                                                {
                                                    H.M = H.M - 2000;
                                                    H.Mood = H.Mood - 1;
                                                    H.R = H.R + 2;
                                                }
                                            }
                                            else if (quantity1.Text == "$5000")
                                            {
                                                if (H.rng >= 1 && H.rng <= 12)
                                                {
                                                    H.M = H.M + 5000;
                                                    H.Mood = H.Mood + 1;
                                                    H.R = H.R + 3;
                                                }
                                                else
                                                {
                                                    H.M = H.M - 5000;
                                                    H.Mood = H.Mood - 1;
                                                    H.R = H.R + 4;
                                                }
                                            }
                                            else if (quantity1.Text == "$10000")
                                            {
                                                if (H.rng >= 1 && H.rng <= 12)
                                                {
                                                    H.M = H.M + 10000;
                                                    H.Mood = H.Mood + 1;
                                                    H.R = H.R + 5;
                                                }
                                                else
                                                {
                                                    H.M = H.M - 10000;
                                                    H.Mood = H.Mood - 1;
                                                    H.R = H.R + 6;
                                                }
                                            }
                                        }
                                        else if (symbol2.Text == "AMZN")
                                        {
                                            if (quantity1.Text == "$2000")
                                            {
                                                if (H.rng >= 1 && H.rng <= 19)
                                                {
                                                    H.M = H.M + 2000;
                                                    H.Mood = H.Mood + 1;
                                                    H.R = H.R + 1;
                                                }
                                                else
                                                {
                                                    H.M = H.M - 2000;
                                                    H.Mood = H.Mood - 1;
                                                    H.R = H.R + 2;
                                                }
                                            }
                                            else if (quantity1.Text == "$5000")
                                            {
                                                if (H.rng >= 1 && H.rng <= 19)
                                                {
                                                    H.M = H.M + 5000;
                                                    H.Mood = H.Mood + 1;
                                                    H.R = H.R + 3;
                                                }
                                                else
                                                {
                                                    H.M = H.M - 5000;
                                                    H.Mood = H.Mood - 1;
                                                    H.R = H.R + 4;
                                                }
                                            }
                                            else if (quantity1.Text == "$10000")
                                            {
                                                if (H.rng >= 1 && H.rng <= 19)
                                                {
                                                    H.M = H.M + 10000;
                                                    H.Mood = H.Mood + 1;
                                                    H.R = H.R + 5;
                                                }
                                                else
                                                {
                                                    H.M = H.M - 10000;
                                                    H.Mood = H.Mood - 1;
                                                    H.R = H.R + 6;
                                                }
                                            }
                                        }
                                    }
                                    else if (t2.Checked == true)
                                    {
                                        if (symbol2.Text == "AMD")
                                        {
                                            if (quantity1.Text == "$2000")
                                            {
                                                if (H.rng >= 1 && H.rng <= 3)
                                                {
                                                    H.M = H.M + 2000;
                                                    H.Mood = H.Mood + 1;
                                                    H.R = H.R + 1;
                                                }
                                                else
                                                {
                                                    H.M = H.M - 2000;
                                                    H.Mood = H.Mood - 1;
                                                    H.R = H.R + 2;
                                                }
                                            }
                                            else if (quantity1.Text == "$5000")
                                            {
                                                if (H.rng >= 1 && H.rng <= 3)
                                                {
                                                    H.M = H.M + 5000;
                                                    H.Mood = H.Mood + 1;
                                                    H.R = H.R + 3;
                                                }
                                                else
                                                {
                                                    H.M = H.M - 5000;
                                                    H.Mood = H.Mood - 1;
                                                    H.R = H.R + 4;
                                                }
                                            }
                                            else if (quantity1.Text == "$10000")
                                            {
                                                if (H.rng >= 1 && H.rng <= 3)
                                                {
                                                    H.M = H.M + 10000;
                                                    H.Mood = H.Mood + 1;
                                                    H.R = H.R + 5;
                                                }
                                                else
                                                {
                                                    H.M = H.M - 10000;
                                                    H.Mood = H.Mood - 1;
                                                    H.R = H.R + 6;
                                                }
                                            }
                                        }
                                        else if (symbol2.Text == "AMZN")
                                        {
                                            if (quantity1.Text == "$2000")
                                            {
                                                if (H.rng >= 1 && H.rng <= 4)
                                                {
                                                    H.M = H.M + 2000;
                                                    H.Mood = H.Mood + 1;
                                                    H.R = H.R + 1;
                                                }
                                                else
                                                {
                                                    H.M = H.M - 2000;
                                                    H.Mood = H.Mood - 1;
                                                    H.R = H.R + 2;
                                                }
                                            }
                                            else if (quantity1.Text == "$5000")
                                            {
                                                if (H.rng >= 1 && H.rng <= 4)
                                                {
                                                    H.M = H.M + 5000;
                                                    H.Mood = H.Mood + 1;
                                                    H.R = H.R + 3;
                                                }
                                                else
                                                {
                                                    H.M = H.M - 5000;
                                                    H.Mood = H.Mood - 1;
                                                    H.R = H.R + 4;
                                                }
                                            }
                                            else if (quantity1.Text == "$10000")
                                            {
                                                if (H.rng >= 1 && H.rng <= 4)
                                                {
                                                    H.M = H.M + 10000;
                                                    H.Mood = H.Mood + 1;
                                                    H.R = H.R + 5;
                                                }
                                                else
                                                {
                                                    H.M = H.M - 10000;
                                                    H.Mood = H.Mood - 1;
                                                    H.R = H.R + 6;
                                                }
                                            }
                                        }
                                    }
                                }



                                else if (H.day == 3)
                                {
                                    if (t1.Checked == true)
                                    {
                                        if (symbol3.Text == "GOOGL")
                                        {
                                            if (quantity1.Text == "$2000")
                                            {
                                                if (H.rng >= 1 && H.rng <= 12)
                                                {
                                                    H.M = H.M + 2000;
                                                    H.Mood = H.Mood + 1;
                                                    H.R = H.R + 1;
                                                }
                                                else
                                                {
                                                    H.M = H.M - 2000;
                                                    H.Mood = H.Mood - 1;
                                                    H.R = H.R + 2;
                                                }
                                            }
                                            else if (quantity1.Text == "$5000")
                                            {
                                                if (H.rng >= 1 && H.rng <= 12)
                                                {
                                                    H.M = H.M + 5000;
                                                    H.Mood = H.Mood + 1;
                                                    H.R = H.R + 3;
                                                }
                                                else
                                                {
                                                    H.M = H.M - 5000;
                                                    H.Mood = H.Mood - 1;
                                                    H.R = H.R + 4;
                                                }
                                            }
                                            else if (quantity1.Text == "$10000")
                                            {
                                                if (H.rng >= 1 && H.rng <= 12)
                                                {
                                                    H.M = H.M + 10000;
                                                    H.Mood = H.Mood + 1;
                                                    H.R = H.R + 5;
                                                }
                                                else
                                                {
                                                    H.M = H.M - 10000;
                                                    H.Mood = H.Mood - 1;
                                                    H.R = H.R + 6;
                                                }
                                            }
                                        }
                                        else if (symbol3.Text == "BBY")
                                        {
                                            if (quantity1.Text == "$2000")
                                            {
                                                if (H.rng >= 1 && H.rng <= 7)
                                                {
                                                    H.M = H.M + 2000;
                                                    H.Mood = H.Mood + 1;
                                                    H.R = H.R + 1;
                                                }
                                                else
                                                {
                                                    H.M = H.M - 2000;
                                                    H.Mood = H.Mood - 1;
                                                    H.R = H.R + 2;
                                                }
                                            }
                                            else if (quantity1.Text == "$5000")
                                            {
                                                if (H.rng >= 1 && H.rng <= 7)
                                                {
                                                    H.M = H.M + 5000;
                                                    H.Mood = H.Mood + 1;
                                                    H.R = H.R + 3;
                                                }
                                                else
                                                {
                                                    H.M = H.M - 5000;
                                                    H.Mood = H.Mood - 1;
                                                    H.R = H.R + 4;
                                                }
                                            }
                                            else if (quantity1.Text == "$10000")
                                            {
                                                if (H.rng >= 1 && H.rng <= 7)
                                                {
                                                    H.M = H.M + 10000;
                                                    H.Mood = H.Mood + 1;
                                                    H.R = H.R + 5;
                                                }
                                                else
                                                {
                                                    H.M = H.M - 10000;
                                                    H.Mood = H.Mood - 1;
                                                    H.R = H.R + 6;
                                                }
                                            }
                                        }
                                    }
                                    else if (t2.Checked == true)
                                    {
                                        if (symbol3.Text == "GOOGL")
                                        {
                                            if (quantity1.Text == "$2000")
                                            {
                                                if (H.rng >= 1 && H.rng <= 6)
                                                {
                                                    H.M = H.M + 2000;
                                                    H.Mood = H.Mood + 1;
                                                    H.R = H.R + 1;
                                                }
                                                else
                                                {
                                                    H.M = H.M - 2000;
                                                    H.Mood = H.Mood - 1;
                                                    H.R = H.R + 2;
                                                }
                                            }
                                            else if (quantity1.Text == "$5000")
                                            {
                                                if (H.rng >= 1 && H.rng <= 6)
                                                {
                                                    H.M = H.M + 5000;
                                                    H.Mood = H.Mood + 1;
                                                    H.R = H.R + 3;
                                                }
                                                else
                                                {
                                                    H.M = H.M - 5000;
                                                    H.Mood = H.Mood - 1;
                                                    H.R = H.R + 4;
                                                }
                                            }
                                            else if (quantity1.Text == "$10000")
                                            {
                                                if (H.rng >= 1 && H.rng <= 6)
                                                {
                                                    H.M = H.M + 10000;
                                                    H.Mood = H.Mood + 1;
                                                    H.R = H.R + 5;
                                                }
                                                else
                                                {
                                                    H.M = H.M - 10000;
                                                    H.Mood = H.Mood - 1;
                                                    H.R = H.R + 6;
                                                }
                                            }
                                        }
                                        else if (symbol3.Text == "BBY")
                                        {
                                            if (quantity1.Text == "$2000")
                                            {
                                                if (H.rng >= 1 && H.rng <= 13)
                                                {
                                                    H.M = H.M + 2000;
                                                    H.Mood = H.Mood + 1;
                                                    H.R = H.R + 1;
                                                }
                                                else
                                                {
                                                    H.M = H.M - 2000;
                                                    H.Mood = H.Mood - 1;
                                                    H.R = H.R + 2;
                                                }
                                            }
                                            else if (quantity1.Text == "$5000")
                                            {
                                                if (H.rng >= 1 && H.rng <= 13)
                                                {
                                                    H.M = H.M + 5000;
                                                    H.Mood = H.Mood + 1;
                                                    H.R = H.R + 3;
                                                }
                                                else
                                                {
                                                    H.M = H.M - 5000;
                                                    H.Mood = H.Mood - 1;
                                                    H.R = H.R + 4;
                                                }
                                            }
                                            else if (quantity1.Text == "$10000")
                                            {
                                                if (H.rng >= 1 && H.rng <= 13)
                                                {
                                                    H.M = H.M + 10000;
                                                    H.Mood = H.Mood + 1;
                                                    H.R = H.R + 5;
                                                }
                                                else
                                                {
                                                    H.M = H.M - 10000;
                                                    H.Mood = H.Mood - 1;
                                                    H.R = H.R + 6;
                                                }
                                            }
                                        }
                                    }
                                }
                                else if (H.day == 4)
                                {
                                    if (t1.Checked == true)
                                    {
                                        if (symbol4.Text == "NKE")
                                        {
                                            if (quantity1.Text == "$2000")
                                            {
                                                if (H.rng >= 1 && H.rng <= 10)
                                                {
                                                    H.M = H.M + 2000;
                                                    H.Mood = H.Mood + 1;
                                                    H.R = H.R + 1;
                                                }
                                                else
                                                {
                                                    H.M = H.M - 2000;
                                                    H.Mood = H.Mood - 1;
                                                    H.R = H.R + 2;
                                                }
                                            }
                                            else if (quantity1.Text == "$5000")
                                            {
                                                if (H.rng >= 1 && H.rng <= 10)
                                                {
                                                    H.M = H.M + 5000;
                                                    H.Mood = H.Mood + 1;
                                                    H.R = H.R + 3;
                                                }
                                                else
                                                {
                                                    H.M = H.M - 5000;
                                                    H.Mood = H.Mood - 1;
                                                    H.R = H.R + 4;
                                                }
                                            }
                                            else if (quantity1.Text == "$10000")
                                            {
                                                if (H.rng >= 1 && H.rng <= 10)
                                                {
                                                    H.M = H.M + 10000;
                                                    H.Mood = H.Mood + 1;
                                                    H.R = H.R + 5;
                                                }
                                                else
                                                {
                                                    H.M = H.M - 10000;
                                                    H.Mood = H.Mood - 1;
                                                    H.R = H.R + 6;
                                                }
                                            }
                                        }
                                        else if (symbol4.Text == "ANF")
                                        {
                                            if (quantity1.Text == "$2000")
                                            {
                                                if (H.rng >= 1 && H.rng <= 11)
                                                {
                                                    H.M = H.M + 2000;
                                                    H.Mood = H.Mood + 1;
                                                    H.R = H.R + 1;
                                                }
                                                else
                                                {
                                                    H.M = H.M - 2000;
                                                    H.Mood = H.Mood - 1;
                                                    H.R = H.R + 2;
                                                }
                                            }
                                            else if (quantity1.Text == "$5000")
                                            {
                                                if (H.rng >= 1 && H.rng <= 11)
                                                {
                                                    H.M = H.M + 5000;
                                                    H.Mood = H.Mood + 1;
                                                    H.R = H.R + 3;
                                                }
                                                else
                                                {
                                                    H.M = H.M - 5000;
                                                    H.Mood = H.Mood - 1;
                                                    H.R = H.R + 4;
                                                }
                                            }
                                            else if (quantity1.Text == "$10000")
                                            {
                                                if (H.rng >= 1 && H.rng <= 11)
                                                {
                                                    H.M = H.M + 10000;
                                                    H.Mood = H.Mood + 1;
                                                    H.R = H.R + 5;
                                                }
                                                else
                                                {
                                                    H.M = H.M - 10000;
                                                    H.Mood = H.Mood - 1;
                                                    H.R = H.R + 6;
                                                }
                                            }
                                        }
                                    }
                                    else if (t2.Checked == true)
                                    {
                                        if (symbol4.Text == "NKE")
                                        {
                                            if (quantity1.Text == "$2000")
                                            {
                                                if (H.rng >= 1 && H.rng <= 7)
                                                {
                                                    H.M = H.M + 2000;
                                                    H.Mood = H.Mood + 1;
                                                    H.R = H.R + 1;
                                                }
                                                else
                                                {
                                                    H.M = H.M - 2000;
                                                    H.Mood = H.Mood - 1;
                                                    H.R = H.R + 2;
                                                }
                                            }
                                            else if (quantity1.Text == "$5000")
                                            {
                                                if (H.rng >= 1 && H.rng <= 7)
                                                {
                                                    H.M = H.M + 5000;
                                                    H.Mood = H.Mood + 1;
                                                    H.R = H.R + 3;
                                                }
                                                else
                                                {
                                                    H.M = H.M - 5000;
                                                    H.Mood = H.Mood - 1;
                                                    H.R = H.R + 4;
                                                }
                                            }
                                            else if (quantity1.Text == "$10000")
                                            {
                                                if (H.rng >= 1 && H.rng <= 7)
                                                {
                                                    H.M = H.M + 10000;
                                                    H.Mood = H.Mood + 1;
                                                    H.R = H.R + 5;
                                                }
                                                else
                                                {
                                                    H.M = H.M - 10000;
                                                    H.Mood = H.Mood - 1;
                                                    H.R = H.R + 6;
                                                }
                                            }
                                        }
                                        else if (symbol4.Text == "ANF")
                                        {
                                            if (quantity1.Text == "$2000")
                                            {
                                                if (H.rng >= 1 && H.rng <= 6)
                                                {
                                                    H.M = H.M + 2000;
                                                    H.Mood = H.Mood + 1;
                                                    H.R = H.R + 1;
                                                }
                                                else
                                                {
                                                    H.M = H.M - 2000;
                                                    H.Mood = H.Mood - 1;
                                                    H.R = H.R + 2;
                                                }
                                            }
                                            else if (quantity1.Text == "$5000")
                                            {
                                                if (H.rng >= 1 && H.rng <= 6)
                                                {
                                                    H.M = H.M + 5000;
                                                    H.Mood = H.Mood + 1;
                                                    H.R = H.R + 3;
                                                }
                                                else
                                                {
                                                    H.M = H.M - 5000;
                                                    H.Mood = H.Mood - 1;
                                                    H.R = H.R + 4;
                                                }
                                            }
                                            else if (quantity1.Text == "$10000")
                                            {
                                                if (H.rng >= 1 && H.rng <= 6)
                                                {
                                                    H.M = H.M + 10000;
                                                    H.Mood = H.Mood + 1;
                                                    H.R = H.R + 5;
                                                }
                                                else
                                                {
                                                    H.M = H.M - 10000;
                                                    H.Mood = H.Mood - 1;
                                                    H.R = H.R + 6;
                                                }
                                            }
                                        }
                                    }
                                }
                                else if (H.day == 5)
                                {
                                    if (t1.Checked == true)
                                    {
                                        if (symbol5.Text == "FB")
                                        {
                                            if (quantity1.Text == "$2000")
                                            {
                                                if (H.rng >= 1 && H.rng <= 13)
                                                {
                                                    H.M = H.M + 2000;
                                                    H.Mood = H.Mood + 1;
                                                    H.R = H.R + 1;
                                                }
                                                else
                                                {
                                                    H.M = H.M - 2000;
                                                    H.Mood = H.Mood - 1;
                                                    H.R = H.R + 2;
                                                }
                                            }
                                            else if (quantity1.Text == "$5000")
                                            {
                                                if (H.rng >= 1 && H.rng <= 13)
                                                {
                                                    H.M = H.M + 5000;
                                                    H.Mood = H.Mood + 1;
                                                    H.R = H.R + 3;
                                                }
                                                else
                                                {
                                                    H.M = H.M - 5000;
                                                    H.Mood = H.Mood - 1;
                                                    H.R = H.R + 4;
                                                }
                                            }
                                            else if (quantity1.Text == "$10000")
                                            {
                                                if (H.rng >= 1 && H.rng <= 13)
                                                {
                                                    H.M = H.M + 10000;
                                                    H.Mood = H.Mood + 1;
                                                    H.R = H.R + 5;
                                                }
                                                else
                                                {
                                                    H.M = H.M - 10000;
                                                    H.Mood = H.Mood - 1;
                                                    H.R = H.R + 6;
                                                }
                                            }
                                        }
                                        else if (symbol5.Text == "AEO")
                                        {
                                            if (quantity1.Text == "$2000")
                                            {
                                                if (H.rng >= 1 && H.rng <= 3)
                                                {
                                                    H.M = H.M + 2000;
                                                    H.Mood = H.Mood + 1;
                                                    H.R = H.R + 1;
                                                }
                                                else
                                                {
                                                    H.M = H.M - 2000;
                                                    H.Mood = H.Mood - 1;
                                                    H.R = H.R + 2;
                                                }
                                            }
                                            else if (quantity1.Text == "$5000")
                                            {
                                                if (H.rng >= 1 && H.rng <= 3)
                                                {
                                                    H.M = H.M + 5000;
                                                    H.Mood = H.Mood + 1;
                                                    H.R = H.R + 3;
                                                }
                                                else
                                                {
                                                    H.M = H.M - 5000;
                                                    H.Mood = H.Mood - 1;
                                                    H.R = H.R + 4;
                                                }
                                            }
                                            else if (quantity1.Text == "$10000")
                                            {
                                                if (H.rng >= 1 && H.rng <= 3)
                                                {
                                                    H.M = H.M + 10000;
                                                    H.Mood = H.Mood + 1;
                                                    H.R = H.R + 5;
                                                }
                                                else
                                                {
                                                    H.M = H.M - 10000;
                                                    H.Mood = H.Mood - 1;
                                                    H.R = H.R + 6;
                                                }
                                            }
                                        }
                                    }
                                    else if (t2.Checked == true)
                                    {
                                        if (symbol5.Text == "FB")
                                        {
                                            if (quantity1.Text == "$2000")
                                            {
                                                if (H.rng >= 1 && H.rng <= 15)
                                                {
                                                    H.M = H.M + 2000;
                                                    H.Mood = H.Mood + 1;
                                                    H.R = H.R + 1;
                                                }
                                                else
                                                {
                                                    H.M = H.M - 2000;
                                                    H.Mood = H.Mood - 1;
                                                    H.R = H.R + 2;
                                                }
                                            }
                                            else if (quantity1.Text == "$5000")
                                            {
                                                if (H.rng >= 1 && H.rng <= 15)
                                                {
                                                    H.M = H.M + 5000;
                                                    H.Mood = H.Mood + 1;
                                                    H.R = H.R + 3;
                                                }
                                                else
                                                {
                                                    H.M = H.M - 5000;
                                                    H.Mood = H.Mood - 1;
                                                    H.R = H.R + 4;
                                                }
                                            }
                                            else if (quantity1.Text == "$10000")
                                            {
                                                if (H.rng >= 1 && H.rng <= 15)
                                                {
                                                    H.M = H.M + 10000;
                                                    H.Mood = H.Mood + 1;
                                                    H.R = H.R + 5;
                                                }
                                                else
                                                {
                                                    H.M = H.M - 10000;
                                                    H.Mood = H.Mood - 1;
                                                    H.R = H.R + 6;
                                                }
                                            }
                                        }
                                        else if (symbol5.Text == "AEO")
                                        {
                                            if (quantity1.Text == "$2000")
                                            {
                                                if (H.rng >= 1 && H.rng <= 18)
                                                {
                                                    H.M = H.M + 2000;
                                                    H.Mood = H.Mood + 1;
                                                    H.R = H.R + 1;
                                                }
                                                else
                                                {
                                                    H.M = H.M - 2000;
                                                    H.Mood = H.Mood - 1;
                                                    H.R = H.R + 2;
                                                }
                                            }
                                            else if (quantity1.Text == "$5000")
                                            {
                                                if (H.rng >= 1 && H.rng <= 18)
                                                {
                                                    H.M = H.M + 5000;
                                                    H.Mood = H.Mood + 1;
                                                    H.R = H.R + 3;
                                                }
                                                else
                                                {
                                                    H.M = H.M - 5000;
                                                    H.Mood = H.Mood - 1;
                                                    H.R = H.R + 4;
                                                }
                                            }
                                            else if (quantity1.Text == "$10000")
                                            {
                                                if (H.rng >= 1 && H.rng <= 18)
                                                {
                                                    H.M = H.M + 10000;
                                                    H.Mood = H.Mood + 1;
                                                    H.R = H.R + 5;
                                                }
                                                else
                                                {
                                                    H.M = H.M - 10000;
                                                    H.Mood = H.Mood - 1;
                                                    H.R = H.R + 6;
                                                }
                                            }
                                        }
                                    }
                                }












                            }
                        }
                    }



                    //Based on user transaction there would have been a value assigned to H.R
                    // there is a total of 6 different posible H.R values
                    // each H.R value represents a gain or a loss (2 options) of the 3 different risks factors (3 options)
                    // it can be either +2000, -2000, +5000 etc...
                    // basically 2x3 = 6 so for every integer something different happens on the results form
                    //The money text will change accordingly as well as the color of the text!



                    if (H.R == 1)
                    {
                        H.Result.wl.ForeColor = Color.Green;
                        H.Result.wl.Text = "+ $2000";
                    }
                    else if (H.R == 2)
                    {
                        H.Result.wl.ForeColor = Color.Red;
                        H.Result.wl.Text = "- $2000";
                    }
                    else if (H.R == 3)
                    {
                        H.Result.wl.ForeColor = Color.Green;
                        H.Result.wl.Text = "+ $5000";
                    }
                    else if (H.R == 4)
                    {
                        H.Result.wl.ForeColor = Color.Red;
                        H.Result.wl.Text = "- $5000";
                    }
                    else if (H.R == 5)
                    {
                        H.Result.wl.ForeColor = Color.Green;
                        H.Result.wl.Text = "+ $10000";
                    }
                    else if (H.R == 6)
                    {
                        H.Result.wl.ForeColor = Color.Red;
                        H.Result.wl.Text = "- $10000";
                    }

                }
                //hide and show results
                this.Hide();
                H.Result.Show();
            }
        }

        

        private void tradeloops_Tick(object sender, EventArgs e)
        {
            //This loop is used to set up the different charts and chart labels
            // based on wish day it is the image and labels will match up accordingly
            // essentially a repeat of trade1 form.
            if (H.day == 1)
            {
              
                stockl1.Text = "Nvidia (NVDA)";
                stock1.BackgroundImage = CYOA.Properties.Resources.good1;
              
                stockl2.Text = "Micron (MU)";
                stock2.BackgroundImage = CYOA.Properties.Resources.good2;
            }
            if (H.day == 2)
            {
               

                stockl1.Text = "Advanced Micro Devices (AMD)";
                stock1.BackgroundImage = CYOA.Properties.Resources.good3;
               
                stockl2.Text = "Amazon (AMZN)";
                stock2.BackgroundImage = CYOA.Properties.Resources.good4;
            }
            if (H.day == 3)
            {
          
                stockl1.Text = "Google (GOOGL)";
                stock1.BackgroundImage = CYOA.Properties.Resources.good5;
            
                stockl2.Text = "Best Buy CO (BBY)";
                stock2.BackgroundImage = CYOA.Properties.Resources.good6;
            }
            if (H.day == 4)
            {
           
                stockl1.Text = "Nike Inc (NKE)";
                stock1.BackgroundImage = CYOA.Properties.Resources.good7;
                
                stockl2.Text = "Abercrombie & Fitch Co. (ANF)";
                stock2.BackgroundImage = CYOA.Properties.Resources.good8;
            }
            if (H.day == 5)
            {
                
                stockl1.Text = "Facebook, Inc. (FB)";
                stock1.BackgroundImage = CYOA.Properties.Resources.good9;
                
                stockl2.Text = "American Eagle Outfitters (AEO)";
                stock2.BackgroundImage = CYOA.Properties.Resources.good10;
            }

            //--

        }

        private void HUD_Tick(object sender, EventArgs e)
        {
            // This is just for the HUD... i probably did the welcome text above once but there is literally not harm in doing it twice.
            // Just ensuring that the welcome text, money text and mood images are represented based on current game performance.
            Welcome.Text = H.Usern;
            money.Text = "$" + H.M;
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

        private void BuySell_Load(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
          // exit upon click
            Environment.Exit(0);
        }

        private void Welcome_Click(object sender, EventArgs e)
        {

        }
    }


    }
