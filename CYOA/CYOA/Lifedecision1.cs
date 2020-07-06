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
    public partial class Lifedecision500 : Form
    {
        public Lifedecision500()
        {
            InitializeComponent();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            //close the tutorial
            closehelp.Visible = false;
            tutorial4.Visible = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // based on what day it is change everything....
            // change the describ text to make it reflect the event
            //change that daylabel to make it reflect what day it is...
            // set up only the images, buttons etc... that are needed for that day by using visibility
            //set what you need/want as visible true vs the rest as visible false
            //also adjust the description text to illustrate what is happening and what user must do.
            if (H.day == 1)
            {
                daylabel.Text = "Day 1";
                describ.Text = "Choose a mode of transportation";
                Next1.Visible = false;
            }

            else if (H.day == 2)
            {
                Next1.Visible = false;
                next2.Visible = true;
                next3.Visible = false;
                next4.Visible = false;
                next5.Visible = false;

                //----------------------------------



                //------------------------------------
                next3.Visible = false;
                AMD.Visible = false;
                AMDL.Visible = false;
                AMDOPT.Visible = false;
                NVDA.Visible = false;
                NVDAL.Visible = false;
                NVDAOPT.Visible = false;


                //--------------------------------------

                next4.Visible = false;
                Cat.Visible = false;
                Dog.Visible = false;
                catopt.Visible = false;
                dogopt.Visible = false;



                //--------------------------

                next5.Visible = false;
                stocks.Visible = false;
                stockopt.Visible = false;
                friends.Visible = false;
                friendsopt.Visible = false;

                //----------------------------------

                daylabel.Text = "Day 2";

                pizza.Visible = true;
                topping1.Visible = true;
                topping2.Visible = true;
                topping3.Visible = true;
                topping4.Visible = true;
                topping5.Visible = true;
                describ.Text = "Choosing pizza toppings";
                description.Text = "So you have decided to eat out with your friend today. They have just exited to the washroom and told you to order the pizza. You must pick the toppings however you don't remember or know if your friend suggested anything. You know your friend likes fish, hates salt or sweet and prefers vegetables and one meat topping. Check the toppings then press the Next button once you think you have selected appropriate toppings.";
                //                  In this box there will be a description of the life decision you will be making. Based on the decision instructions will vary.You may be asked to check different boxes, pick a pathway or select different objects. Be careful as each decision can affect your mood and money.For your first day you must decide which vehicle you will use for the adventure. Press on either vehicle after closing help to proceed.
                //                      ^^ ignore that too, just used as a reference of length...
            }
            else if (H.day == 3)
            {
                Next1.Visible = false;
                next2.Visible = false;
                next3.Visible = true;
                next4.Visible = false;
                next5.Visible = false;





                //----------------------------------
                next2.Visible = false;
                topping1.Visible = false;
                topping2.Visible = false;
                topping3.Visible = false;
                topping4.Visible = false;
                topping5.Visible = false;
                pizza.Visible = false;



                //------------------------------------
               


                //--------------------------------------

                next4.Visible = false;
                Cat.Visible = false;
                Dog.Visible = false;
                catopt.Visible = false;
                dogopt.Visible = false;



                //--------------------------

                next5.Visible = false;
                stocks.Visible = false;
                stockopt.Visible = false;
                friends.Visible = false;
                friendsopt.Visible = false;

                //----------------------------------


                AMD.Visible = true;
                AMDL.Visible = true;
                AMDOPT.Visible = true;
                NVDA.Visible = true;
                NVDAL.Visible = true;
                NVDAOPT.Visible = true;
                
                describ.Text = "Choosing a new graphics card";
                description.Text = "It's time to uprgade your computer! Please select once of the graphics card as the newest improvement to your PC!";
                daylabel.Text = "Day 3";
            }




            else if (H.day == 4)
            {
                Next1.Visible = false;
                next2.Visible = false;
                next3.Visible = false;
                next4.Visible = true;
                next5.Visible = false;



                //----------------------------------
                next2.Visible = false;
                topping1.Visible = false;
                topping2.Visible = false;
                topping3.Visible = false;
                topping4.Visible = false;
                topping5.Visible = false;
                pizza.Visible = false;



                //------------------------------------
                next3.Visible = false;
                AMD.Visible = false;
                AMDL.Visible = false;
                AMDOPT.Visible = false;
                NVDA.Visible = false;
                NVDAL.Visible = false;
                NVDAOPT.Visible = false;


                //--------------------------------------

             



                //--------------------------

                next5.Visible = false;
                stocks.Visible = false;
                stockopt.Visible = false;
                friends.Visible = false;
                friendsopt.Visible = false;

                //----------------------------------

                Cat.Visible = true;
                Dog.Visible = true;
                catopt.Visible = true;
                dogopt.Visible = true;
             
                daylabel.Text = "Day 4";
                describ.Text = "Choosing a new pet";
                description.Text = "You are looking for a new pet to join you at home but can't decide! You stumble across two different pets and have to make your mind.";
            }





            else if (H.day == 5)
            {
                Next1.Visible = false;
                next2.Visible = false;
                next3.Visible = false;
                next4.Visible = false;
                next5.Visible = true;

                //----------------------------------
                next2.Visible = false;
                topping1.Visible = false;
                topping2.Visible = false;
                topping3.Visible = false;
                topping4.Visible = false;
                topping5.Visible = false;
                pizza.Visible = false;



                //------------------------------------
                next3.Visible = false;
                AMD.Visible = false;
                AMDL.Visible = false;
                AMDOPT.Visible = false;
                NVDA.Visible = false;
                NVDAL.Visible = false;
                NVDAOPT.Visible = false;


                //--------------------------------------

                next4.Visible = false;
                Cat.Visible = false;
                Dog.Visible = false;
                catopt.Visible = false;
                dogopt.Visible = false;



                //--------------------------

            

                //----------------------------------

                daylabel.Text = "Day 5";
                stockopt.Visible = true;
                stocks.Visible = true;
                friends.Visible = true;
                friendsopt.Visible = true;
                describ.Text = "Deciding on life";
                description.Text = "You are asked to go out with your friends however the market doesn't close for another two hours and you would like to make another trade. You must decide wether you should go out with your friends or work extra hours.";
                
            }
        }

        private void HUD_Tick(object sender, EventArgs e)
        {
            //once again just setting up the HUD to reflect current game state.
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
            //this is fairly similar to what i did in the timer earlier (not HUD)
            //Setting up all texts, labels, buttons etc on the next forms... path1 and path2 for the current event.
            // the current event and what will be shown on the next form is all tied to what day it is and what button will be visible
            // if day == 1 then show next 1 which will set up path 1 and path2 for decision in day 1.
            // i essentially use a bunch of visibilty to work around only showing what i want vs what i don't.
            H.path1.next1.Visible = false;
            H.path1.next2.Visible = false;
            H.path1.next3.Visible = false;
            H.path1.next4.Visible = false;
            H.path1.next5.Visible = true;
            H.path2.next1.Visible = false;
            H.path2.next2.Visible = false;
            H.path2.next3.Visible = false;
            H.path2.next4.Visible = false;
            H.path2.next5.Visible = true;


            //==============================================









            next5.Visible = false;
            stocks.Visible = false;
            stockopt.Visible = false;
            friends.Visible = false;
            friendsopt.Visible = false;

            //----------
            //in this case for next5 it was a radio button decision.
            // if stockopt selected change the text in path1 accordingly and show path1
            //also impact h class variables (mood, money)  and visibilty on the path1 form.... show only the stuff that it is needed to progress storyline.
            if (stockopt.Checked == true)
            {
                H.path1.output.Text = "You missed out on being with your friends and are therefore slightly upset. You still managed to make $1000 while being at home. ";
                H.path1.daylabel.Text = "Day 5";
                H.path1.stocks.Visible = true;
                H.path1.next5.Visible = true;
                H.Mood = H.Mood - 1;
                H.M = H.M + 1000;
                H.path1.describ.Text = describ.Text; 

                this.Hide();
                H.path1.Show();
            }
            else
            {
                //if stockopt isnt selected do the same with path2 and the other possibility.
                H.path2.output.Text = "You went out with your friends and had a blast! On top of it all you made $10000 gambling! ";
                H.path2.daylabel.Text = "Day 5";
                H.path2.friends.Visible = true;
                H.path2.next5.Visible = true;
                H.Mood = H.Mood +10;
                H.M = H.M + 10000;
                H.path2.describ.Text = describ.Text;

                this.Hide();
                H.path2.Show();
            }
        }

        private void Next1_Click(object sender, EventArgs e)
        {
            //i do the same like in the button above... once again i use visibility to show what is relevant.
            // based on the day the next buttons will vary and since it is day 1 the next 1 button will be the button to be clicked first.
            // alot of the stuff is preset so there isnt much code needed for next 1
            Next1.Visible = false;

            H.path1.next1.Visible = false;
            H.path1.next2.Visible = true;
            H.path1.next3.Visible = false;
            H.path1.next4.Visible = false;
            H.path1.next5.Visible = false;
            H.path2.next1.Visible = false;
            H.path2.next2.Visible = true;
            H.path2.next3.Visible = false;
            H.path2.next4.Visible = false;
            H.path2.next5.Visible = false;
        }

        private void next2_Click(object sender, EventArgs e)
        {

            //Once again visibilty based on day which determines what button is visible and therefore clicked.
            H.path1.next1.Visible = false;
            H.path1.next2.Visible = true;
            H.path1.next3.Visible = false;
            H.path1.next4.Visible = false;
            H.path1.next5.Visible = false;
            H.path2.next1.Visible = false;
            H.path2.next2.Visible = true;
            H.path2.next3.Visible = false;
            H.path2.next4.Visible = false;
            H.path2.next5.Visible = false;
            //=============================



            next2.Visible = false;
            topping1.Visible = false;
            topping2.Visible = false;
            topping3.Visible = false;
            topping4.Visible = false;
            topping5.Visible = false;
            pizza.Visible = false;

            //-----
            //similar to radio buttons but instead it's checkboxes sooooo use || as there isnt 2 options
            if (topping1.Checked == true || topping3.Checked == true || topping4.Checked == true)
            {

                H.path1.output.Text = "Oops! Your friend is upset because of your topping choice. You are therefore frusterated and had to eat the pizza yourself. ";
                H.path1.daylabel.Text = "Day 2";
                H.path1.pizzab.Visible = true;
                H.path1.next2.Visible = true;
                H.Mood = H.Mood - 3;
                H.path1.describ.Text = describ.Text;

                this.Hide();
                H.path1.Show();

            }
            else
            {
                H.path2.output.Text = "Well done! You mananged to select the appropriate toppings for your friends and they were very happy with you!";
                H.path2.pizzag.Visible = true;
                H.Mood = H.Mood + 3;
                H.path2.daylabel.Text = "Day 2";
                H.path2.next2.Visible = true;
                H.path2.describ.Text = describ.Text;

                this.Hide();
                H.path2.Show();
            }



        }

        private void next3_Click(object sender, EventArgs e)
        {
            //repeat same steps for next3
            H.path1.next1.Visible = false;
            H.path1.next2.Visible = false;
            H.path1.next3.Visible = true;
            H.path1.next4.Visible = false;
            H.path1.next5.Visible = false;
            H.path2.next1.Visible = false;
            H.path2.next2.Visible = false;
            H.path2.next3.Visible = true;
            H.path2.next4.Visible = false;
            H.path2.next5.Visible = false;


            //============================================






            next3.Visible = false;
            AMD.Visible = false;
            AMDL.Visible = false;
            AMDOPT.Visible = false;
            NVDA.Visible = false;
            NVDAL.Visible = false;
            NVDAOPT.Visible = false;

            if(AMDOPT.Checked == true)
            {
                H.path2.output.Text = "You are very happy with your new PC part and are motivated to make more money in the market!";
                H.Mood = H.Mood  + 5;
                H.path2.daylabel.Text = "Day 3";
                H.M = H.M - 2000;
                H.path2.AMD.Visible = true;
                H.path2.next3.Visible = true;
                H.path2.describ.Text = describ.Text;
                this.Hide();
                H.path2.Show();


            }
            else
            {
                H.path1.output.Text = "You are feeling alright about your decision to buy the HTX 1080 however you heard the AMD card had more value and are disappointed in your decision.";
                H.Mood = H.Mood - 1;
                H.M = H.M - 1000;
                H.path1.daylabel.Text = "Day 3";
                H.path1.NVDA.Visible = true;
                H.path1.next3.Visible = true;
                H.path1.describ.Text = describ.Text;
                this.Hide();
                H.path1.Show();
            }

        }

        private void next4_Click(object sender, EventArgs e)
        {
            //same with day 4
            H.path1.next1.Visible = false;
            H.path1.next2.Visible = false;
            H.path1.next3.Visible = false;
            H.path1.next4.Visible = true;
            H.path1.next5.Visible = false;
            H.path2.next1.Visible = false;
            H.path2.next2.Visible = false;
            H.path2.next3.Visible = false;
            H.path2.next4.Visible = true;
            H.path2.next5.Visible = false;


            //============================================





            next4.Visible = false;
            Cat.Visible = false;
            Dog.Visible = false;
            catopt.Visible = false;
            dogopt.Visible = false;
            if (dogopt.Checked == true)
            {
                H.path2.output.Text = "You bought a dog and are very happy! He seems to listen and causes no issues!";
                H.Mood = H.Mood + 3;
                H.path2.daylabel.Text = "Day 4";
                H.path2.next4.Visible = true;
                H.path2.dog.Visible = true;
                H.path2.describ.Text = describ.Text;
                this.Hide();
                H.path2.Show();

            }
            else
            {
                H.path1.output.Text = "You bought a cat and are upset! He ruined a lot of furniture and goes in the neighbours backyard too often!";
                H.Mood = H.Mood - 3;
                H.path1.daylabel.Text = "Day 4";
                H.path1.next4.Visible = true;
                H.path1.cat.Visible = true;
                H.path1.describ.Text = describ.Text;
                this.Hide();
                H.path1.Show();

            }
        }

        private void r3_Click(object sender, EventArgs e)

        {
            // r3 is actually the same thing but for the first day.... or next1
            // since its an image clicking i didn't put it in the button but in the r3 click 
            // same process throughout the whole thing
            r3.Visible = false;
            corolla.Visible = false;
            fourt.Visible = false;
            ninet.Visible = false;
            H.path2.next1.Visible = true;

            //---------------------------------------------------------------------------------------------------------------------------------------------------
            H.M = H.M - 4200;//HERE
            H.Mood = H.Mood + 3;
            H.path2.output.Text = "Congratulations! You have bought a new bike, you're mood score has increased however you were charged $4200. This also concludes your tutorial day! Press the Next button to move on to day 2!";
            H.path2.daylabel.Text = "Day 1";
            H.path2.describ.Text = describ.Text;
            this.Hide();
            H.path2.Show();
            H.path2.r3.Visible = true;
          
        }

        private void corolla_Click(object sender, EventArgs e)
        {
            // same just adjust for corolla instead of r3.
            H.Mood = H.Mood + 2;
            r3.Visible = false;
            corolla.Visible = false;
            fourt.Visible = false;
            ninet.Visible = false;
            H.path1.next1.Visible = true;
            //------------------------------------
            H.path1.corolla.Visible = true;
            H.M = H.M - 9000;//HERE
            H.path1.describ.Text = describ.Text;
            H.path1.output.Text = "Congratulations! You have purchased a new Toyota Corolla! You have been charged $9000. This concludes your tutorial day! Press the Next button to move on to day 2!";
            H.path1.daylabel.Text = "Day 1";
            this.Hide();
            H.path1.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            //exit on demand
            Environment.Exit(0);
        }

        private void Lifedecision500_Load(object sender, EventArgs e)
        {

        }
    }
}
